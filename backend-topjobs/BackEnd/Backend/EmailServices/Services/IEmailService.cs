using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmailServices.Models;

namespace EmailServices.Services
{
    public interface IEmailService
    {
        bool SendEmail(EmailServices.Models.EmailData emailData);
    }
}
