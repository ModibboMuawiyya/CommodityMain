using CommodityMain.DataAccess.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommodityMain.Domain.BL.Interfaces
{
    public interface ICommodityPriceBL
    {
        Task<int> AddCommodityPrice(commodityprice entity);
        Task<commodityprice> UpdateCommodityPrice(commodityprice entity);
        bool DeleteCommodityPrice(int id);
        Task<commodityprice> GetCommodityPriceById(int id);
        Task<IEnumerable<commodityprice>> GetCommodityPrices();
    }
}
