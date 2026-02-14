using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace activity1.Models
{
    public class Products
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BatchNumber { get; set; }  

        [Required]
        public string ProductName { get; set; } = null!;

        [Required]
        public int Quantity { get; set; }

        [Required]
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public Category? Category { get; set; }

        [Required]
        [ForeignKey("Supplier")]
        public Guid SupplierId { get; set; }
        public SupplierName? Supplier { get; set; }

        [Required]
        public DateTime DateArrive { get; set; }

        [Required]
        public DateTime DateExpired { get; set; }
    }
}
