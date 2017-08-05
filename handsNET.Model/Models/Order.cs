using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace handsNET.Model.Models
{
    [Table("Order")]
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        [MaxLength(256)]
        public string CustomerName { get; set; }
        [Required]
        [MaxLength(256)]
        public string CustomerAddress { get; set; }
        [MaxLength(256)]
        public string CustomerEmail { get; set; }
        [Required]
        [MaxLength(50)]
        public string CustomerPhone { get; set; }
        [MaxLength(500)]
        public string CustomerMessage { get; set; }
        [MaxLength(256)]
        public string PaymentMethod { get; set; }
        [Required]
        [MaxLength(50)]
        public string PaymentStatus { get; set; }
        public bool Status { get; set; }
        public DateTime? Created { get; set; }
        [MaxLength(256)]
        public string CreatedBy { get; set; }
        public DateTime? Modified { get; set; }
        [MaxLength(256)]
        public string ModifiedBy { get; set; }

        [ForeignKey("OrderID")]
        public virtual OrderDetail OrderDetail { get; set; }
        public virtual IEnumerable<OrderDetail> OrderDetails { set; get; }
    }
}
