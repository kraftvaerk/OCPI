using OCPI.DTO.v2_1_1.Locations;
using System.ComponentModel.DataAnnotations;

namespace OCPI.DTO.v2_1_1.Credential
{
    public class Credentials
    {
        /// <summary>
        /// The token for the other party to authenticate in your system.
        /// </summary>
        [Required]
        [MaxLength(64)]
        public string token { get; set; }

        /// <summary>
        /// The URL to your API versions endpoint.
        /// </summary>
        [Required]
        [MaxLength(255)]
        public string url { get; set; }

        /// <summary>
        /// Details of this party.
        /// </summary>
        [Required]
        public BusinessDetails business_details { get; set; }

        /// <summary>
        /// CPO or eMSP ID of this party. (following the 15118 ISO standard).
        /// </summary>
        [Required]
        [MaxLength(3)]
        public string party_id { get; set; }

        /// <summary>
        /// Country code of the country this party is operating in.
        /// </summary>
        [Required]
        [MaxLength(2)]
        public string country_code { get; set; }
    }
}
