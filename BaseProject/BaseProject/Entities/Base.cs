using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public abstract class Base
    {
        [Required]
        public int CreateUser { get; set; }

        [Required]
        public DateTime CreateDate { get; set; } = DateTime.Now;

        [Required]
        public int LastUpdateUser { get; set; }

        [Required]
        public DateTime LastUpdateDate { get; set; } = DateTime.Now;

        [Required]
        public int IsHidden { get; set; }
    }
}
