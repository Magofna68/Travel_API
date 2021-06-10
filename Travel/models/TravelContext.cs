using Microsoft.EntityFrameworkCore;
using System;

namespace Travel.Models
{
  public class TravelContext : DbContext
  {
    public TravelContext(DbContextOptions<TravelContext> options) : base(options)
    {
    }

    public DbSet<Review> Reviews { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Review>()
      .HasData(
        new Review { ReviewId = 1, Name = "Mt. Everest", Location = "NYC", Description = "A big tall natural momument", Rating = 2, Recommended = true },

        new Review { ReviewId = 2, Name = "Great Pyramid", Location = "Egypt", Description = "Large 'man made' structure", Rating = 4, Recommended = false },

        new Review { ReviewId = 3, Name = "Niagara Falls", Location = "New York", Description = "Amazing", Rating = 5, Recommended = true }
      );
    }
  }
}