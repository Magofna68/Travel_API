using Microsoft.EnitityFrameworkCore;

namespace Travel.Models
{
  public class TravelContext : DbContext
  {
    public TravelContext(DbContextOptions<TravelContext> options) : base(options)
    {
    }

    public DbSet<Review> Reviews { get; set; }
  }
}