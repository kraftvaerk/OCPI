using System.ComponentModel.DataAnnotations;
using OCPI.DTO.v2_1_1.Shared;

namespace OCPI.DTO.v2_1_1.Version
{
    public class Endpoint
    {
        /// <summary>
        /// Endpoint identifier.
        /// </summary>
        [Required]
        public string identifier { get; set; }

        /// <summary>
        /// URL to the endpoint.
        /// </summary>
        [Required]
        [MaxLength(255)]
        public string url { get; set; }
    }
}
