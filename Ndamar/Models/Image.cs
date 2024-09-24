using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ndamar.Models
{
    [Table("TD_Image")]
    public class Image
	{
        [Key]
        public string Id { get; set; }

        [StringLength(100)]
        [Required]
        public string Nom { get; set; }

    }
}

