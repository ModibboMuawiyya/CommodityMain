using CommodityMain.DataAccess.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommodityMain.Domain.BL.Interfaces
{
    public interface IMeasurementBL
    {
        Task<int> AddMeasurement(measurement entity);
        Task<measurement> UpdateMeasurement(measurement entity);
        bool DeleteMeasurement(int id);
        Task<measurement> GetMeasurementById(int id);
        Task<IEnumerable<measurement>> GetMeasurements();
    }
}
