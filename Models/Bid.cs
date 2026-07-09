
using ExpenseTracker2.Models;
using Microsoft.AspNetCore.Identity;

public class Bid
{
    public int Id { get; set; }
    public string FullName { get; set; }
    public string Email { get; set; }
    public string Address { get; set; }
    public string PhoneNumber { get; set; }
    public decimal Amount { get; set; }
    public int ArtworkId { get; set; }
    public DateTime Timestamp { get; set; }
    public string UserId { get; set; }

    
}


