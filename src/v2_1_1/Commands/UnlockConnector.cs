using System.ComponentModel.DataAnnotations;

namespace OCPI.DTO.v2_1_1.Commands
{
    public class UnlockConnector
    {
        /// <summary>
        /// URL that the CommandResponse POST should be sent to.
        /// This URL might contain an unique ID to be able to distinguish between UnlockConnector requests.
        /// </summary>
        [Required]
        [MaxLength(255)]
        public string response_url { get; set; }

        /// <summary>
        /// Location.id of the Location (belonging to the CPO this request is send to) of which it is requested to unlock the connector.
        /// </summary>
        [Required]
        [MaxLength(39)]
        public string location_id { get; set; }

        /// <summary>
        /// EVSE.uid of the EVSE of this Location of which it is requested to unlock the connector.
        /// </summary>
        [MaxLength(39)]
        public string evse_uid { get; set; }

        /// <summary>
        /// Connector.id of the Connector of this Location of which it is requested to unlock.
        /// </summary>
        [MaxLength(39)]
        public string connector_id { get; set; }
    }
}
