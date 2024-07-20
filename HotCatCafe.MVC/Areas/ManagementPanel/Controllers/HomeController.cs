using Microsoft.AspNetCore.Mvc;

namespace HotCatCafe.MVC.Areas.ManagementPanel.Controllers
{
    public class HomeController : Controller
    {
        [Area("ManagementPanel")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
