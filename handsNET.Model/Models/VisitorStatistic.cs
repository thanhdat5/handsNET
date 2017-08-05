using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace handsNET.Model.Models
{
    [Table("VisitorStatistic")]
    public class VisitorStatistic
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        public DateTime Visited { get; set; }

        [Required]
        [MaxLength(50)]
        public string IPAddress { get; set; }
    }
}