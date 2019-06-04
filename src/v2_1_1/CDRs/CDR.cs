using OCPI.DTO.v2_1_1.Locations;
using OCPI.DTO.v2_1_1.Shared;
using OCPI.DTO.v2_1_1.Tariffs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OCPI.DTO.v2_1_1.CDRs
{
    public class CDR
    {
        /// <summary>
        /// Uniquely identifies the CDR within the CPOs platform (and suboperator platforms).
        /// </summary>
        [Required]
        [MaxLength(36)]
        public string id { get; set; }

        /// <summary>
        /// Start timestamp of the charging session.
        /// </summary>
        [Required]
        public DateTime start_date_time { get; set; }

        /// <summary>
        /// Stop timestamp of the charging session.
        /// </summary>
        [Required]
        public DateTime stop_date_time { get; set; }

        /// <summary>
        /// Reference to a token, identified by the auth_id field of the Token.
        /// </summary>
        [Required]
        [MaxLength(36)]
        public string auth_id { get; set; }

        /// <summary>
        /// Method used for authentication.
        /// </summary>
        [Required]
        public AuthMethod auth_method { get; set; }

        /// <summary>
        /// Location where the charging session took place, including only the relevant EVSE and Connector.
        /// </summary>
        [Required]
        public Location location { get; set; }

        /// <summary>
        /// Identification of the Meter inside the Charge Point.
        /// </summary>
        [MaxLength(255)]
        public string meter_id { get; set; }

        /// <summary>
        /// Currency of the CDR in ISO 4217 Code.
        /// </summary>
        [Required]
        [MaxLength(3)]
        public string currency { get; set; }

        /// <summary>
        /// List of relevant tariff elements, see: Tariffs. 
        /// When relevant, a “Free of Charge” tariff should also be in this list, and point to a defined “Free of Charge” tariff.
        /// </summary>
        public IList<Tariff> tariffs { get; set; }

        /// <summary>
        /// List of charging periods that make up this charging session.
        /// A session consists of 1 or more periods, where each period has a different relevant Tariff
        /// </summary>
        public IList<ChargingPeriod> charging_periods { get; set; }

        /// <summary>
        /// Total cost (excluding VAT) of this transaction.
        /// </summary>
        [Required]
        public decimal total_cost { get; set; }

        /// <summary>
        /// Total energy charged, in kWh.
        /// </summary>
        [Required]
        public decimal total_energy { get; set; }

        /// <summary>
        /// Total duration of this session (including the duration of charging and not charging), in hours.
        /// </summary>
        [Required]
        public decimal total_time { get; set; }

        /// <summary>
        /// Total duration during this session that the EV is not being charged (no energy being transfered between EVSE and EV), in hours.
        /// </summary>
        public decimal? total_parking_time { get; set; }

        /// <summary>
        /// Optional remark, can be used to provide addition human readable information to the CDR, for example: reason why a transaction was stopped.
        /// </summary>
        [MaxLength(255)]
        public string remark { get; set; }

        /// <summary>
        /// Timestamp when this CDR was last updated (or created).
        /// </summary>
        [Required]
        public DateTime last_updated { get; set; }
    }
}
