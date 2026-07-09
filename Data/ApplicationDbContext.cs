using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ExpenseTracker2.Models;
using System;
using ExpenseTracker.Models;
using Microsoft.AspNetCore.Identity;

namespace ExpenseTracker2.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public DbSet<Artwork> Artworks { get; set; }
        public DbSet<Bid> Bids { get; set; }
        public DbSet<Expense> Expenses { get; set; }


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
           : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Expense>(entity =>
            {
                entity.Property(e => e.Amount).HasPrecision(18, 2);

                entity.HasData(
                    new Expense
                    {
                        Id = 1,
                        Description = "Office Supplies",
                        Amount = 50.00m,
                        Date = new DateTime(2023, 1, 15)
                    },
                    new Expense
                    {
                        Id = 2,
                        Description = "Travel Expenses",
                        Amount = 300.00m,
                        Date = new DateTime(2023, 1, 20)
                    },
                    new Expense
                    {
                        Id = 3,
                        Description = "Utilities",
                        Amount = 120.00m,
                        Date = new DateTime(2023, 1, 25)
                    }
                );
            });

            // ✅ Add this block below the Expense seed
            modelBuilder.Entity<Artwork>().HasData(
                new Artwork
                {
                    Id = 1,
                    Title = "Sample Artwork",
                    Description = "This is a seeded artwork for testing bids.",
                    Price = 1500,
                    Category = "Painting"
                }
            );
        }

    }
}
