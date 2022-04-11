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
    public class CommodityBL : ICommodityBL
    {
        private readonly CommodityRepository _commodityRepository;
        public CommodityBL(IUnitOfWork unitOfWork)
        {
            _commodityRepository = new CommodityRepository(unitOfWork);
        }
        public async Task<int> AddCommodity(commodity entity)
        {
            if (entity != null)
            {
                entity.is_active = true;
                await _commodityRepository.InsertAsync(entity);
            }
           

            return entity.com_id;
        }

        public bool DeleteCommodity(int id)
        {
            _commodityRepository.DeleteById(id);
            return true;

        }

        public  Task<IEnumerable<commodity>> GetCommodities()
        {
           
            return (Task<IEnumerable<commodity>>)_commodityRepository.GetAll(e=>e.is_active==true).AsEnumerable();
            
        }

        public async Task<commodity> GetCommodityById(int id)
        {
            return await _commodityRepository.GetAsync(id);
        }

        public async Task<commodity> UpdateCommodity(commodity entity)
        {
            entity.date_modified = DateTime.Now;
            if (entity != null)
            {
                var d = _commodityRepository.Get(entity.com_id);
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
