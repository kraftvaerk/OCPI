using OCPI.DTO.v2_1_1.Shared;
using System.ComponentModel.DataAnnotations;

namespace OCPI.DTO.v2_1_1.Locations
{
    public class EnvironmentalImpact
    {
        /// <summary>
        /// The category of this value.
        /// </summary>
        [Required]
        public EnvironmentalImpactCategory source { get; set; }

        /// <summary>
        /// Amount of this portion in g/kWh.
        /// </summary>
        [Required]
        public decimal number { get; set; }
    }
}
