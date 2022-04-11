using CommodityMain.DataAccess.EF;
using CommodityMain.DataAccess.EF.Interfaces;
using CommodityMain.Domain.BL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommodityMain.Domain.BL
{
    public class RateBL : IRateBL
    {
        private readonly RateRepository _commodityRepository;
        private readonly CommodityContext _context;
        public RateBL(IUnitOfWork unitOfWork, CommodityContext context)
        {
            _commodityRepository = new RateRepository(unitOfWork);
            _context = context;
        }
        public async Task<int> AddRate(rate entity)
        {
            if (entity != null)
            {
                entity.is_active = true;
                await _commodityRepository.InsertAsync(entity);
            }


            return entity.rateID;
        }

        public bool DeleteRate(int id)
        {
            _commodityRepository.DeleteById(id);
            return true;

        }

        public IEnumerable<rate> GetRatesList()
        {
            var rts = _context.rates.Include(x => x.rateType).ToList().AsEnumerable();
            return rts;

            //var result = from rate in _context.rates
            //             join ratetype in _context.ratetypes on rate.rateTypeID equals ratetype.rateTypeID;
            //return result;


        }


        public async Task<rate> GetRateById(int id)
        {
            return await _commodityRepository.GetAsync(id);
        }

        public async Task<rate> UpdateRate(rate entity)
        {
            entity.date_modified = DateTime.Now;
            if (entity != null)
            {
                var d = _commodityRepository.Get(entity.rateTypeID);
                if (d != null)
                {
                    d.date_modified = entity.date_modified;
                    d.Rate = entity.Rate;
                    await _commodityRepository.UpdateAsync(d);
                }



            }
            return entity;
        }

        public Task<IEnumerable<rate>> GetRates()
        {
            throw new NotImplementedException();
        }
    }
    
}
