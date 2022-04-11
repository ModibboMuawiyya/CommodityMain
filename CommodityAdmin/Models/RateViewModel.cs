using System;

namespace CommodityAdmin.Models
{
    public class RateViewModel
    {
        public int rateID { get; set; }
        public decimal Rate { get; set; }
        public int RateTypeID { get; set; }
        public string RateType { get; set; }
        public DateTime date_created { get; set; }
        public DateTime date_modified { get; set; }
        public bool is_active { get; set; }
    }
}
