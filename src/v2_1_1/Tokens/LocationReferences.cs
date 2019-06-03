using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OCPI.DTO.v2_1_1.Tokens
{
    public class LocationReferences
    {
        /// <summary>
        /// Unique identifier for the location.
        /// </summary>
        [Required]
        [MaxLength(39)]
        public string location_id { get; set; }

        /// <summary>
        /// Unique identifier for EVSEs within the CPO's platform for the EVSE within the the given location.
        /// </summary>
        [MaxLength(39)]
        public IList<string> evse_uids { get; set; }

        /// <summary>
        /// Identifies the connectors within the given EVSEs.
        /// </summary>
        [MaxLength(36)]
        public IList<string> connector_ids { get; set; }
    }
}