using System.ComponentModel.DataAnnotations;

namespace BlazorApp.Data
{
    public class RestaurantFood
    {   
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required(ErrorMessage ="Description is Required")]
        public string? Description { get; set; }

        [Required]
        [Range(0,100, ErrorMessage = "{0} must between {1} and {2}")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Delicious Score is required")]
        public int Score { get; set; }
    }
}
