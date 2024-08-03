

using System.Threading.Tasks;

namespace HotCatCafe.BLL.Repositories.Abstracts.BaseAbstract.EmailService
{
    public interface IEmailService
    {
        Task SendEmailAsync(string toEmail, string subject, string message);
        Task CheckAndNotifyStockLevelAsync(int productId);

    }
}
