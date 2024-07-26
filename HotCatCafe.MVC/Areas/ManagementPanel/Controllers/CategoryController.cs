using HotCatCafe.BLL.Repositories.Abstracts.BaseAbstract;
using HotCatCafe.BLL.Repositories.Concretes.EntityServices;
using HotCatCafe.BLL.ViewModels;
using HotCatCafe.BLL.ViewModels.CategoryViewModels;
using HotCatCafe.Model.Entities;
using Microsoft.AspNetCore.Mvc;

namespace HotCatCafe.MVC.Areas.ManagementPanel.Controllers
{
    [Area("ManagementPanel")]
    public class CategoryController : Controller
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IProductRepository _productRepository;

      
        public CategoryController(ICategoryRepository categoryRepository, IProductRepository productRepository)
        {
            _categoryRepository = categoryRepository;
            _productRepository = productRepository;
        }
        public IActionResult Index()
        {

            var categories = _categoryRepository.GetAllCategories().OrderByDescending(x => x.CreatedDate).Select(x => new CategoryViewModel
            {
                ID = x.ID,
                CategoryName = x.CategoryName,
                Description = x.Description,
                IsActive = x.IsActive,
                Status = x.Status
            }).ToList();
            return View(categories);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(CategoryViewModel categoryViewModel)
        {

            if (ModelState.IsValid)
            {
                Category category = new Category
                {
                    CategoryName = categoryViewModel.CategoryName,
                    Description = categoryViewModel.Description,
                };

                string result = await _categoryRepository.CreateCategory(category);
                TempData["Result"] = result;
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View(categoryViewModel);
            }

        }
        //Update
        public IActionResult Update(int id)
        {
            var category = _categoryRepository.GetCategoryById(id);
            //
            if (category==null)
            {
                return RedirectToAction("Index");
            }
            //, "Category", new { area = "ManagementPanel" }----ileride kullanalım

            CategoryViewModel categoryViewModel = new CategoryViewModel
            {
                ID = category.ID,
                CategoryName = category.CategoryName,
                Description = category.Description,
                IsActive = category.IsActive,
                Status = category.Status
            };
            return View(categoryViewModel);
        }
        [HttpPost]
        public async Task<IActionResult> Update(CategoryViewModel categoryView)
        {
            if (ModelState.IsValid)
            {
                Category categoryUpdated = new Category
                {
                    ID = categoryView.ID,
                    CategoryName = categoryView.CategoryName,
                    Description = categoryView.Description,
                    IsActive = categoryView.IsActive,
                    Status = categoryView.Status
                };

                await _categoryRepository.UpdateCategory(categoryUpdated);

                return RedirectToAction("Index");
            }
            else
            {
                return View(categoryView);
            }
        }

        //delete
        public async Task<IActionResult> Delete(int id)
        {
            var category =  _categoryRepository.GetCategoryById(id);
            if (category==null)
            {
                return NotFound();
            }
            var categoryViewModel = new CategoryViewModel
            {
                ID = category.ID,
                CategoryName = category.CategoryName,
                Description = category.Description,
                IsActive = category.IsActive,
                Status = category.Status
            };
            return View(categoryViewModel);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> Delete(CategoryViewModel categoryViewModel)
        {
            var categoryDeleted= _categoryRepository.GetCategoryById(categoryViewModel.ID);
            //if ==null)
            //{
            //    return NotFound();
            //}
            try
            {
                await _categoryRepository.DeleteCategory(categoryDeleted);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {

                ViewData["ErrorMessage"] = "Error occurred while deleting category: " + ex.Message;
                return View("Delete", categoryDeleted);
            }
        }
        public IActionResult Details(int id)
        {
            var products = _productRepository.GetProductByCategoryId(id);

            if (products.Count > 0)
            {
                var productsMV = products.Select(x => new ProductViewModel()
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

                return View(productsMV);
            }

            return RedirectToAction("Index", "Home");
        }

        //List active categories
        public IActionResult Active()
        {
            var categories = _categoryRepository
            .GetActiveCategories()
            .OrderByDescending(x => x.CreatedDate)
            .Select(x => new CategoryViewModel
            {
                ID = x.ID,
                CategoryName = x.CategoryName,
                Description = x.Description,
                IsActive = x.IsActive,
                Status = x.Status
            }).ToList();
            return View(categories);
        }

        ///List Passive Categories
        public IActionResult Passive()
        {
            var categories = _categoryRepository
                .GetPassiveCategories()
                .OrderByDescending(x => x.CreatedDate)
                .Select(x => new CategoryViewModel
                {
                    ID = x.ID,
                    CategoryName = x.CategoryName,
                    Description = x.Description,
                    IsActive = x.IsActive,
                    Status = x.Status
                }).ToList();
            return View(categories);
        }
    }
}
    
