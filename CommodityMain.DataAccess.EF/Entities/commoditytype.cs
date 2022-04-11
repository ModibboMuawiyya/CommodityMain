using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CommodityMain.DataAccess.EF
{
    [Table("commoditytype")]
    public partial class commoditytype
    {
        public commoditytype()
        {
            commodities = new HashSet<commodity>();
        }

        [Key]
        [Column(TypeName = "int(11)")]
        public int com_type_ID { get; set; }
        [Required]
        [Column(TypeName = "text")]
        public string com_type_name { get; set; }
        public bool is_active { get; set; }
        [Column(TypeName = "timestamp")]
        public DateTime date_created { get; set; }
        [Column(TypeName = "timestamp")]
        public DateTime date_modified { get; set; }

        [InverseProperty(nameof(commodity.comType))]
        public virtual ICollection<commodity> commodities { get; set; }
    }
}
