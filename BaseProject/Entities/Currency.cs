using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class Currency : Base
    {
        [Required]
        [StringLength(50)]
        public string? Name { get; set; }

        public string Symbol { get; set; }
    }
}