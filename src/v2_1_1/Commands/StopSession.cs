using System.ComponentModel.DataAnnotations;

namespace OCPI.DTO.v2_1_1.Commands
{
    public class StopSession
    {
        /// <summary>
        ///	URL that the CommandResponse POST should be sent to.
        ///	This URL might contain an unique ID to be able to distinguish between StopSession requests.
        /// </summary>
        [Required]
        [MaxLength(255)]
        public string response_url { get; set; }

        /// <summary>
        /// Session.id of the Session that is requested to be stopped.
        /// </summary>
        [Required]
        [MaxLength(36)]
        public string session_id { get; set; }
    }
}
