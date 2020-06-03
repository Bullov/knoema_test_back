using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    [Table("countries")]
    public partial class Countries
    {
        [Key]
        [Column("code")]
        public int Code { get; set; }
        [Required]
        [Column("iso")]
        [StringLength(50)]
        public string Iso { get; set; }
        [Required]
        [Column("country_name")]
        [StringLength(50)]
        public string CountryName { get; set; }
    }
}
