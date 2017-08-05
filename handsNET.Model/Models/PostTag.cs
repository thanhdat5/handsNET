using handsNET.Model.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace handsNET.Model.Models
{
    [Table("PostTag")]
    public class PostTag
    {
        [Key]
        public int PostID { get; set; }
        [Key]
        [MaxLength(50)]
        public string TagID { get; set; }
        [ForeignKey("PostID")]
        public virtual Post Post { get; set; }
        [ForeignKey("TagID")]
        public virtual Tag Tag { get; set; }
    }
}
