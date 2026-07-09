using Microsoft.AspNetCore.Mvc;

namespace ExpenseTracker2.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
