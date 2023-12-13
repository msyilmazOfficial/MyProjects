using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class Customer : Base
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

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