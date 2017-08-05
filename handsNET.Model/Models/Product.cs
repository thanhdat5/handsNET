using handsNET.Model.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace handsNET.Model.Models
{
    [Table("Product")]
    public class Product : IAuditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [MaxLength(256)]
        public string Name { get; set; }

        [Required]
        [MaxLength(256)]
        public string Alias { get; set; }

        public int? CategoryID { get; set; }

        [MaxLength(500)]
        public string Image { get; set; }

        public XElement MoreImage { get; set; }
        public decimal Price { get; set; }
        public decimal? PricePromotion { get; set; }
        public int? Warranty { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }

        public string Detail { get; set; }
        public string MetaKeyword { get; set; }
        public string MetaDescription { get; set; }
        public bool Status { get; set; }
        public bool? ShowOnHome { get; set; }
        public bool? IsHot { get; set; }
        public int? ViewCount { get; set; }
        public DateTime? Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? Modified { get; set; }
        public string ModifiedBy { get; set; }

        [ForeignKey("CategoryID")]
        public virtual ProductCategory ProductCategory { get; set; }

        public virtual IEnumerable<ProductTag> ProductTags { set; get; }
        public virtual IEnumerable<OrderDetail> OrderDetails { set; get; }
    }
}