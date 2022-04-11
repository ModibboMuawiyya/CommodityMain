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
    public class CommodityServiceController : ControllerBase
    {
        private readonly ICommodityBL _commodity;
        public CommodityServiceController(ICommodityBL commodityBL)
        {
            _commodity = commodityBL;
        }
        // GET: api/<CommodityServiceController>
        [HttpGet]
        public async Task<IEnumerable<commodity>> GetAllCommodities()
        {
            var results = await _commodity.GetCommodities();
            return results;
        }

        // GET api/<CommodityServiceController>/5
        [HttpGet, Route("GetCommodity/{e}")]
        public Task<commodity> GetCommodity(int e)
        {
            var results = _commodity.GetCommodityById(e);
            return results;
        }

        // POST api/<CommodityServiceController>
        [HttpPost, Route("AddCommodity")]
        public Task<int> AddCommodity([FromBody]commodity e)
        {
            var result = _commodity.AddCommodity(e);
            return result;
        }

        // PUT api/<CommodityServiceController>/5
        [HttpPost, Route("UpdateCommodity")]
        public Task<commodity> UpdateCommodity([FromBody]commodity e)
        {
            var result = _commodity.UpdateCommodity(e);
            return result;
        }

        // DELETE api/<CommodityServiceController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
