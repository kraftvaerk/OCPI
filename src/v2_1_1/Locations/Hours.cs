using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OCPI.DTO.v2_1_1.Locations
{
    public class Hours
    {
        /// <summary>
        /// Regular hours, weekday based. 
        /// Should not be set for representing 24/7 as this is the most common case.
        /// </summary>
        public IList<RegularHours> regular_hours { get; set; }

        /// <summary>
        /// True to represent 24 hours a day and 7 days a week, except the given exceptions.
        /// </summary>
        [Required]
        public bool twentyfourseven { get; set; }

        /// <summary>
        /// Exceptions for specified calendar dates, time-range based.
        /// Periods the station is operating/accessible.
        /// Additional to regular hours. May overlap regular rules.
        /// </summary>
        public IList<ExceptionalPeriod> exceptional_openings { get; set; }


        /// <summary>
        /// Exceptions for specified calendar dates, time-range based.
        /// Periods the station is not operating/accessible.
        /// Overwriting regularHours and exceptionalOpenings. Should not overlap exceptionalOpenings
        /// </summary>
        public IList<ExceptionalPeriod> exceptional_closings { get; set; }
    }
}
