using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ndamar.Models
{
    [Table("TP_Voiture")]
    public class Voiture
	{
        [Key]
        public string Id { get; set; }

        [StringLength(30)]
        [Required]
        public string marque { get; set; }

        [StringLength(30)]
        [Required]
        public string gamme { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime annee { get; set; }

        [StringLength(30)]
        [Required]
        public string modele { get; set; }

        [StringLength(15)]
        [Required]
        public TypeDeTransmission transmission { get; set; }

        [StringLength(15)]
        [Required]
        public TypeCarburant carburant { get; set; }


    }


    public enum TypeDeTransmission
    {
        MANUELLE = 1,
        AUTOMATIQUE =2
    }

    public enum TypeCarburant
    {
        ESSENCE = 1,
        DIESEL = 2,
        ELECTRIQUE = 3
    }
}

