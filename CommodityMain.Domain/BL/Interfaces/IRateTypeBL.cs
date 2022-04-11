using CommodityMain.DataAccess.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommodityMain.Domain.BL.Interfaces
{
    public interface IRateTypeBL
    {
        Task<int> AddRateType(ratetype entity);
        Task<ratetype> UpdateRateType(ratetype entity);
        bool DeleteRateType(int id);
        Task<ratetype> GetRateTypeById(int id);
        Task<IEnumerable<ratetype>> GetRateTypes();
    }
}
