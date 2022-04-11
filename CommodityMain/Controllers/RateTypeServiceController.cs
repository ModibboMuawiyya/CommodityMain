using CommodityMain.DataAccess.EF;
using CommodityMain.Domain.BL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CommodityMainAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RateTypeServiceController : ControllerBase
    {
        private readonly IRateTypeBL _rateTypeBL;
        public RateTypeServiceController(IRateTypeBL rateTypeBL)
        {
            _rateTypeBL = rateTypeBL;
        }

        // GET: api/<RateTypeServiceController>
        [HttpGet, Route("GetAllRateTypes")]
        public async Task<IEnumerable<ratetype>> GetAllRateTypes()
        {
            var result = await  _rateTypeBL.GetRateTypes();
            return result;
        }

        // GET api/<RateTypeServiceController>/5
        [HttpGet, Route("GetRateType/{id}")]
        public Task<ratetype> GetRateType(int id)
        {
            var result = _rateTypeBL.GetRateTypeById(id);
            return result;
        }

        // POST api/<RateTypeServiceController>
        [HttpPost, Route("AddRateType")]
        public Task<int> AddRateType([FromBody] ratetype e)
        {
            var result = _rateTypeBL.AddRateType(e);
            return result;
        }

        // PUT api/<RateTypeServiceController>/5
        [HttpPost, Route("UpdateRateType")]
        public Task<ratetype> UpdateRateType(ratetype e)
        {
            var result = _rateTypeBL.UpdateRateType(e);
            return result;
        }

        // DELETE api/<RateTypeServiceController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
