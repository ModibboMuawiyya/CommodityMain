using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CommodityMain.DataAccess.EF
{
    [Table("ratetype")]
    public partial class ratetype
    {
        public ratetype()
        {
            //rates = new HashSet<rate>();
        }

        [Key]
        [Column(TypeName = "int(11)")]
        public int rateTypeID { get; set; }
        [Required]
        [Column(TypeName = "text")]
        public string name { get; set; }
        public bool is_active { get; set; }
        [Column(TypeName = "timestamp")]
        public DateTime date_modified { get; set; }
        [Column(TypeName = "timestamp")]
        public DateTime date_created { get; set; }

        //[InverseProperty(nameof(rate.rateType))]
        //public virtual ICollection<rate> rates { get; set; }
    }
}
