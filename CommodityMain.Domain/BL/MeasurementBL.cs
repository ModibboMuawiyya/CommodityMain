using CommodityMain.DataAccess.EF;
using CommodityMain.DataAccess.EF.Interfaces;
using CommodityMain.Domain.BL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommodityMain.Domain.BL
{
    public class MeasurementBL : IMeasurementBL
    {
        private readonly MeasurementRepository _commodityRepository;
        public MeasurementBL(IUnitOfWork unitOfWork)
        {
            _commodityRepository = new MeasurementRepository(unitOfWork);
        }
        public async Task<int> AddMeasurement(measurement entity)
        {
            if (entity != null)
            {
                entity.is_active = true;
                await _commodityRepository.InsertAsync(entity);
            }


            return entity.measure_id;
        }

        public bool DeleteMeasurement(int id)
        {
            _commodityRepository.DeleteById(id);
            return true;

        }

        public async Task<IEnumerable<measurement>> GetMeasurements()
        {

            return await _commodityRepository.GetAllAsync(e => e.is_active == true);
        }

        public async Task<measurement> GetMeasurementById(int id)
        {
            return await _commodityRepository.GetAsync(id);
        }

        public async Task<measurement> UpdateMeasurement(measurement entity)
        {
            entity.date_modified = DateTime.Now;
            if (entity != null)
            {
                var d = _commodityRepository.Get(entity.measure_id);
                if (d != null)
                {
                    d.date_modified = entity.date_modified;
                    d.name = entity.name;
                    await _commodityRepository.UpdateAsync(d);
                }



            }
            return entity;
        }
    }
}
