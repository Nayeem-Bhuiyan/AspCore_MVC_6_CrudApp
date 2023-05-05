using System.ComponentModel.DataAnnotations;

namespace MySoft.Entity.HRM
{
    public class Employee : CommonProperty  //Inheritance=ek class er modde arek class er property mishano
    {
        #region ChangeCode
        [StringLength(100)]
        [Required]
        public string name { get; set; }
        [StringLength(25)]
        public string employeeCode { get; set; }
        [StringLength(250)]
        public string address { get; set; }
        [StringLength(25)]
        public string contactNumber { get; set; }
        #endregion


    }
}
