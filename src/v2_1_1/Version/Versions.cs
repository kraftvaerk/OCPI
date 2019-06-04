using System.ComponentModel.DataAnnotations;

namespace OCPI.DTO.v2_1_1.Version
{
    public class Versions
    {
        /// <summary>
        /// The version number.
        /// </summary>
        [Required]
        public string version { get; set; }

        /// <summary>
        /// URL to the endpoint containing version specific information.
        /// </summary>
        [Required]
        [MaxLength(255)]
        public string url { get; set; }
    }
}
