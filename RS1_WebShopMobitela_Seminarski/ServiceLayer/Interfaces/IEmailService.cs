using ServiceLayer.Classes.Helper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Interfaces
{
    public interface IEmailService
    {
        Task SendEmailAsync(MailRequest mailRequest);
        Task SendEmailToMyselfAsync(MailRequest mailRequest);
    }
}
