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
    public class MeasurementServiceController : ControllerBase
    {
        private readonly IMeasurementBL _measure;
        public MeasurementServiceController(IMeasurementBL measurementBL)
        {
            _measure = measurementBL;
        }
        // GET: api/<MeasurementServiceController>
        [HttpGet]
        public async Task<IEnumerable<measurement>> GetAllMeasurements()
        {
            var results = await _measure.GetMeasurements();
            return results;
        }

        // GET api/<MeasurementServiceController>/5
        [HttpGet, Route("GetMeasurement/{e}")]
        public Task<measurement> GetMeasurement(int e)
        {
            var result = _measure.GetMeasurementById(e);
            return result;
        }

        // POST api/<MeasurementServiceController>
        [HttpPost, Route("AddMeasure")]
        public Task<int> AddMeasur([FromBody] measurement e)
        {
            var result = _measure.AddMeasurement(e);
            return result;
        }

        // PUT api/<MeasurementServiceController>/5
        [HttpPost, Route("UpdateMeasurement")]
        public Task<measurement> UpdateMeasurement([FromBody] measurement e)
        {
            var result = _measure.UpdateMeasurement(e);
            return result;
        }

        // DELETE api/<MeasurementServiceController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
