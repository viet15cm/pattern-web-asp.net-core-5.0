using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpaServices.Services.MailServices
{
    public interface ISendMailServices
    {
        Task SendMail(MailContent content);
        Task<bool> SendMailAsync(MailContent content);
    }
}
