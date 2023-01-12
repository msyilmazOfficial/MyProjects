using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class StocOperation : Base
    {
        [Required]
        public int Type { get; set; }

        [Required]
        public int CustomerOperationId { get; set; }

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