using System.ComponentModel.DataAnnotations;

namespace ExpenseTracker2.Models
{
    public class Artwork
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public string Description { get; set; }

        [Required]
        public decimal Price { get; set; }   // ✅ Add this

        public string Category { get; set; } // ✅ And this
    }
}
