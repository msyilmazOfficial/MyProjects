using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class Unit : Base
    {
        [Required]
        [StringLength(50)]
        public string? Name { get; set; }

        [Required]
        public int StockId { get; set; }

        [Required]
        public bool IsFirst { get; set; }

        [Required]
        public float Rate { get; set; }
    }
}