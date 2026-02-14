using System.ComponentModel.DataAnnotations;

namespace activity1.Models
{
    public class SupplierName
    {
        [Key]
        public Guid SupplierId { get; set; } 

        [Required]
        public string SupplierNameValue { get; set; } = null!;  

        public string? Address { get; set; }
        public string? Email { get; set; }
        public int? TextCode { get; set; }
    }
}
