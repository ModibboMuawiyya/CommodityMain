using CommodityMain.DataAccess.EF;
using CommodityMain.Domain.BL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CommodityMainAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RateServiceController : ControllerBase
    {
        private readonly IRateBL _rateBL;
        public RateServiceController(IRateBL rateBL)
        {
            _rateBL = rateBL;
        }
        // GET: api/<RateServiceController>
        [HttpGet]
        public async Task<IEnumerable<rate>> GetAllRates()
        {
            var results = await _rateBL.GetRates();
            return results;
        }
        
        [HttpGet, Route("GetAllRatesLists")]
        public IEnumerable<rate> GetAllRatesLists()
        {
            var results =  _rateBL.GetRatesList();
            return results;
        }

        // GET api/<RateServiceController>/5
        [HttpGet, Route("GetRate/{id}")]
        public Task<rate> GetRate(int id)
        {
            var result = _rateBL.GetRateById(id);
            return result;
        }

        // POST api/<RateServiceController>
        [HttpPost, Route("AddRate")]
        public Task<int> AddRate([FromBody] rate e)
        {
            var result = _rateBL.AddRate(e);
            return result;
        }

        // PUT api/<RateServiceController>/5
        [HttpPost, Route("UpdateRate")]
        public Task<rate> UpdateRate(rate e)
        {
            var result = _rateBL.UpdateRate(e);
            return result;
        }

        // DELETE api/<RateServiceController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
