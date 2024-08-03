using HotCatCafe.Model.Entities;
using Microsoft.AspNetCore.Mvc;
using HotCatCafe.BLL.ViewModels;
using HotCatCafe.BLL.ViewModels.CategoryViewModels;
using HotCatCafe.Common.ImageHelpers;
using Microsoft.AspNetCore.Mvc.Rendering;
using HotCatCafe.DAL.Context;
using HotCatCafe.BLL.Repositories.Abstracts.BaseAbstract.EntityServices;
using HotCatCafe.BLL.Repositories.Concretes.EmailServices;
using HotCatCafe.MVC.Models;
using HotCatCafe.BLL.Repositories.Abstracts.BaseAbstract.EmailService;
using Microsoft.Extensions.Options;

namespace HotCatCafe.MVC.Areas.ManagementPanel.Controllers
{
    [Area("ManagementPanel")]
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly HotCatCafeContext _context;
        private readonly SmtpSettings _smtpSettings;
        private readonly IEmailService _emailService;

        public ProductController(IProductRepository productRepository, ICategoryRepository categoryRepository, HotCatCafeContext context,IOptions< SmtpSettings> smtpSettings, IEmailService emailService)
        {
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
            _context = context;
            _emailService = emailService;
            _smtpSettings = smtpSettings.Value;
            
        }


        public IActionResult Index()
        {
            var products = _productRepository.GetAllProducts().OrderByDescending(x => x.CreatedDate).Select(x => new ProductViewModel
            {
                ProductId = x.ID,
                ProductName = x.ProductName,
                UnitPrice = x.Price,
                UnitsInStock = x.Stock,
                ImagePath = x.ImagePath,
                Status = (Model.Enums.DataStatus)x.Status,
                IsActive = x.IsActive,
                Size = x.DataSize
            }).ToList();

            return View(products);
            /////buna devam edilecek
        }
        // GET: Product/Create
        public IActionResult Create()
        {

            // Burada view model içindeki gerekli başlangıç değerlerini atayabilirsiniz
            // Örneğin kategorileri bir dropdown listesi olarak eklemek için:

            ViewBag.CategoryListItem = _categoryRepository.GetAllCategories().Select(x => new CategoryViewModel
            {
                CategoryName = x.CategoryName,
                Description = x.Description,
                ID = x.ID,
            }).Select(s => new SelectListItem
            {
                Text = s.CategoryName,
                Value = s.ID.ToString()
            });

            return View();
        }

        // POST: Product/Create
        [HttpPost]
        //[ValidateAntiForgeryToken]//VASP.NET Core MVC uygulamalarında CSRF saldırılarına karşı koruma sağlayan bir özniteliktir. Bu öznitelik, formdan gelen POST isteklerinin güvenlik token'ı ile doğrulanmasını sağlar. Token, sunucu tarafından üretilir, formda saklanır ve tarayıcı tarafından istekle birlikte gönderilir. Sunucu, bu token'ı kontrol ederek isteğin güvenilir olup olmadığını belirler.
        public async Task<IActionResult> Create(ProductViewModel productViewModel, IFormFile productImage)
        {

            if (ModelState.IsValid)
            {
                var ImageEditResult = ImageHelper.UploadImageAsync(productImage.FileName);

                if (ImageEditResult == "0")
                {
                    TempData["Error"] = "Görsel izin verilen formatta değil";
                    return View();
                }
                else
                {
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\Images\\ProductsImage", ImageEditResult);
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        productImage.CopyToAsync(stream);
                    }


                    Product product = new Product
                    {
                        ProductName = productViewModel.ProductName,
                        Price = productViewModel.UnitPrice,
                        Stock = productViewModel.UnitsInStock,
                        CategoryId = productViewModel.CategoryId,
                        ImagePath = ImageEditResult
                    };
                    var result = await _productRepository.CreateProductAsync(product);

                    return RedirectToAction("Index", "Home");//buraya openclosed uygulanabilir

                    // Eğer ModelState geçersiz ise, view modeli tekrar gönderin ve hataları gösterin


                }
            }
            else
            {
                return View(productViewModel);
            }


        }
        public async Task<IActionResult> Delete(int id)
        {
            var product=  _productRepository.GetProductByIdAsync(id);
            if(product == null)
            {
                return NotFound();
            }
            var productViewModel = new ProductViewModel
            {
                ProductId = product.Id,
                ProductName = product.Result.ProductName,
                CategoryId = product.Result.CategoryId,
                UnitPrice = product.Result.Price,
                UnitsInStock = product.Result.Stock,
                ImagePath = product.Result.ImagePath,
                IsActive = product.Result.IsActive,
                Status = product.Result.Status,
                Size = product.Result.DataSize
            };
            //var productViewModel = new ProductViewModel
            //{
            //    ProductId = product.Id,
            //    ProductName = product.Result.ProductName,
            //    CategoryId = product.CategoryId,
            //    UnitPrice = product.Price,
            //    UnitsInStock = product.Stock,
            //    ImagePath = product.ImagePath,
            //    IsActive = product.IsActive,
            //    Status = product.Status,
            //    Size = product.DataSize
            //};
            return View(productViewModel);
        }

        [HttpPost]//Admin için oluşturuldu 
        public async Task<IActionResult> Delete(ProductViewModel viewModel)
        {
            var productDeleted=_productRepository.GetProductByIdAsync(viewModel.ProductId);

            try
            {
                await _productRepository.DeleteProductAsync(await productDeleted);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ViewData["ErrorMessage"] = "Error occurred while deleting product: " + ex.Message;
                return View("Delete", productDeleted);
            }
            

            
        }
       
        public async Task<IActionResult> CheckStok(int productId)
        {
            //Smtp ayarlarını kontrol et
            if (_smtpSettings == null)
            {
                return View("Error", new ErrorViewModel
                {
                    RequestId = "Smtp ayarları yapılandırılmamış",
                    ErrorMessage = "SMTP ayarları doğru bir şekilde yapılandırılmamış. Lütfen sistem yöneticinizle iletişime geçin."
                });
            }
            if (string.IsNullOrEmpty(_smtpSettings.Host) ||
                _smtpSettings.Port <= 0 ||
                string.IsNullOrEmpty(_smtpSettings.UserName) ||
                string.IsNullOrEmpty(_smtpSettings.Password))
            {
                return View("Error", new ErrorViewModel
                {
                    RequestId = "Smtp ayarları eksik veya geçersiz.",
                    ErrorMessage = "SMTP ayarları eksik veya geçersiz. Lütfen SMTP ayarlarını kontrol edin ve tekrar deneyin."
                });
            }

            await _emailService.CheckAndNotifyStockLevelAsync(productId);
            return View();
        }

    }
}
