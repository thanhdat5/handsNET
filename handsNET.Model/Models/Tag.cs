using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace handsNET.Model.Models
{
    [Table("Tag")]
    public class Tag
    {
        [Key]
        [MaxLength(50)]
        public string ID { get; set; }
        [Required]
        [MaxLength(50)]
        public string TagName { get; set; }
        [MaxLength(50)]
        public string Type { get; set; }
    }
}
