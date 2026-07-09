using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ExpenseTracker2.Controllers
{
    public class ArtifactsController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Username = User.Identity?.Name;
            ViewBag.CartCount = HttpContext.Session.GetInt32("CartCount") ?? 0;
            return View();
        }


        [Authorize]
        [HttpGet]
        public IActionResult Bid(int id)
        {
            // You can fetch artifact details by id from DB if needed
            ViewBag.ArtifactId = id;
            return View(); // This will render Bid.cshtml
        }



        [Authorize]
        [HttpPost]
        public IActionResult ConfirmBid(int artifactId)
        {
            int currentCount = HttpContext.Session.GetInt32("CartCount") ?? 0;
            HttpContext.Session.SetInt32("CartCount", currentCount + 1);

            TempData["Message"] = $"Your bid for artifact #{artifactId} was placed successfully.";
            return RedirectToAction("Index");
        }
    }
}
