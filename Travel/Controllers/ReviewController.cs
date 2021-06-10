using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Travel.Models;
using System.Linq;

namespace Travel.AddControllers
{
  [Route("api/[Controller]")]
  [ApiController]
  public class ReviewsController : ControllerBase
  {
    private readonly TravelContext _db;
    public ReviewsController(TravelContext db)
    {
      _db = db;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Review>> Get(string name, int rating, bool recommended, string location)
    {
      var query = _db.Reviews.AsQueryable();

      if (name != null)
      {
        query = query.Where(entry => entry.Name == name);
      }

      if (rating != null)
      {
        query = query.Where(entry => entry.Rating == rating);
      }

      if (recommended = true || false)
      {
        query = query.Where(entry => entry.Recommended == recommended);
      }

      if (location != null)
      {
        query = query.Where(entry => entry.Location == location);
      }

      return query.ToList();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Review>> GetReview(int id)
    {
      var review = await _db.Reviews.FindAsync(id);
      if (review == null)
      {
        return NotFound();
      }

      return review;
    }

    [HttpPost]
    public async Task<ActionResult<Review>> Post(Review review)
    {
      _db.Reviews.Add(review);
      await _db.SaveChangesAsync();
      return CreatedAtAction(nameof(GetReview), new { id = review.ReviewId }, review);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Review review)
    {
      if (id != review.ReviewId)
      {
        return BadRequest();
      }

      _db.Entry(review).State = EntityState.Modified;

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!ReviewExists(id))
        {
          return NotFound();
        }
        else
        {
          throw;
        }
      }
      return NoContent();
    }
      private bool ReviewExists(int id)
      {
        return _db.Reviews.Any(e => e.ReviewId == id);
      }

      [HttpDelete("{id}")]
      public async Task<IActionResult> DeleteReview(int id)
      {
        var review = await _db.Reviews.FindAsync(id);
        if (review == null)
        {
          return NotFound();
        }

        _db.Reviews.Remove(review);
        await _db.SaveChangesAsync();

        return NoContent();
      }
    }
  }