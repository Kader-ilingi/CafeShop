using HotCatCafe.BLL.Repositories.Abstracts.BaseAbstract;
using Microsoft.AspNetCore.Mvc;

namespace HotCatCafe.MVC.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public IActionResult Index()
        {
            //test işlemlri için oluşturuldu ve başarılı bir şekilde testten geçildi.
            var categories=_categoryRepository.GetAllCategories();
            var category = _categoryRepository.GetCategoryById(18);
            var activesCategory=_categoryRepository.GetActivesCategories();
            var passivesCategory=_categoryRepository.GetPassivesCategories();


            return View();
        }
    }
}
