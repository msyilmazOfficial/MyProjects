using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class CustomerOperation : Base
    {
        [Required]
        public int Type { get; set; }

        [Required]
        public int CustomerId { get; set; }

        [Required]
        public float Amount { get; set; }

        [Required]
        public float Price { get; set; }

        [Required]
        public float Discount { get; set; }

        [Required]
        public float CurrencyId { get; set; }
    }

}