using HotCatCafe.BLL.Repositories.Concretes.EmailServices;
using HotCatCafe.Model.Entities;
using HotCatCafe.MVC.Models;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;

namespace HotCatCafe.MVC.Areas.ManagementPanel.Controllers
{
    public class InventoryController : Controller
    {
        private readonly InventoryService _inventoryService;
        private readonly SmtpSettings _smtpSettings;

        public InventoryController(InventoryService inventoryService, SmtpSettings smtpSettings)
        {
            _inventoryService = inventoryService;
            _smtpSettings = smtpSettings;
        }
        public async Task<IActionResult> CheckStok(int productId)
        {
            //Smtp ayarlarını kontrol et
            if (_smtpSettings== null)
            {
                return View("Error", new ErrorViewModel { RequestId = "Smtp ayarları yapılandırılmamış" ,
                    ErrorMessage = "SMTP ayarları doğru bir şekilde yapılandırılmamış. Lütfen sistem yöneticinizle iletişime geçin."
                });
            }
            if (string.IsNullOrEmpty(_smtpSettings.Host) ||
                _smtpSettings.Port <= 0 ||
                string.IsNullOrEmpty(_smtpSettings.UserName) ||
                string.IsNullOrEmpty(_smtpSettings.Password))
            {
                return View("Error", new ErrorViewModel { RequestId = "Smtp ayarları eksik veya geçersiz." ,
                    ErrorMessage = "SMTP ayarları eksik veya geçersiz. Lütfen SMTP ayarlarını kontrol edin ve tekrar deneyin."
                });
            }

            await _inventoryService.CheckAndNotifyStockLevelAsync(productId);
            return View();
        }
    }
}
