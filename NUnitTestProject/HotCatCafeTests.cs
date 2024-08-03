using HotCatCafe.BLL.Repositories.Abstracts.BaseAbstract.EmailService;
using HotCatCafe.BLL.Repositories.Abstracts.BaseAbstract.EntityServices;
using HotCatCafe.BLL.Repositories.Concretes.EmailServices;
using HotCatCafe.BLL.Repositories.Concretes.EntityServices;
using HotCatCafe.DAL.Context;
using HotCatCafe.Model.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTestProject
{
    ////public class HotCatCafeTests
    //{
    //    private InventoryService _inventoryService;
    //    private IProductRepository _productRepository;
    //    private IEmailService _emailService;
    //    private HotCatCafeContext _cafeContext;
    //    private SmtpSettings _smtpSettings;

    //    [SetUp]
    //    public void Setup()
    //    {
    //        _cafeContext = TestDbContextFactory.CreateDbContext();

    //        _productRepository = new ProductService(_cafeContext);
    //        var smtpSettings = new SmtpSettings
    //        {
    //            Host = "smtp-relay.brevo.com", // Brevo’nun SMTP sunucu adresi
    //            Port = 587,// Brevo’nun SMTP portu
    //            UserName = "79b1f3001@smtp-brevo.com", // SMTP kullanıcı adınız
    //            Password = "sV2XGAPgSkaJMCUZ"
    //        };

    //        _emailService = new SmtpSettings(smtpSettings);//gerçek impletasyon
    //        _inventoryService = new InventoryService(_emailService, _productRepository);

    //    }
    //    [Test]
    //    public async Task CheckAndNotifyStockLevelAsync_ProductStockBelowThreshold_SendsEmail()
    //    {
    //        // Arrange
    //        var productId = 15;
    //        var product = new Product
    //        {
    //            // ID değerini ayarlamayın; otomatik olarak atanır//ID = productId,
    //            ProductName= "Vanilla Ice Cream",
    //            Stock = 10 ,
    //            CategoryId = 8 // Var olan bir kategori ID'si// Eşiğin altında
    //        };

    //        // Veritabanına ürünü ekleyin
    //        _cafeContext.Products.Add(product);
    //        await _cafeContext.SaveChangesAsync();

    //        // Act
    //        await _inventoryService.CheckAndNotifyStockLevelAsync(productId);

    //        // Assert
    //        // E-posta gönderim işlemini kontrol edin
    //        // Bu aşamada, gerçek e-posta gönderimi yapılacak ve bunu doğrulamak zor olabilir.
    //        // Gerçek e-posta gönderimini test etmek yerine e-posta gönderim loglarını kontrol edebilirsiniz.
    //        // Bu aşamada, test e-posta sunucunuzun e-posta aldığını kontrol edin

    //    }

    //    [Test]
    //    public async Task CheckAndNotifyStockLevelAsync_ProductStockAboveThreshold_DoesNotSendEmail()
    //    {
    //        // Arrange
    //        var productId = 17;
    //        var product = new Product
    //        {
    //            // ID değerini ayarlamayın; otomatik olarak atanır//ID = productId,
    //            ProductName= "Cheesecake",
    //            Stock = 25 ,
    //            CategoryId = 9 // Var olan bir kategori ID'si// Eşiğin üstünde
    //        };

    //        _cafeContext.Products.Add(product);
    //        await _cafeContext.SaveChangesAsync();

    //        // Act
    //        await _inventoryService.CheckAndNotifyStockLevelAsync(productId);

    //        // Assert
    //        // E-posta gönderimi yapılmamalı, bunu doğrulamak için e-posta sunucusunu kontrol edin
           

    //    }
    //    [Test]
    //    public async Task CheckAndNotifyStockLevelAsync_ProductNotFound_DoesNotSendEmail()
    //    {
    //        // Arrange
    //        var productId = 999; // Mevcut olmayan ürün ID'si

    //        // Act
    //        await _inventoryService.CheckAndNotifyStockLevelAsync(productId);

    //        // Assert
    //        // E-posta gönderimi yapılmamalı, bunu doğrulamak için e-posta sunucusunu kontrol edin
    //    }

    //}
}
