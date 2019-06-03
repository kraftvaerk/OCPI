using System.ComponentModel.DataAnnotations;

namespace OCPI.DTO.v2_1_1.Locations
{
    public class RegularHours
    {
        /// <summary>
        /// Number of day in the week, from Monday (1) till Sunday (7)
        /// </summary>
        [Required]
        [Range(1, 7)]
        public int weekday { get; set; }

        /// <summary>
        /// Begin of the regular period given in hours and minutes.
        /// Must be in 24h format with leading zeros.Example:
        /// “18:15”. Hour/Minute separator: “:” Regex:
        /// [0-2] [0-9]:[0-5] [0-9]
        /// </summary>
        [Required]
        [MaxLength(5)]
        public string period_begin { get; set; }

        /// <summary>
        /// End of the regular period, syntax a
        /// </summary>
        [Required]
        [MaxLength(5)]
        public string period_end { get; set; }
    }
}
