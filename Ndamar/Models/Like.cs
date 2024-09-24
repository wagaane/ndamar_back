using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ndamar.Models
{
    [Table("TD_Like")]
    public class Like
	{
        [Key]
        public string Id { get; set; }

        [DataType(DataType.Date)]
        [Required]
        public DateTime Date { get; set; }


    }
}

