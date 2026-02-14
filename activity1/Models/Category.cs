using System.ComponentModel.DataAnnotations;

namespace activity1.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; } 

        [Required]
        public string CategoryName { get; set; } = null!;

        public string? Description { get; set; }
    }
}
