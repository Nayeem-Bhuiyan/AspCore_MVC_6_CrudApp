using MySoft.Entity.EmployeeEntity;

namespace MySoft.Areas.HRM.Models
{
    public class VmEmployee
    {
        //primary Property
        public int EmployeeId { get; set; }


        #region CopyFromEntityModel
        public string name { get; set; }
        public string employeeCode { get; set; }
        public string address { get; set; }
        public string contactNumber { get; set; }
        #endregion

        //Object and list property of EntityModel
        public Employee Employee { get; set; }
        public List<Employee> Employees { get; set; }
    }
}
