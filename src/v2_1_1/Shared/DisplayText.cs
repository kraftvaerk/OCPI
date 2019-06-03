using System.ComponentModel.DataAnnotations;

namespace OCPI.DTO.v2_1_1.Shared
{
    public class DisplayText
    {
        /// <summary>
        ///  Language Code ISO 639-1
        /// </summary>
        [Required]
        [MaxLength(2)]
        public string language { get; set; }

        /// <summary>
        ///  Text to be displayed to a end user. No markup, html etc.allowed.
        /// </summary>
        [Required]
        [MaxLength(512)]
        public string text { get; set; }
    }
}
