using System.ComponentModel.DataAnnotations;

namespace OCPI.DTO.v2_1_1.Locations
{
    public class BusinessDetails
    {
        /// <summary>
        /// Name of the operator.
        /// </summary>
        [Required]
        [MaxLength(100)]
        public string name { get; set; }

        /// <summary>
        /// Link to the operator's website.
        /// </summary>
        [MaxLength(255)]
        public string website { get; set; }

        /// <summary>
        /// Image link to the operator's logo.
        /// </summary>
        public Image image { get; set; }
    }
}