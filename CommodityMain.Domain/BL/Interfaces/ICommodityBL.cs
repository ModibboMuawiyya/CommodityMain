using CommodityMain.DataAccess.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommodityMain.Domain.BL.Interfaces
{
    public interface ICommodityBL
    {
        Task<int> AddCommodity(commodity entity);
        Task<commodity> UpdateCommodity(commodity entity);
        bool DeleteCommodity(int id);
        Task<commodity> GetCommodityById(int id);
        Task<IEnumerable<commodity>> GetCommodities();
    }
}
