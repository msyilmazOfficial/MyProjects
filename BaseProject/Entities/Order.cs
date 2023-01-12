using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class Order : Base
    {
        [Required]
        public DateTime DeliveryDate { get; set; }

        [Required]
        public int Type { get; set; }

        [Required]
        public int CustomerId { get; set; }

        [Required]
        public int StockId { get; set; }

        [Required]
        public int UnitId { get; set; }

        [Required]
        public float Amount { get; set; }

        [Required]
        public float Price { get; set; }

        [Required]
        public float Discount { get; set; }

        [Required]
        public float CurrencyId { get; set; }

        [Required]
        public float WareHouseId { get; set; }
    }

}