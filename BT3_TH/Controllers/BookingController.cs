using Microsoft.AspNetCore.Mvc;

namespace BT3_TH.Controllers
{
    public class BookingController : Controller
    {
        public IActionResult Booking()
        {
            return View();
        }
    }
}
