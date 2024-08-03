using HotCatCafe.BLL.Repositories.Abstracts.BaseAbstract.EmailService;
using HotCatCafe.BLL.Repositories.Abstracts.BaseAbstract.EntityServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotCatCafe.BLL.Repositories.Concretes.EmailServices
{
    public class InventoryService
    {
        private readonly IEmailService _emailService;
        private readonly IProductRepository _productRepository;
        private readonly int _stockThreshold = 15;

        public InventoryService(IEmailService emailService, IProductRepository productRepository)
        {
            _emailService = emailService;
            _productRepository = productRepository;
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



                    await _emailService.SendEmailAsync(
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
