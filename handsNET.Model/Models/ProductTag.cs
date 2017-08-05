﻿using handsNET.Model.Abstract;
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
    [Table("ProductTag")]
    public class ProductTag
    {
        [Key]
        public int ProductID { get; set; }
        [Key]
        [MaxLength(50)]
        public string TagID { get; set; }
        [ForeignKey("ProductID")]
        public virtual Product Product { get; set; }
        [ForeignKey("TagID")]
        public virtual Tag Tag { get; set; }
    }
}
