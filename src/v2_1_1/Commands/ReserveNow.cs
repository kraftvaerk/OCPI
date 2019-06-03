using OCPI.DTO.v2_1_1.Tokens;
using System;
using System.ComponentModel.DataAnnotations;

namespace OCPI.DTO.v2_1_1.Commands
{
    public class ReserveNow
    {
        /// <summary>
        /// URL that the CommandResponse POST should be send to. 
        /// This URL might contain an unique ID to be able to distinguish between ReserveNow requests.
        /// </summary>
        [Required]
        [MaxLength(255)]
        public string response_url { get; set; }

        /// <summary>
        /// Token object for how to reserve this Charge Point (and specific EVSE).
        /// </summary>
        [Required]
        public Token token { get; set; }

        /// <summary>
        /// The Date/Time when this reservation ends.
        /// </summary>
        [Required]
        public DateTime expiry_date { get; set; }

        /// <summary>
        /// Reservation id, unique for this reservation. 
        /// If the Charge Point already has a reservation that matches this reservationId the Charge Point will replace the reservation.
        /// </summary>
        [Required]
        public int reservation_id { get; set; }

        /// <summary>
        /// Location.id of the Location (belonging to the CPO this request is send to) for which to reserve an EVSE.
        /// </summary>
        [Required]
        [MaxLength(39)]
        public string location_id { get; set; }

        /// <summary>
        /// Optional EVSE.uid of the EVSE of this Location if a specific EVSE has to be reserved.
        /// </summary>
        [MaxLength(39)]
        public string evse_uid { get; set; }
    }
}
