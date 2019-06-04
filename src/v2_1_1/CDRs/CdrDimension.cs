using OCPI.DTO.v2_1_1.Shared;
using System.ComponentModel.DataAnnotations;

namespace OCPI.DTO.v2_1_1.CDRs
{
    public class CdrDimension
    {
        /// <summary>
        /// Type of cdr dimension
        /// </summary>
        [Required]
        public CdrDimensionType type { get; set; }

        /// <summary>
        /// Volume of the dimension consumed, measured according to the dimension type.
        /// </summary>
        [Required]
        public decimal number { get; set; }
    }
}