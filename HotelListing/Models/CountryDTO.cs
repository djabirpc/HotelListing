using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotelListing.Models
{
    /*
     User See Dtos
     Dto Become Object
     User ==> 
            CountryDTO =='AutoMapper'==> 
                                        Country ==> Database
     */

    public class CreateCountryDTO
    {
        [Required]
        [StringLength(maximumLength: 50, ErrorMessage = "Country Name is too long")]
        public string Name { get; set; }
        [Required]
        [StringLength(maximumLength: 3, ErrorMessage = "Short Country Name is too long")]
        public string ShortName { get; set; }
    }

    // Will have all access to attribute of CreateCountry + Id
    public class CountryDTO : CreateCountryDTO
    {
        
        public int Id { get; set; }
        public IList<HotelDTO> Hotels { get; set; }

    }
}
