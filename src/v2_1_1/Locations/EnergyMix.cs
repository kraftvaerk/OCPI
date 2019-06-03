using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OCPI.DTO.v2_1_1.Locations
{
    public class EnergyMix
    {
        /// <summary>
        /// True if 100% from regenerative sources. (CO2 and nuclear waste is zero)
        /// </summary>
        [Required]
        public bool is_green_energy { get; set; }

        /// <summary>
        /// Key-value pairs (enum + percentage) of energy sources of this location’s tariff.
        /// </summary>
        public IList<EnergySource> energy_sources { get; set; }

        /// <summary>
        /// Key-value pairs (enum + percentage) of nuclear waste 
        /// and CO2 exhaust of this location’s tariff.
        /// </summary>
        public IList<EnvironmentalImpact> environ_impact { get; set; }

        /// <summary>
        /// Name of the energy supplier, delivering the energy for this location or tariff.
        /// </summary>
        [MaxLength(64)]
        public string supplier_name { get; set; }

        /// <summary>
        /// Name of the energy suppliers product/tariff plan used at this location.
        /// </summary>
        [MaxLength(64)]
        public string energy_product_name { get; set; }
    }
}
