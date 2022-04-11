using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CommodityMain.DataAccess.EF
{
    [Table("commodity")]
    [Index(nameof(comTypeId), Name = "comType")]
    public partial class commodity
    {
        public commodity()
        {
            commodityprices = new HashSet<commodityprice>();
        }

        [Key]
        [Column(TypeName = "int(11)")]
        public int com_id { get; set; }
        [Required]
        [Column(TypeName = "text")]
        public string name { get; set; }
        [Column(TypeName = "int(11)")]
        public int comTypeId { get; set; }
        [Column(TypeName = "timestamp")]
        public DateTime date_created { get; set; }
        [Column(TypeName = "timestamp")]
        public DateTime date_modified { get; set; }
        public bool is_active { get; set; }

        [ForeignKey(nameof(comTypeId))]
        [InverseProperty(nameof(commoditytype.commodities))]
        public virtual commoditytype comType { get; set; }
        [InverseProperty(nameof(commodityprice.com))]
        public virtual ICollection<commodityprice> commodityprices { get; set; }
    }
}
