using OCPI.DTO.v2_1_1.Locations;
using OCPI.DTO.v2_1_1.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OCPI.DTO.v2_1_1.Tariffs
{
    public class Tariff
    {
        /// <summary>
        /// Uniquely identifies the tariff within the CPOs platform (and suboperator platforms).
        /// </summary>
        [Required]
        [MaxLength(36)]
        public string id { get; set; }

        /// <summary>
        /// Currency of the CDR in ISO 4217 Code.
        /// </summary>
        [Required]
        [MaxLength(3)]
        public string currency { get; set; }

        /// <summary>
        /// List of multi language alternative tariff info text.
        /// </summary>
        public IList<DisplayText> tariff_alt_text { get; set; }

        /// <summary>
        /// Alternative URL to tariff info.
        /// </summary>
        [MaxLength(255)]
        public string tariff_alt_url { get; set; }

        /// <summary>
        /// List of tariff elements
        /// </summary>
        [Required]
        public IList<TariffElement> elements { get; set; }

        /// <summary>
        /// Details on the energy supplied with this tariff.
        /// </summary>
        public EnergyMix energy_mix { get; set; }

        /// <summary>
        /// Timestamp when this CDR was last updated (or created).
        /// </summary>
        [Required]
        public DateTime last_updated { get; set; }
    }
}
