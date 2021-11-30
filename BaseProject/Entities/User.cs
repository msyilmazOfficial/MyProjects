using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class User
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }

        [StringLength(50)]
        public string LogInId { get; set; }

        [StringLength(50)]
        public string LogInPassword { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        public DateTime BirthDate { get; set; }

    }
}
