using CommodityMain.DataAccess.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommodityMain.Domain.BL.Interfaces
{
    public interface ICommodityTypeBL
    {
        Task<int> AddCommodityType(commoditytype entity);
        Task<commoditytype> UpdateCommodityType(commoditytype entity);
        bool DeleteCommodityType(int id);
        Task<commoditytype> GetCommodityTypeById(int id);
        Task<IEnumerable<commoditytype>> GetCommodityTypes();
    }
}
