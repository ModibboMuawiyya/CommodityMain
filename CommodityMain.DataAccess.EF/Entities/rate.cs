using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CommodityMain.DataAccess.EF
{
    [Table("rate")]
    [Index(nameof(rateTypeID), Name = "rate Type")]
    public partial class rate
    {
        [Key]
        [Column(TypeName = "int(11)")]
        public int rateID { get; set; }
        [Column("rate")]
        public decimal Rate { get; set; }
        [Column(TypeName = "int(11)")]
        public int rateTypeID { get; set; }
        public bool is_active { get; set; }
        [Column(TypeName = "timestamp")]
        public DateTime date_created { get; set; }
        [Column(TypeName = "timestamp")]
        public DateTime date_modified { get; set; }

        [ForeignKey(nameof(rateTypeID))]
        //[InverseProperty(nameof(ratetype.rates))]
        public virtual ratetype rateType { get; set; }
    }
}
