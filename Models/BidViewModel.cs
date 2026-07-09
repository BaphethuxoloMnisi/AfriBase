using System.ComponentModel.DataAnnotations;

namespace ExpenseTracker2.Models
{
    public class BidViewModel
    {
        public int ArtworkId { get; set; }

        [Required]
        public string FullName { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        public string Address { get; set; }

        public string PhoneNumber { get; set; }

        [Required, Range(1, double.MaxValue, ErrorMessage = "Bid must be greater than 0")]
        public decimal BidAmount { get; set; }
    }
}
