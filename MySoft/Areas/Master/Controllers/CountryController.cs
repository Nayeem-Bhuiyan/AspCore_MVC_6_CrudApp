using Microsoft.AspNetCore.Mvc;
using MySoft.Service.Master;
using Microsoft.AspNetCore.Http;
using MySoft.Areas.HRM.Models;
using MySoft.Entity;
using MySoft.Areas.Master.Models;

namespace MySoft.Areas.Master.Controllers
{
    [Area("Master")]
    public class CountryController : Controller
    {


        #region Constructor
        private readonly ICountryService _countryService;
        public CountryController(ICountryService countryService)
        {
            this._countryService = countryService;
        }
        #endregion

        // GET: CountryController
        public async Task<ActionResult> Index()
        {
            VmCountry vmCountry = new VmCountry
            {
                Countries=await _countryService.GetALLCountryAsync()
            };

            return View(vmCountry);
        }

        // GET: CountryController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CountryController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CountryController/Create
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

        // GET: CountryController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CountryController/Edit/5
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



        // POST: CountryController/Delete/5
        [HttpGet]
        //[ValidateAntiForgeryToken]
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
    }
}
