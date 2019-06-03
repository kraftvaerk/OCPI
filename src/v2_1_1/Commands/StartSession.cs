using OCPI.DTO.v2_1_1.Tokens;
using System.ComponentModel.DataAnnotations;

namespace OCPI.DTO.v2_1_1.Commands
{
    public class StartSession
    {
        /// <summary>
        /// URL that the CommandResponse POST should be send to. 
        /// This URL might contain an unique ID to be able to distinguish between StartSession requests.
        /// </summary>
        [Required]
        [MaxLength(255)]
        public string response_url { get; set; }

        /// <summary>
        /// Token object the Charge Point has to use to start a new session.
        /// </summary>
        [Required]
        public Token token { get; set; }

        /// <summary>
        /// Location.id of the Location (belonging to the CPO this request is send to) on which a session is to be started.
        /// </summary>
        [Required]
        [MaxLength(39)]
        public string location_id { get; set; }

        /// <summary>
        /// Optional EVSE.uid of the EVSE of this Location on which a session is to be started.
        /// </summary>
        [MaxLength(39)]
        public string evse_uid { get; set; }
    }
}
