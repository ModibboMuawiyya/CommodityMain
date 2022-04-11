using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CommodityMain.DataAccess.EF
{
    public partial class exceptionlog
    {
        [Key]
        [Column(TypeName = "int(11)")]
        public int pkey { get; set; }
        [Required]
        [Column(TypeName = "text")]
        public string exceptionUrl { get; set; }
        [Required]
        [Column(TypeName = "text")]
        public string exceptionMessage { get; set; }
        [Required]
        [Column(TypeName = "text")]
        public string stacktrace { get; set; }
        [Column(TypeName = "timestamp")]
        public DateTime date_created { get; set; }
    }
}
