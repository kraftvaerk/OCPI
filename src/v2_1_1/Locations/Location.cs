using OCPI.DTO.v2_1_1.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OCPI.DTO.v2_1_1.Locations
{
    /// <summary>
    /// The Location object describes the location and its properties where a group of EVSEs that belong together are installed.
    /// Typically the Location object is the exact location of the group of EVSEs, but it can also be the entrance of a parking garage which contains these EVSEs.
    /// The exact way to reach each EVSE can be further specified by its own properties.
    /// </summary>
    public class Location
    {
        /// <summary>
        /// Uniquely identifies the location within the CPOs platform(and suboperator platforms). 
        /// This field can never be changed, modified or renamed.
        /// </summary>
        [Required]
        [MaxLength(39)]
        public string id { get; set; }

        /// <summary>
        /// The general type of the charge point location.
        /// </summary>
        [Required]
        public LocationType type { get; set; }

        /// <summary>
        /// Display name of the location.
        /// </summary>
        [MaxLength(255)]
        public string name { get; set; }

        /// <summary>
        /// Street/block name and house number if available.
        /// </summary>
        [Required]
        [MaxLength(45)]
        public string address { get; set; }

        /// <summary>
        /// City or town.
        /// </summary>
        [Required]
        [MaxLength(45)]
        public string city { get; set; }

        /// <summary>
        /// Postal code of the location.
        /// </summary>
        [Required]
        [MaxLength(10)]
        public string postal_code { get; set; }

        /// <summary>
        /// ISO 3166-1 alpha-3 code for the country of this location.
        /// </summary>
        [Required]
        [MaxLength(3)]
        public string country { get; set; }

        /// <summary>
        /// Coordinates of the location.
        /// </summary>
        [Required]
        public GeoLocation coordinates { get; set; }

        /// <summary>
        /// Geographical location of related points relevant to the user.
        /// </summary>
        public IList<AdditionalGeoLocation> related_locations { get; set; }

        /// <summary>
        /// List of EVSEs that belong to this Location.
        /// </summary>
        public IList<EVSE> evses { get; set; }

        /// <summary>
        /// List of EVSEs that belong to this Location.
        /// </summary>
        public IList<DisplayText> directions { get; set; }

        /// <summary>
        /// Information of the operator. When not specified, the information retrieved from the api_info endpoint should be used instead.
        /// </summary>
        public BusinessDetails @operator { get; set; }

        /// <summary>
        /// Information of the suboperator if available.
        /// </summary>
        public BusinessDetails suboperator { get; set; }

        /// <summary>
        /// Information of the owner if available.
        /// </summary>
        public BusinessDetails owner { get; set; }

        /// <summary>
        /// Optional list of facilities this charge location directly belongs to.
        /// </summary>
        public IList<Facility> facilities { get; set; }

        /// <summary>
        /// One of IANA tzdata’s TZ-values representing the time zone of the location. Examples: “Europe/Oslo”, “Europe/Zurich”. (http://www.iana.org/time-zones)
        /// </summary>
        [MaxLength(255)]
        public string time_zone { get; set; }

        /// <summary>
        ///  The times when the EVSEs at the location can be accessed for charging.
        /// </summary>
        public Hours opening_times { get; set; }

        /// <summary>
        /// Indicates if the EVSEs are still charging outside the opening hours of the location.
        /// E.g.when the parking garage closes its barriers over night, is it allowed to charge till the next morning?
        /// Default: true
        /// </summary>        
        public bool charging_when_closed { get; set; }

        /// <summary>
        /// Links to images related to the location such as photos or logos.
        /// </summary>
        public IList<Image> images { get; set; }

        /// <summary>
        /// Details on the energy supplied at this location.
        /// </summary>
        public EnergyMix energy_mix { get; set; }

        /// <summary>
        /// Timestamp when this Location or one of its EVSEs or Connectors were last updated(or created).
        /// </summary>
        [Required]
        public DateTime last_updated { get; set; }
    }
}
