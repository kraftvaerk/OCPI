using System.ComponentModel.DataAnnotations;

namespace OCPI.DTO.v2_1_1.Tariffs
{
    public class PriceComponent
    {
        /// <summary>
        /// Type of tariff dimension
        /// </summary>
        [Required]
        public TariffDimensionType type { get; set; }

        /// <summary>
        /// Price per unit (excluding VAT) for this tariff dimension
        /// </summary>
        [Required]
        public decimal price { get; set; }

        /// <summary>
        /// Minimum amount to be billed. This unit will be billed in this step_size blocks. For example: 
        ///     if type is time and step_size is 300, then time will be billed in blocks of 5 minutes, 
        ///     so if 6 minutes is used, 10 minutes (2 blocks of step_size) will be billed.
        /// </summary>
        [Required]
        public int step_size { get; set; }
    }
}