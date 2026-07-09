using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ExpenseTracker2.Models;
using ExpenseTracker2.Data;
using Microsoft.Extensions.Logging;
using System.Security.Claims;

namespace ExpenseTracker2.Controllers
{
    public class BidsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<BidsController> _logger;

        public BidsController(ApplicationDbContext context, ILogger<BidsController> logger)
        {
            _context = context;
            _logger = logger;
        }

        // Show all bids
        [AllowAnonymous]
        public IActionResult Dashboard()
        {
            var bids = _context.Bids.OrderByDescending(b => b.Timestamp).ToList();
            return View(bids);
        }

        // Show bid form
        [Authorize]
        [HttpGet]
        public IActionResult BidForm(int id) // Renamed for consistency with your button
        {
            var model = new BidViewModel { ArtworkId = id };
            return View(model);
        }

        // Submit the bid
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SubmitBid(BidViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View("BidForm", model);
            }

            // Get current user ID
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (string.IsNullOrEmpty(userId))
            {
                return Unauthorized();
            }

            var bid = new Bid
            {
                FullName = model.FullName,
                Email = model.Email,
                Address = model.Address,
                PhoneNumber = model.PhoneNumber,
                Amount = model.BidAmount,
                ArtworkId = model.ArtworkId,
                Timestamp = DateTime.Now,
                UserId = userId // Required to prevent SQL error
            };

            _context.Bids.Add(bid);
            _context.SaveChanges();

            _logger.LogInformation($"New bid submitted: {bid.FullName}, R{bid.Amount} on Artwork {bid.ArtworkId}");

            TempData["SuccessMessage"] = "Bid submitted successfully!";
            return RedirectToAction("Dashboard");
        }
    }
}
