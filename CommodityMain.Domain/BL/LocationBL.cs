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
    public class LocationBL : ILocationBL
    {
        private readonly LocationRepository _commodityRepository;
        public LocationBL(IUnitOfWork unitOfWork)
        {
            _commodityRepository = new LocationRepository(unitOfWork);
        }
        public async Task<int> AddLocation(location entity)
        {
            if (entity != null)
            {
                entity.is_active = true;
                await _commodityRepository.InsertAsync(entity);
            }


            return entity.loc_id;
        }

        public bool DeleteLocation(int id)
        {
            _commodityRepository.DeleteById(id);
            return true;

        }

        public async Task<IEnumerable<location>> GetLocations()
        {

            return await _commodityRepository.GetAllAsync(e => e.is_active == true);

        }

        public async Task<location> GetLocationById(int id)
        {
            return await _commodityRepository.GetAsync(id);
        }

        public async Task<location> UpdateLocation(location entity)
        {
            entity.date_modified = DateTime.Now;
            if (entity != null)
            {
                var d = _commodityRepository.Get(entity.loc_id);
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
