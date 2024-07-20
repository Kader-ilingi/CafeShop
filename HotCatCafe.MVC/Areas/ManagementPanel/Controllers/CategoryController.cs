using HotCatCafe.BLL.Repositories.Abstracts.BaseAbstract;
using HotCatCafe.BLL.ViewModels.CategoryViewModels;
using HotCatCafe.Model.Entities;
using Microsoft.AspNetCore.Mvc;

namespace HotCatCafe.MVC.Areas.ManagementPanel.Controllers
{
    [Area("ManagementPanel")]
    public class CategoryController : Controller
    {
        private readonly ICategoryRepository _categoryRepository;

        //todo:ICategoryservice te bulunan getactivecs categories metot tarafındfan ilentine verile index sayfasında gösterilecek.

        public CategoryController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public IActionResult Index()
        {

            var categories=_categoryRepository.GetActivesCategories().OrderByDescending(x=>x.CreatedDate).ToList();
            return View(categories);
        }
        //todo:create

        public IActionResult Create() 
        { 
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(CategoryViewModel categoryViewModel) 
        {

            if (ModelState.IsValid)
            {
                Category category=new Category
                {
                    CategoryName = categoryViewModel.CategoryName,
                    Description = categoryViewModel.Description,
                };
                
              string result= await _categoryRepository.CreateCategoryAsync(category);
                TempData["Result"]=result;
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View(categoryViewModel);
            }
            
        }
        //todo:delete
        //todo:getactivecs
        //todo:update
    }
}
