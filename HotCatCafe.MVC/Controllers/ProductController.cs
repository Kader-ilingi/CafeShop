using Microsoft.AspNetCore.Mvc;

namespace HotCatCafe.MVC.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
