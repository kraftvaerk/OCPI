using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OCPI.DTO.v2_1_1.CDRs
{
    public class ChargingPeriod
    {
        /// <summary>
        /// Start timestamp of the charging period. 
        /// This period ends when a next period starts, the last period ends when the session ends.
        /// </summary>
        [Required]
        public DateTime start_date_time { get; set; }

        /// <summary>
        /// List of relevant values for this charging period.
        /// </summary>
        [Required]
        public IList<CdrDimension> dimensions { get; set; }
    }
}
