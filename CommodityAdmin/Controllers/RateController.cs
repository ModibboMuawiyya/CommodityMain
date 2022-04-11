using AutoMapper;
using CommodityAdmin.Models;
using CommodityMain.DataAccess.EF;
using CommodityMainAPI.Helpers;
using Flurl.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommodityAdmin.Controllers
{
    public class RateController : Controller
    {
        private readonly IMapper _mapper;
        public RateController(IMapper mapper)
        {
            _mapper = mapper;
        }
        // GET: RateController
        public ActionResult Index()
        {

            return View();
        }

        public async Task<IActionResult> retrieveAll()
        {
            await SetLookups();
            var rates = await (Helper.ServiceUrl + $"RateService/GetAllRatesLists").GetJsonAsync<IEnumerable<rate>>();
            var vm = rates.Select(m => new RateViewModel
            {
                RateType = m.rateType.name,
                Rate = m.Rate,
                is_active = m.is_active,
                rateID = m.rateID,
                RateTypeID = m.rateTypeID,
                date_created = m.date_created,
                date_modified = m.date_modified
            }).ToList();
            return View(vm);
        }

        // GET: RateController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: RateController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RateController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RateController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RateController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RateController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RateController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        private async Task SetLookups()
        {
            var lookup =  await (Helper.ServiceUrl + $"RateTypeService/GetAllRateTypes").GetJsonAsync<IEnumerable<ratetype>>();

            var lookups = lookup.Select(x => new ratetype
            {
                rateTypeID = x.rateTypeID,
                name = x.name
            }).OrderBy(x => x.name).ToList();
            ViewBag.ratetypes = lookups;
        }
    }
}
