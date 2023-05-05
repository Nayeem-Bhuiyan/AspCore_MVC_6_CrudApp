using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MySoft.Entity.Master;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MySoft.Entity.HRM
{
    public class Employee : CommonProperty  //Inheritance=ek class er modde arek class er property mishano
    {
        public Employee()
        {
            isActive=true;
        }

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

        [DataType(DataType.Date)]
        [Column(TypeName = "Date")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? joiningDate { get; set; }
        public bool isActive { get; set; }
        //ForeignKey
        public int CountryId { get; set; }
        public Country Country { get; set; }
        #endregion


    }
}
