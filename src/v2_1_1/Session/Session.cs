using OCPI.DTO.v2_1_1.CDRs;
using OCPI.DTO.v2_1_1.Locations;
using OCPI.DTO.v2_1_1.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OCPI.DTO.v2_1_1.Session
{
    public class Session
    {
        /// <summary>
        /// The unique id that identifies the session in the CPO platform.
        /// </summary>
        [Required]
        [MaxLength(36)]
        public string id { get; set; }

        /// <summary>
        /// The time when the session became active.
        /// </summary>
        [Required]
        public DateTime start_datetime { get; set; }

        /// <summary>
        /// The time when the session is completed.
        /// </summary>
        public DateTime? end_datetime { get; set; }

        /// <summary>
        /// How many kWh are charged.
        /// </summary>
        [Required]
        public decimal kwh { get; set; }

        /// <summary>
        /// Reference to a token, identified by the auth_id field of the Token.
        /// </summary>
        [Required]
        public string auth_id { get; set; }

        /// <summary>
        /// Method used for authentication.
        /// </summary>
        [Required]
        public AuthMethod auth_method { get; set; }

        /// <summary>
        /// The location where this session took place, including only the relevant EVSE and connector
        /// </summary>
        [Required]
        public Location location { get; set; }

        /// <summary>
        /// Optional identification of the kWh meter.
        /// </summary>
        [MaxLength(255)]
        public string meter_id { get; set; }

        /// <summary>
        /// ISO 4217 code of the currency used for this session.
        /// </summary>
        [Required]
        [MaxLength(3)]
        public string currency { get; set; }

        /// <summary>
        /// An optional list of charging periods that can be used to calculate and verify the total cost.
        /// </summary>
        public IList<ChargingPeriod> charging_periods { get; set; }

        /// <summary>
        /// The total cost (excluding VAT) of the session in the specified currency.
        /// This is the price that the eMSP will have to pay to the CPO. 
        /// A total_cost of 0.00 means free of charge. When omitted, 
        /// no price information is given in the Session object, 
        /// this does not have to mean it is free of charge.
        /// </summary>
        public decimal? total_cost { get; set; }

        /// <summary>
        /// The status of the session.
        /// </summary>
        [Required]
        public SessionStatus status { get; set; }

        /// <summary>
        /// Timestamp when this Session was last updated (or created).
        /// </summary>
        [Required]
        public DateTime last_updated { get; set; }
    }
}
