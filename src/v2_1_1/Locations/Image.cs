using OCPI.DTO.v2_1_1.Shared;
using System.ComponentModel.DataAnnotations;

namespace OCPI.DTO.v2_1_1.Locations
{
    /// <summary>
    /// This class references images related to a EVSE in terms of a file name or url. 
    /// According to the roaming connection between one EVSE Operator and one or more Navigation Service Providers the hosting or file exchange of image payload data has to be defined. 
    /// The exchange of this content data is out of scope of OCHP. However, the recommended setup is a public available web server hosted and updated by the EVSE Operator.
    /// Per charge point an unlimited number of images of each type is allowed. Recommended are at least two images where one is a network or provider logo and the second is a station photo. 
    /// If two images of the same type are defined they should be displayed additionally, not optionally.
    /// </summary>
    public class Image
    {
        /// <summary>
        /// URL from where the image data can be fetched through a web browser.
        /// </summary>
        [Required]
        [MaxLength(255)]
        public string url { get; set; }

        /// <summary>
        /// URL from where a thumbnail of the image can be fetched through a webbrowser.
        /// </summary>
        [MaxLength(255)]
        public string thumbnail { get; set; }

        /// <summary>
        /// Describes what the image is used for.
        /// </summary>
        [Required]
        public ImageCategory category { get; set; }

        /// <summary>
        /// Image type like: gif, jpeg, png, svg
        /// </summary>
        [Required]
        [MaxLength(4)]
        public string type { get; set; }

        /// <summary>
        /// Width of the full scale image
        /// </summary>
        public int width { get; set; }

        /// <summary>
        /// Height of the full scale image
        /// </summary>
        public int height { get; set; }
    }
}