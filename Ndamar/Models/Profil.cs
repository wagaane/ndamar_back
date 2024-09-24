using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ndamar.Models
{
    [Table("TP_Profil")]
    public class Profil
	{
        [Key]
        public string Id { get; set; }

        [StringLength(30)]
        [Required]
        public string Libelle { get; set; }

        [StringLength(10)]
        [Required]
        public string Code { get; set; }

    }
}

