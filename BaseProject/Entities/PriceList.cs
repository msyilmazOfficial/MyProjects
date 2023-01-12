using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class PriceList : Base
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

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