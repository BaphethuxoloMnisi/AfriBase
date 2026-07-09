using ExpenseTracker2.Data;
using ExpenseTracker2.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExpenseTracker2.Controllers
{
    public class ArtworksController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ArtworksController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index() => View(_context.Artworks.ToList());

        public IActionResult Create() => View();

        [HttpPost]
        public async Task<IActionResult> Create(Artwork artwork)
        {
            if (!ModelState.IsValid) return View(artwork);

            _context.Add(artwork);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(int id) =>
            View(_context.Artworks.FirstOrDefault(a => a.Id == id));

        [HttpPost]
        public async Task<IActionResult> Edit(Artwork artwork)
        {
            _context.Update(artwork);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int id)
        {
            var artwork = await _context.Artworks.FindAsync(id);
            if (artwork != null)
            {
                _context.Artworks.Remove(artwork);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }
    }

}
