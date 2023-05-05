using MySoft.Entity.Master;
using System.ComponentModel.DataAnnotations;

namespace MySoft.Areas.Master.Models
{
    public class VmCountry
    {
        public int CountryId { get; set; }

        [StringLength(50)]
        [Required]
        public string name { get; set; }
        [StringLength(25)]
        public string countryCode { get; set; }


        public Country Country { get; set; }
        public List<Country> Countries { get; set; }
    }
}
