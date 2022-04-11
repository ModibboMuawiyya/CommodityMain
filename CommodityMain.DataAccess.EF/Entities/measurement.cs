﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CommodityMain.DataAccess.EF
{
    [Table("measurement")]
    public partial class measurement
    {
        public measurement()
        {
            commodityprices = new HashSet<commodityprice>();
        }

        [Key]
        [Column(TypeName = "int(11)")]
        public int measure_id { get; set; }
        [Required]
        [Column(TypeName = "text")]
        public string name { get; set; }
        public bool is_active { get; set; }
        [Column(TypeName = "timestamp")]
        public DateTime date_modified { get; set; }
        [Column(TypeName = "timestamp")]
        public DateTime date_created { get; set; }

        [InverseProperty(nameof(commodityprice.measure))]
        public virtual ICollection<commodityprice> commodityprices { get; set; }
    }
}
