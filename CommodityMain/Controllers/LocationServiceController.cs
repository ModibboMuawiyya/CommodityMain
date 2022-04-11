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
    public class LocationServiceController : ControllerBase
    {
        private readonly ILocationBL _locationBL;
        public LocationServiceController(ILocationBL locationBL)
        {
            _locationBL = locationBL;
        }
        // GET: api/<LocationServiceController>
        [HttpGet]
        public async Task<IEnumerable<location>> GetAllLocaions()
        {
            var results = await _locationBL.GetLocations();
            return results;
        }

        // GET api/<LocationServiceController>/5
        [HttpGet, Route("GetLocation/{e}")]
        public Task<location> GetLocation(int e)
        {
            var results = _locationBL.GetLocationById(e);
            return results;
        }

        // POST api/<LocationServiceController>
        [HttpPost, Route("AddLocation")]
        public Task<int> AddLocation(location e)
        {
            var result = _locationBL.AddLocation(e);
            return result;
        }

        // PUT api/<LocationServiceController>/5
        [HttpPost, Route("UpdateLocation")]
        public Task<location> UpdateRate(location e)
        {
            var result = _locationBL.UpdateLocation(e);
            return result;
        }

        // DELETE api/<LocationServiceController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
