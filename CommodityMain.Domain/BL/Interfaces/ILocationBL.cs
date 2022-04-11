using CommodityMain.DataAccess.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommodityMain.Domain.BL.Interfaces
{
    public interface ILocationBL
    {
        Task<int> AddLocation(location entity);
        Task<location> UpdateLocation(location entity);
        bool DeleteLocation(int id);
        Task<location> GetLocationById(int id);
        Task<IEnumerable<location>> GetLocations();
    }
}
