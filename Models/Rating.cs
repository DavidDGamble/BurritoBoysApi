using System.ComponentModel.DataAnnotations;

namespace BurritoBoysApi.Models
{
  public class Rating {
    public int RatingId { get; set; }
    [Required]
    public int Rate { get; set; }
    [Required]

    public int SpotId { get; set; }
  }
}