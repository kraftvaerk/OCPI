using OCPI.DTO.v2_1_1.Shared;
using System.ComponentModel.DataAnnotations;

namespace OCPI.DTO.v2_1_1.Tokens
{
    public class AuthorizationInfo
    {
        /// <summary>
        /// Status of the Token, and whether charging is allowed at the optionally given location.
        /// </summary>
        [Required]
        public Allowed allowed { get; set; }

        /// <summary>
        /// Optional reference to the location if it was included in the request, 
        /// and if the EV driver is allowed to charge at that location. 
        /// Only the EVSEs/Connectors the EV driver is allowed to charge at are returned.
        /// </summary>
        public LocationReferences location { get; set; }

        /// <summary>
        /// Optional display text, additional information to the EV driver
        /// </summary>
        public DisplayText  info { get; set; }
    }
}
