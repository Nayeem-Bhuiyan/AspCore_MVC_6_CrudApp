using MySoft.Entity.HRM;
using MySoft.Entity;
using Microsoft.EntityFrameworkCore;

namespace MySoft.Service.HRM
{
    #region ChangeCode
    public interface IEmployeeService
    {
        Task<List<Employee>> GetALLEmployeeAsync();
        Task<Employee> GetEmployeeAsync(int Id);
        Task<string> SaveEmployeeAsync(Employee model);
        Task<string> DeleteEmployeeAsync(int Id);
    }
    #endregion




    public class EmployeeService : IEmployeeService
    {
        #region ChangeCode



        #region Constructor
        private readonly AppDbContext _context;
        public EmployeeService(AppDbContext context)
        {
            this._context = context;
        }
        #endregion



        public async Task<List<Employee>> GetALLEmployeeAsync()
        {
            List<Employee> lstEmployee = new List<Employee>();
            try
            {
                lstEmployee=await _context.Employee.ToListAsync();
            }
            catch (Exception)
            {
                lstEmployee=new List<Employee>();
            }

            return lstEmployee;
        }

        public async Task<Employee> GetEmployeeAsync(int Id)
        {

            Employee ObjEmployee = new Employee();
            try
            {
                //Search object in DB to delete
                ObjEmployee=await _context.Employee.FindAsync(Id); ;
            }
            catch (Exception)
            {
                ObjEmployee = new Employee();
            }

            return ObjEmployee;
        }

        public async Task<string> SaveEmployeeAsync(Employee model)
        {
            string responseMsg = string.Empty;
            try
            {
                if (model.Id>0)
                {
                    _context.Employee.Update(model);
                    await _context.SaveChangesAsync();
                }
                else
                {
                    _context.Employee.Add(model);
                    await _context.SaveChangesAsync();
                }


                responseMsg="success";
            }
            catch (Exception ex)
            {
                responseMsg=ex.Message;
            }

            return responseMsg;
        }

        public async Task<string> DeleteEmployeeAsync(int Id)
        {

            string responseMsg = string.Empty;
            try
            {
                //Search object in DB to delete
                Employee ObjEmployee = await _context.Employee.FindAsync(Id);

                if (ObjEmployee!=null)
                {
                    _context.Employee.Remove(ObjEmployee);
                    _context.SaveChanges();
                    responseMsg="success";
                }
                else
                {
                    responseMsg="error";
                }

            }
            catch (Exception ex)
            {
                responseMsg=ex.Message;
            }

            return responseMsg;
        }

        #endregion
    }
}
