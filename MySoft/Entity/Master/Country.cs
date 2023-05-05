using System.ComponentModel.DataAnnotations;

namespace MySoft.Entity.Master
{
        public class Country : CommonProperty
        {
          [StringLength(50)]
          [Required]
          public string name { get; set; }
          [StringLength(25)]
          public string countryCode { get; set; }
        }
    
}
