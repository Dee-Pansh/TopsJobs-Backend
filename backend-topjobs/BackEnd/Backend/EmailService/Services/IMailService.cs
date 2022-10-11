using System.Threading.Tasks;
using EmailService.Model;
namespace EmailService.Services
{
    public interface IMailService
    {
        Task SendEmailAsync(MailRequest mailRequest);
    }
}
