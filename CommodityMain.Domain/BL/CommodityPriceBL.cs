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
    public class CommodityPriceBL : ICommodityPriceBL
    {
        private readonly CommodityPriceRepository _commodityRepository;
        public CommodityPriceBL(IUnitOfWork unitOfWork)
        {
            _commodityRepository = new CommodityPriceRepository(unitOfWork);
        }
        public async Task<int> AddCommodityPrice(commodityprice entity)
        {
            if (entity != null)
            {
                await _commodityRepository.InsertAsync(entity);
            }


            return entity.com_id;
        }

        public bool DeleteCommodityPrice(int id)
        {
            _commodityRepository.DeleteById(id);
            return true;

        }

        public async Task<IEnumerable<commodityprice>> GetCommodityPrices()
        {

            return await _commodityRepository.GetAllAsync();

        }

        public async Task<commodityprice> GetCommodityPriceById(int id)
        {
            return await _commodityRepository.GetAsync(id);
        }

        public async Task<commodityprice> UpdateCommodityPrice(commodityprice entity)
        {
            entity.date_modified = DateTime.Now;
            if (entity != null)
            {
                var d = _commodityRepository.Get(entity.com_id);
                if (d != null)
                {
                    d.date_modified = entity.date_modified;
                    await _commodityRepository.UpdateAsync(d);
                }



            }
            return entity;
        }
    }
}
