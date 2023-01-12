using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class WareHouse : Base
    {
        [Required]
        [StringLength(50)]
        public string? Name { get; set; }

        public string? Address { get; set; }
    }
}