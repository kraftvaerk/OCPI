using OCPI.DTO.v2_1_1.Shared;
using System;
using System.ComponentModel.DataAnnotations;

namespace OCPI.DTO.v2_1_1.Tokens
{
    public class Token
    {
        /// <summary>
        /// Identification used by CPO system to identify this token. Currently, in most cases, this is the RFID hidden ID as read by the RFID reader.
        /// </summary>
        [Required]
        [MaxLength(36)]
        public string uid { get; set; }

        /// <summary>
        /// Type of the token
        /// </summary>
        [Required]
        public TokenType type { get; set; }

        /// <summary>
        /// Uniquely identifies the EV Driver contract token within the eMSP's platform (and suboperator platforms). 
        /// Recommended to follow the specification for eMA ID from "eMI3 standard version V1.0" (http://emi3group.com/documents-links/) "Part 2: business objects."
        /// </summary>
        [Required]
        [MaxLength(64)]
        public string auth_id { get; set; }

        /// <summary>
        /// Visual readable number/identification as printed on the Token (RFID card), might be equal to the auth_id.
        /// </summary>
        [MaxLength(64)]
        public string visual_number { get; set; }

        /// <summary>
        /// Issuing company, most of the times the name of the company printed on the token (RFID card), not necessarily the eMSP.
        /// </summary>
        [Required]
        [MaxLength(64)]
        public string issuer { get; set; }

        /// <summary>
        /// Is this Token valid
        /// </summary>
        [Required]
        public bool valid { get; set; }

        /// <summary>
        /// Indicates what type of white-listing is allowed.
        /// </summary>
        [Required]
        public WhitelistType whitelist { get; set; }

        /// <summary>
        /// Language Code ISO 639-1. This optional field indicates the Token owner's preferred interface language. 
        /// If the language is not provided or not supported then the CPO is free to choose its own language.
        /// </summary>
        [MaxLength(2)]
        public string language { get; set; }

        /// <summary>
        /// Timestamp when this Token was last updated (or created).
        /// </summary>
        [Required]
        public DateTime last_updated { get; set; }
    }
}
