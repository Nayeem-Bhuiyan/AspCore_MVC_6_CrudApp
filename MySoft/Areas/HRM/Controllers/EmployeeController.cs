using Microsoft.AspNetCore.Mvc;
using MySoft.Areas.HRM.Models;
using MySoft.Service.EmployeeService;

namespace MySoft.Areas.HRM.Controllers
{
    [Area("HRM")]
    public class EmployeeController : Controller
    {

        #region Constructor
        private readonly IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService employeeService)
        {
            this._employeeService = employeeService;
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
        public ActionResult Create()
        {
            return View();
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
        [HttpPost]
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
