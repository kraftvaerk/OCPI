using OCPI.DTO.v2_1_1.Shared;
using System.ComponentModel.DataAnnotations;

namespace OCPI.DTO.v2_1_1.Locations
{
    public class AdditionalGeoLocation
    {
        /// <summary>
        /// Latitude of the point in decimal degree. Example: 50.770774. 
        /// Decimal separator: “.” Regex: -?[0-9]{1,2}\.[0-9]{6}
        /// </summary>
        [Required]
        [MaxLength(10)]
        public string latitude { get; set; }

        /// <summary>
        /// Longitude of the point in decimal degree. 
        /// Example: -126.104965. Decimal separator: “.” Regex: -?[0-9]{1,3}\.[0-9]{6}
        /// </summary>
        [Required]
        [MaxLength(11)]
        public string longitude { get; set; }

        /// <summary>
        /// Name of the point in local language or as written at the location. For example the street name of a parking lot entrance or it’s number.
        /// </summary>
        public DisplayText name { get; set; }
    }
}
