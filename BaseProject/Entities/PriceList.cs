using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class PriceList : Base
    {
        [Required]
        [StringLength(100)]
        public string? Name { get; set; }

        [Required]
        public int Number { get; set; }

        [Required]
        public int StockId { get; set; }

        [Required]
        public float Price { get; set; }

        public float Discount { get; set; }
    }

}