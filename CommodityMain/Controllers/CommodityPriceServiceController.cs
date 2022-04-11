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
    public class CommodityPriceServiceController : ControllerBase
    {
        private readonly ICommodityPriceBL _commodityprice;
        public CommodityPriceServiceController(ICommodityPriceBL commoditypriceBL)
        {
            _commodityprice = commoditypriceBL;
        }
        // GET: api/<CommodityTypeServiceController>
        [HttpGet]
        public async Task<IEnumerable<commodityprice>> GetAllPrices()
        {
            var results = await _commodityprice.GetCommodityPrices();
            return results;
        }
       

        // GET api/<CommodityTypeServiceController>/5
        [HttpGet, Route("GetCommodityPrice/{e}")]
        public Task<commodityprice> GetCommodityPrice(int e)
        {
            var results = _commodityprice.GetCommodityPriceById(e);
            return results;
        }

        // POST api/<CommodityTypeServiceController>
        [HttpPost, Route("AddCommodityPrice")]
        public Task<int> AddCommodityPrice([FromBody] commodityprice e)
        {
            var result = _commodityprice.AddCommodityPrice(e);
            return result;
        }

        // PUT api/<CommodityTypeServiceController>/5
        [HttpPost, Route("UpdateCommodityPrice")]
        public Task<commodityprice> UpdateCommodityPrice([FromBody] commodityprice e)
        {
            var result = _commodityprice.UpdateCommodityPrice(e);
            return result;
        }

        // DELETE api/<CommodityPriceserviceController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
