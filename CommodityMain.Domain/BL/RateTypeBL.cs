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
    public class RateTypeBL : IRateTypeBL
    {
        private readonly RateTypeRepository _commodityRepository;
        private readonly CommodityContext _context;
        public RateTypeBL(IUnitOfWork unitOfWork)
        {
            _commodityRepository = new RateTypeRepository(unitOfWork);
        }
        public async Task<int> AddRateType(ratetype entity)
        {
            if (entity != null)
            {
                entity.is_active = true;
                await _commodityRepository.InsertAsync(entity);
            }


            return entity.rateTypeID;
        }

        public bool DeleteRateType(int id)
        {
            _commodityRepository.DeleteById(id);
            return true;

        }

        public async Task<IEnumerable<ratetype>> GetRateTypes()
        {

            return await _commodityRepository.GetAllAsync(e => e.is_active == true);

        }

        public async Task<ratetype> GetRateTypeById(int id)
        {
            return await _commodityRepository.GetAsync(id);
        }

        public async Task<ratetype> UpdateRateType(ratetype entity)
        {
            entity.date_modified = DateTime.Now;
            if (entity != null)
            {
                var d = _commodityRepository.Get(entity.rateTypeID);
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
