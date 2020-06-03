using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    [Table("subjects")]
    public partial class Subjects
    {
        [Key]
        [Column("code")]
        [StringLength(255)]
        public string Code { get; set; }
        [Column("description")]
        [StringLength(255)]
        public string Description { get; set; }
        [Column("notes")]
        public string Notes { get; set; }
        [Column("units")]
        [StringLength(255)]
        public string Units { get; set; }
        [Column("scale")]
        [StringLength(255)]
        public string Scale { get; set; }
    }
}
