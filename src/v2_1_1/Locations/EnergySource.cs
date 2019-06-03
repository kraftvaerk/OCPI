using System.ComponentModel.DataAnnotations;

namespace OCPI.DTO.v2_1_1.Locations
{
    public class EnergySource
    {
        /// <summary>
        /// The type of energy source.
        /// </summary>
        [Required]
        public EnergySourceCategory source { get; set; }

        /// <summary>
        /// Percentage of this source (0-100) in the mix.
        /// </summary>
        [Required]
        public decimal percentage { get; set; }
    }
}
