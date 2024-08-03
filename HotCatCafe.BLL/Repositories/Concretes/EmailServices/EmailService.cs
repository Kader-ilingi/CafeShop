using HotCatCafe.BLL.Repositories.Abstracts.BaseAbstract.EmailService;
using HotCatCafe.BLL.Repositories.Abstracts.BaseAbstract.EntityServices;
using HotCatCafe.Model.Entities;
using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.Extensions.Options;
using MimeKit;

namespace HotCatCafe.BLL.Repositories.Concretes.EmailServices
{
    public class EmailService : IEmailService
    {

        private readonly SmtpSettings _smtpSettings;
        private readonly IProductRepository _productRepository;
        private readonly int _stockThreshold = 15;

        public EmailService(IOptions<SmtpSettings> smtpSettings, IProductRepository productRepository)
        {
            _smtpSettings =smtpSettings.Value;
            _productRepository = productRepository;
        }


        public async Task SendEmailAsync(string toEmail, string subject, string message)
        {
            var emailMessage = new MimeMessage();
            emailMessage.From.Add(new MailboxAddress("CoffeShop", "79b1f3001@smtp-brevo.com"));
            emailMessage.To.Add(new MailboxAddress("kaderilingi@hotmail.com ", toEmail));
            emailMessage.Subject = subject;
            emailMessage.Body = new TextPart("stok uyarısı")

            {
                Text = message
            };

            using (var client = new SmtpClient())
            {
                await client.ConnectAsync(_smtpSettings.Host, _smtpSettings.Port, SecureSocketOptions.StartTls);
                await client.AuthenticateAsync(_smtpSettings.UserName, _smtpSettings.Password);
                await client.SendAsync(emailMessage);
                await client.DisconnectAsync(true);
            }
        }
        public async Task CheckAndNotifyStockLevelAsync(int productId)///productıd nereden getiriliyor araştır
        {
            try
            {
                var product = await _productRepository.GetProductByIdAsync(productId);
                if (product != null && product.Stock < _stockThreshold)
                {
                    //E-posta mesajını oluşturma
                    var subject = "Stok uyarısı";
                    var body = $"Ürün ID {product.ID} stok eşiğinin altına düştü. Mevcut stok: {product.Stock}";



                    await SendEmailAsync(
                        "kaderilingi@hotmail.com",//e-posta adresi
                        subject, //e-posta konusu
                        body);   //e-posta gövdesi)
                }
            }
            catch (Exception ex)
            {
                // Hata yönetimi: hata mesajını loglayın veya uygun bir şekilde işleyin
                Console.WriteLine($"E-posta gönderim hatası: {ex.Message}");

            }


        }
    }
}
