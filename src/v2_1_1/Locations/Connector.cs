using System;
using System.ComponentModel.DataAnnotations;

namespace OCPI.DTO.v2_1_1.Locations
{
    /// <summary>
    /// A connector is the socket or cable available for the EV to use. 
    /// A single EVSE may provide multiple connectors but only one of them can be in use at the same time.
    /// A connector always belongs to an EVSE object.
    /// </summary>
    public class Connector
    {
        /// <summary>
        /// Identifier of the connector within the EVSE. 
        /// Two connectors may have the same id as long as they do not belong to the same EVSE object.
        /// </summary>
        [Required]
        [MaxLength(36)]
        public string id { get; set; }

        /// <summary>
        /// The standard of the installed connector.
        /// </summary>
        [Required]
        public ConnectorType standard { get; set; }

        /// <summary>
        /// The format (socket/cable) of the installed connector.
        /// </summary>
        [Required]
        public ConnectorFormat format { get; set; }

        [Required]
        public PowerType power_type { get; set; }

        /// <summary>
        /// Voltage of the connector (line to neutral for AC_3_PHASE), in volt[V]. 
        /// </summary>
        [Required]
        public int voltage { get; set; }

        /// <summary>
        /// maximum amperage of the connector, in ampere[A].
        /// </summary>
        [Required]
        public int amperage { get; set; }

        /// <summary>
        /// Identifier of the current charging tariff structure.
        /// For a “Free of Charge” tariff this field should be set, 
        /// and point to a defined “Free of Charge” tariff.
        /// </summary>
        [MaxLength(36)]
        public string tariff_id { get; set; }

        /// <summary>
        /// URL to the operator’s terms and conditions.
        /// </summary>
        [MaxLength(255)]
        public string terms_and_conditions { get; set; }

        /// <summary>
        /// Timestamp when this Connectors was last updated(or created). 
        /// </summary>
        [Required]
        public DateTime last_updated { get; set; }
    }
}
