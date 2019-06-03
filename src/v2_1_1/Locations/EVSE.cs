using OCPI.DTO.v2_1_1.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OCPI.DTO.v2_1_1.Locations
{
    /// <summary>
    /// An EVSE object has a list of connectors which can not be used simultaneously: only one connector per EVSE can be used at the time.
    /// </summary>
    public class EVSE
    {
        /// <summary>
        /// Uniquely identifies the EVSE within the CPOs platform(and suboperator platforms). 
        /// For example a database unique ID or the “EVSE ID”. This field can never be changed, modified or renamed. 
        /// This is the ‘technical’ identification of the EVSE, not to be used as ‘human readable’ identification, 
        /// use the field: evse_id for that.
        /// </summary>
        [Required]
        [MaxLength(39)]
        public string uid { get; set; }

        /// <summary>
        ///  Compliant with the following specification for EVSE ID from “eMI3 standard version V1.0” 
        ///  (http://emi3group.com/documents-links/)  “Part 2: business objects.” 
        ///  Optional because: 
        ///  if an EVSE ID is to be re-used the EVSE ID can be removed from an EVSE that is removed (status: REMOVED)
        /// </summary>
        [MaxLength(48)]
        public string evse_id { get; set; }

        /// <summary>
        ///  Indicates the current status of the EVSE.
        /// </summary>
        [Required]
        public Status status { get; set; }

        /// <summary>
        ///  Indicates a planned status in the future of the EVSE.
        /// </summary>
        public IList<StatusSchedule> status_schedule { get; set; }

        /// <summary>
        ///  List of functionalities that the EVSE is capable of.
        /// </summary>
        public IList<Capability> capabilities { get; set; }

        /// <summary>
        ///  List of available connectors on the EVSE.
        /// </summary>
        [Required]
        public IList<Connector> connectors { get; set; }

        /// <summary>
        ///  Level on which the charging station is located(in garage buildings) 
        ///  in the locally displayed numbering scheme.
        /// </summary>
        [MaxLength(4)]
        public string floor_level { get; set; }

        /// <summary>
        ///  Coordinates of the EVSE
        /// </summary>
        public GeoLocation coordinates { get; set; }

        /// <summary>
        /// A number/string printed on the outside of the EVSE for visual identification.
        /// </summary>
        [MaxLength(16)]
        public string physical_reference { get; set; }

        /// <summary>
        /// Multi-language human-readable directions when more 
        /// detailed information on how to reach the EVSE from the Location is required.
        /// </summary>
        public IList<DisplayText> directions { get; set; }

        /// <summary>
        /// The restrictions that apply to the parking spot.
        /// </summary>
        public IList<ParkingRestriction> parking_restrictions { get; set; }

        /// <summary>
        /// Links to images related to the EVSE such as photos or logos.
        /// </summary>
        public IList<Image> images { get; set; }

        /// <summary>
        /// Timestamp when this EVSE or one of its Connectors was last updated(or created).
        /// </summary>
        [Required]
        public DateTime last_updated { get; set; }
    }
}
