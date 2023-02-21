using System.ComponentModel.DataAnnotations;

namespace P133Allup.Models
{
    public class Brand : BaseEntity
    {
        [StringLength(255,ErrorMessage ="Sadece 255 Simvol olmalidir")]
        [Required(ErrorMessage ="Mecburdur")]
        public string? Name { get; set; }
        public IEnumerable<Product>? Products { get; set; }
    }
}
