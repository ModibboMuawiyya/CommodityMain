using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CommodityMain.DataAccess.EF
{
    [Table("commodityprice")]
    [Index(nameof(com_id), Name = "Commodity")]
    [Index(nameof(loc_id), Name = "PriceLocation")]
    [Index(nameof(measure_id), Name = "PriceMeasurement")]
    public partial class commodityprice
    {
        [Key]
        [Column(TypeName = "int(11)")]
        public int priceID { get; set; }
        [Column(TypeName = "int(11)")]
        public int com_id { get; set; }
        [Column(TypeName = "int(11)")]
        public int loc_id { get; set; }
        [Column(TypeName = "int(11)")]
        public int measure_id { get; set; }
        public decimal price { get; set; }
        public decimal unit_measure { get; set; }
        [Column(TypeName = "timestamp")]
        public DateTime date_modified { get; set; }
        [Column(TypeName = "timestamp")]
        public DateTime? date_created { get; set; }

        [ForeignKey(nameof(com_id))]
        [InverseProperty(nameof(commodity.commodityprices))]
        public virtual commodity com { get; set; }
        [ForeignKey(nameof(loc_id))]
        [InverseProperty(nameof(location.commodityprices))]
        public virtual location loc { get; set; }
        [ForeignKey(nameof(measure_id))]
        [InverseProperty(nameof(measurement.commodityprices))]
        public virtual measurement measure { get; set; }
    }
}
