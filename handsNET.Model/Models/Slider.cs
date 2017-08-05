using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace handsNET.Model.Models
{
    [Table("Slider")]
    public class Slider
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string ID { get; set; }

        [Required]
        [MaxLength(256)]
        public string Name { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }

        [Required]
        [MaxLength(500)]
        public string Image { get; set; }

        [MaxLength(500)]
        public string URL { get; set; }

        public int? DisplayOrder { get; set; }

        [Required]
        public bool Status { get; set; }
    }
}