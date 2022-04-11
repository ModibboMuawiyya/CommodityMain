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
    public class CommodityTypeBL : ICommodityTypeBL
    {
        private readonly CommodityTypeRepository _commodityRepository;
        public CommodityTypeBL(IUnitOfWork unitOfWork)
        {
            _commodityRepository = new CommodityTypeRepository(unitOfWork);
        }
        public async Task<int> AddCommodityType(commoditytype entity)
        {
            if (entity != null)
            {
                entity.is_active = true;
                await _commodityRepository.InsertAsync(entity);
            }


            return entity.com_type_ID;
        }

        public bool DeleteCommodityType(int id)
        {
            _commodityRepository.DeleteById(id);
            return true;

        }

        public Task<IEnumerable<commoditytype>> GetCommodityTypes()
        {

            return (Task<IEnumerable<commoditytype>>)_commodityRepository.GetAll(e => e.is_active == true).AsEnumerable();

        }

        public async Task<commoditytype> GetCommodityTypeById(int id)
        {
            return await _commodityRepository.GetAsync(id);
        }

        public async Task<commoditytype> UpdateCommodityType(commoditytype entity)
        {
            entity.date_modified = DateTime.Now;
            if (entity != null)
            {
                var d = _commodityRepository.Get(entity.com_type_ID);
                if (d != null)
                {
                    d.date_modified = entity.date_modified;
                    d.com_type_name = entity.com_type_name;
                    await _commodityRepository.UpdateAsync(d);
                }



            }
            return entity;
        }
    }
}
