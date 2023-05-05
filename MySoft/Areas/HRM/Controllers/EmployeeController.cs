using Microsoft.AspNetCore.Mvc;
using MySoft.Areas.HRM.Models;
using MySoft.Service.HRM;
using MySoft.Service.Master;

namespace MySoft.Areas.HRM.Controllers
{
    [Area("HRM")]
    public class EmployeeController : Controller
    {

        #region Constructor
        private readonly IEmployeeService _employeeService;
        private readonly ICountryService _countryService;
        public EmployeeController(IEmployeeService employeeService,ICountryService countryService)
        {
            this._employeeService = employeeService;
            this._countryService = countryService;
        }
        #endregion

        // GET: EmployeeController
        public async Task<ActionResult> Index()
        {
            VmEmployee objEmployee = new VmEmployee
            {
                Employees=await _employeeService.GetALLEmployeeAsync()
            };

            //VmEmployee objEmployee = new VmEmployee();
            //objEmployee.Employees=await _employeeService.GetALLEmployeeAsync();

            return View(objEmployee);
        }

        // GET: EmployeeController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            return View(await _employeeService.GetEmployeeAsync(id));
        }

        // GET: EmployeeController/Create
        public async Task<ActionResult> Create()
        {
            VmEmployee objEmployee = new VmEmployee
            {
                Countries=await _countryService.GetALLCountryAsync()
            };


            return View(objEmployee);
        }

        // POST: EmployeeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(VmEmployee frmData)
        {
            try
            {
                await _employeeService.SaveEmployeeAsync(frmData.Employee);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }


        // POST: EmployeeController/Delete/5
        [HttpGet]
        //[ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                await _employeeService.DeleteEmployeeAsync(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }




    }
}
