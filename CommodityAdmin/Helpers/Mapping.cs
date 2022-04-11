using CommodityAdmin.Models;
using CommodityMain.DataAccess.EF;

namespace CommodityAdmin.Helpers
{
    public class Mapping : AutoMapper.Profile
    {
        public Mapping()
        {
            CreateMap<ratetype, RateViewModel>().ReverseMap();
            //CreateMap<AdmissionBillDVM, AdmissionBill>().ForAllMembers(opts => opts.Condition((src, dest, srcMember) => srcMember != null));
        }
    }
}
