using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PageEnglish.Services.IdentityStoreServices;
using SpaServices.DbContextLayer;
using SpaServices.IdentityErrors;
using SpaServices.Models.Identity;
using SpaServices.Security.Requirements;
using SpaServices.Services.MailServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpaServices
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();


            services.AddTransient<AppDbContext>();
            services.AddTransient<ISendMailServices, SendMailServices>();

            services.Configure<MailSetting>(Configuration.GetSection("MailSetting"));

            var lockoutOptions = new LockoutOptions()
            {
                AllowedForNewUsers = true,
                DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5),
                MaxFailedAccessAttempts = 5
            };

            services.AddIdentity<AppUser, IdentityRole>()
              .AddEntityFrameworkStores<AppDbContext>()
              .AddSignInManager<UserNameEmailSignInManager>()
              .AddDefaultTokenProviders();



            services.Configure<IdentityOptions>(options => {

                //Thiết lập về Password
                options.Password.RequireDigit = false; // Không bắt phải có số
                options.Password.RequireLowercase = false; // Không bắt phải có chữ thường
                options.Password.RequireNonAlphanumeric = false; // Không bắt ký tự đặc biệt
                options.Password.RequireUppercase = false; // Không bắt buộc chữ in
                options.Password.RequiredLength = 8; // Số ký tự tối thiểu của password
                options.Password.RequiredUniqueChars = 1; // Số ký tự riêng biệt


                // Cấu hình Lockout - khóa user
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5); // Khóa 5 phút
                options.Lockout.MaxFailedAccessAttempts = 5; // Thất bại 5 lầ thì khóa
                options.Lockout.AllowedForNewUsers = true;


                // Cấu hình về User.
                options.User.AllowedUserNameCharacters = // các ký tự đặt tên user
                    "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";

                options.User.RequireUniqueEmail = true;  // Email là duy nhất

                options.Lockout = lockoutOptions; // khóa lockout

                //Cấu hình đăng nhập.
                options.SignIn.RequireConfirmedEmail = false;            // Cấu hình xác thực địa chỉ email (email phải tồn tại)
                options.SignIn.RequireConfirmedPhoneNumber = false;     // Xác thực số điện thoại
                options.SignIn.RequireConfirmedAccount = false;
            });
            // Thiết lập , nếu IsPersistent = true thì đăng nhập user sẽ duy trì trong 1 ngày ,  IsPersistent = fasle thì đăng nhập user sẽ duy trì mãi mãi , với cookie máy khách 
            services.ConfigureApplicationCookie(option =>
            {
                option.ExpireTimeSpan = TimeSpan.FromDays(1);
                option.LoginPath = "/Identity/Account/Login";
                option.LogoutPath = "/Identity/Account/Logout";
                option.AccessDeniedPath = $"/Identity/Account/Manager/AccessDenied";
            });


            services.AddAuthorization(options => {

                options.AddPolicy("Admin", builder => {
                    builder.RequireAuthenticatedUser();
                    builder.RequireRole("Admin");
             
                });

                options.AddPolicy("Employee", builder =>
                {
                    builder.RequireAuthenticatedUser();
                    builder.RequireRole("Admin", "Employee");
                });

            });

            services.AddTransient<IAuthorizationHandler, NewUpdatePostHandler>();
            services.AddTransient<IAuthorizationHandler, CanOptionPostUserHandler>();
            services.AddTransient<IAuthorizationHandler, CanOptionCategoryUserHandler>();
            services.AddSingleton<IdentityErrorDescriber, AppIdentityErrorDescriber>();
            services.AddSingleton<AppIdentityErrorDescriber>();

            services.AddRazorPages();
            services.AddControllersWithViews();
           
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();   // Phục hồi thông tin đăng nhập (xác thực)
            app.UseAuthorization();   // Phục hồi thông tinn về quyền của User

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");

                endpoints.MapRazorPages();
            });
        }
    }
}
