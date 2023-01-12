using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class Stock : Base
    {
        [Required]
        [StringLength(100)]
        public string? Name { get; set; }

        public int RetailTaxRate { get; set; }

        public int WholeSaleTaxRate { get; set; }

    }
}