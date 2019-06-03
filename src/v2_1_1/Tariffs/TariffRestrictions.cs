using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OCPI.DTO.v2_1_1.Tariffs
{
    public class TariffRestrictions
    {
        /// <summary>
        /// Start time of day, for example 13:30, valid from this time of the day. Must be in 24h format with leading zeros. 
        /// Hour/Minute separator: ":" Regex: [0-2][0-9]:[0-5][0-9]
        /// </summary>
        [MaxLength(5)]
        public string start_time { get; set; }
        /// <summary>
        /// End time of day, for example 19:45, valid until this time of the day. Same syntax as start_time.
        /// </summary>
        [MaxLength(5)]
        public string end_time { get; set; }

        /// <summary>
        /// Start date, for example: 2015-12-24, valid from this day
        /// </summary>
        [MaxLength(10)]
        public string start_date { get; set; }

        /// <summary>
        /// End date, for example: 2015-12-27, valid until this day (excluding this day)
        /// </summary>
        [MaxLength(10)]
        public string end_date { get; set; }

        /// <summary>
        /// Minimum used energy in kWh, for example 20, valid from this amount of energy is used
        /// </summary>
        public decimal min_kwh { get; set; }

        /// <summary>
        /// Maximum used energy in kWh, for example 50, valid until this amount of energy is used
        /// </summary>
        public decimal max_kwh { get; set; }

        /// <summary>
        /// Minimum power in kW, for example 0, valid from this charging speed
        /// </summary>
        public decimal min_power { get; set; }

        /// <summary>
        /// Maximum power in kW, for example 20, valid up to this charging speed
        /// </summary>
        public decimal max_power { get; set; }

        /// <summary>
        /// Minimum duration in seconds, valid for a duration from x seconds
        /// </summary>
        public int min_duration { get; set; }

        /// <summary>
        /// Maximum duration in seconds, valid for a duration up to x seconds
        /// </summary>
        public int max_duration { get; set; }

        /// <summary>
        /// Which day(s) of the week this tariff is valid
        /// </summary>
        public IList<DayOfWeek> day_of_week { get; set; }
    }
}