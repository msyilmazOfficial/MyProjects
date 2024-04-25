using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class ServiceOperation : Base
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public int Type { get; set; }

        [Required]
        public int CustomerOperationId { get; set; }

        [Required]
        [ForeignKey(nameof(CustomerOperationId))]
        public virtual CustomerOperation? CustomerOperation { get; set; }

        [Required]
        public int CustomerId { get; set; }

        [Required]
        [ForeignKey(nameof(CustomerId))]
        public virtual Customer? Customer { get; set; }

        [Required]
        public int ServiceId { get; set; }

        [Required]
        [ForeignKey(nameof(ServiceId))]
        public virtual Service? Service { get; set; }

        [Required]
        public int UnitId { get; set; }

        [Required]
        [ForeignKey(nameof(UnitId))]
        public virtual Unit? Unit { get; set; }

        [Required]
        public float Amount { get; set; }

        [Required]
        public float Price { get; set; }

        [Required]
        public float Discount { get; set; }

        [Required]
        public int CurrencyId { get; set; }

        [Required]
        [ForeignKey(nameof(CurrencyId))]
        public virtual Currency? Currency { get; set; }

        [Required]
        public int WareHouseId { get; set; }

        [Required]
        [ForeignKey(nameof(WareHouseId))]
        public virtual WareHouse? WareHouse { get; set; }
    }
}