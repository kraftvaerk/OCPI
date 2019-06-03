using System;
using System.ComponentModel.DataAnnotations;

namespace OCPI.DTO.v2_1_1.Locations
{
    public class ExceptionalPeriod
    {
        /// <summary>
        /// Begin of the exception.
        /// </summary>
        [Required]
        public DateTime period_begin { get; set; }

        /// <summary>
        /// End of the exception.
        /// </summary>
        [Required]
        public DateTime period_end { get; set; }
    }
}