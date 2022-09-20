using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SpaServices.Models;
using SpaServices.Models.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpaServices.DbContextLayer
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public IConfiguration Configuration { get; }



        public AppDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public DbSet<Post> Posts { get; set; }

        public DbSet<Logo> Logos { get; set; }

        public DbSet<Footer> Footers { get; set; }
        public DbSet<Banner> Banners { get; set; }

        public DbSet<Image> Images { get; set; }

        public DbSet<Backgound> Backgounds { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Statistical> Statisticals { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer(Configuration.GetConnectionString("ContextConnectionLC"));
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            foreach (var item in builder.Model.GetEntityTypes())
            {
                var tableName = item.GetTableName();

                if (tableName.StartsWith("AspNet"))
                {
                    item.SetTableName(tableName.Substring(6));
                }

            }

            builder.Entity<Category>(entity => {
                entity.HasIndex(p => p.Slug);
            });

            builder.Entity<Post>(entity => {
                entity.HasIndex(p => p.Slug);
            });

            builder.Entity<Image>(entity => {
                entity.HasIndex(p => p.UrlImage);
            });

            builder.Entity<Logo>(entity => {
                entity.HasIndex(p => p.UrlImage);
            });

            builder.Entity<Banner>(entity => {
                entity.HasIndex(p => p.UrlImage);
            });

            builder.Entity<PostCategory>()
            .HasKey(bc => new { bc.CategoryId, bc.PostId });
                builder.Entity<PostCategory>()
                    .HasOne(bc => bc.Post)
                    .WithMany(b => b.PostCategories)
                    .HasForeignKey(bc => bc.PostId);
                builder.Entity<PostCategory>()
                    .HasOne(bc => bc.Category)
                    .WithMany(c => c.PostCategories)
                    .HasForeignKey(bc => bc.CategoryId);

        }
    }
}
