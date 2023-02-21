using System.ComponentModel.DataAnnotations;

namespace P133Allup.Models
{
    public class Brand : BaseEntity
    {
        [StringLength(255)]
        public string Name { get; set; }
    }
}
