using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ndamar.Models
{
    [Table("TD_Publication")]
    public class Publication
	{
        [Key]
        public string Id { get; set; }

        [StringLength(50)]
        [Required]
        public string Titre { get; set; }

        [StringLength(300)]
        [Required]
        public string Description { get; set; }

        [Required]
        public string Montant { get; set; }

        [DataType(DataType.Date)]
        [Required]
        public DateTime Date { get; set; }



    }
}

