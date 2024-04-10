using Microsoft.AspNetCore.Mvc;

namespace BT3_TH.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}