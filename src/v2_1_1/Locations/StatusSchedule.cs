using OCPI.DTO.v2_1_1.Shared;
using System;
using System.ComponentModel.DataAnnotations;

namespace OCPI.DTO.v2_1_1.Locations
{
    public class StatusSchedule
    {
        /// <summary>
        /// Begin of the scheduled period.
        /// </summary>
        [Required]
        public DateTime period_begin { get; set; }

        /// <summary>
        /// End of the scheduled period, if known.
        /// </summary>
        public DateTime period_end { get; set; }

        /// <summary>
        /// Status value during the scheduled period.
        /// </summary>
        [Required]
        public Status status { get; set; }
    }
}
