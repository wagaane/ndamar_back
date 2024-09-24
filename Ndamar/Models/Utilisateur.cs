using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ndamar.Models
{
    [Table("TD_Utilisateur")]
    public class Utilisateur
	{
        [Key]
        public string Id { get; set; }

        [StringLength(50)]
        [Required]
        public string Prenom { get; set; }

        [StringLength(50)]
        [Required]
        public string Nom { get; set; }

        [StringLength(50)]
        public string? Adresse { get; set; }

        [StringLength(13)]
        public string? Telephone { get; set; }

    }
}

