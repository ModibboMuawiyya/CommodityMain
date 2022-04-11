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
    public class CommodityTypeServiceController : ControllerBase
    {
        private readonly ICommodityTypeBL _commoditype;
        public CommodityTypeServiceController(ICommodityTypeBL commoditytypeBL)
        {
            _commoditype = commoditytypeBL;
        }
        // GET: api/<CommodityTypeServiceController>
        [HttpGet]
        public async Task<IEnumerable<commoditytype>> GetAllComTypes()
        {
            var results = await _commoditype.GetCommodityTypes();
            return results;
        }

        // GET api/<CommodityTypeServiceController>/5
        [HttpGet, Route("GetCommodityType/{e}")]
        public Task<commoditytype> GetCommodityType(int e)
        {
            var results = _commoditype.GetCommodityTypeById(e);
            return results;
        }

        // POST api/<CommodityTypeServiceController>
        [HttpPost, Route("AddCommodityType")]
        public Task<int> AddCommodityType([FromBody] commoditytype e)
        {
            var result = _commoditype.AddCommodityType(e);
            return result;
        }

        // PUT api/<CommodityTypeServiceController>/5
        [HttpPost, Route("UpdateCommodityType")]
        public Task<commoditytype> UpdateCommodityType(commoditytype e)
        {
            var result = _commoditype.UpdateCommodityType(e);
            return result;
        }

        // DELETE api/<CommodityTypeServiceController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
