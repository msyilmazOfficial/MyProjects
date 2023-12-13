using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class Order : Base
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

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