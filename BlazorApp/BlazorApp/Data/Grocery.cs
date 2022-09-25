using System.ComponentModel.DataAnnotations;

namespace BlazorApp.Data
{
    public class Grocery
    {
        [Required]
        [StringLength(20, ErrorMessage="Name should be less than 20 characters.")]
        public string Name { get; set; }
        [Required]
        [Range(0.1,100000,ErrorMessage ="Between 0.1 and 100000")]
        public decimal Price { get; set; }
    }
}
