using CommodityMain.DataAccess.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommodityMain.Domain.BL.Interfaces
{
    public interface IRateBL
    {
        Task<int> AddRate(rate entity);
        Task<rate> UpdateRate(rate entity);
        bool DeleteRate(int id);
        Task<rate> GetRateById(int id);
        Task<IEnumerable<rate>> GetRates();
        IEnumerable<rate> GetRatesList();
    }
}
