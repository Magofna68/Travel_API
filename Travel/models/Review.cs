using System.ComponentModel.DataAnnotations;
using System;

namespace Travel
{
  public class Review
  {
    [Required]
    public string Name { get; set; }
    [Required]
    public string Location { get; set; }
    [Required]
    public string Description { get; set; }
    [Required]
    [Range(1, 5, ErrorMessage = "Rating must be between 1-5")]
    public int Rating { get; set; }
    [Required]
    public bool Recommended { get; set; }
    [Required]
    public DateTime ReservationDate { get; set; }
    [Required]
    public DateTime ReviewDate { get; set; } = DateTime.Now;

  }
}
