using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class Customer : Base
    {
        [Required]
        [StringLength(100)]
        public string? Name { get; set; }

        [StringLength(100)]
        public string? Email { get; set; }

        [StringLength(50)]
        public string? Phone { get; set; }

        public int TaxId { get; set; }

        public int PriceListNumber { get; set; }

        public int CurrencyCode { get; set; }

    }
}