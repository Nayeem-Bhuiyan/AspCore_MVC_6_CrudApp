namespace MySoft.Entity.EmployeeEntity
{
    public class Employee:CommonProperty  //Inheritance=ek class er modde arek class er property mishano
    {
        #region ChangeCode
        public string name { get; set; }
        public string employeeCode { get; set; }
        public string address { get; set; }
        public string contactNumber { get; set; }
        #endregion


    }
}
