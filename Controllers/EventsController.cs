using Microsoft.AspNetCore.Mvc;

namespace ExpenseTracker2.Controllers
{
    public class EventsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
