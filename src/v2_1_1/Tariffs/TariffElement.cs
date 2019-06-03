using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OCPI.DTO.v2_1_1.Tariffs
{
    public class TariffElement
    {
        /// <summary>
        /// List of price components that make up the pricing of this tariff
        /// </summary>
        [Required]
        public IList<PriceComponent> price_components { get; set; }

        /// <summary>
        /// Tariff restrictions object.
        /// </summary>
        public TariffRestrictions restrictions { get; set; }
    }
}