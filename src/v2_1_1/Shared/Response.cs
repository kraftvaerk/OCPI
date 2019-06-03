using System;
using System.ComponentModel.DataAnnotations;

namespace OCPI.DTO.v2_1_1.Shared
{
    /// <summary>
    /// When a request cannot be accepted, an HTTP error response code is expected including a JSON object that contains more details. HTTP status codes are described on w3.org.
    /// </summary>
    /// <typeparam name="T">Array or Object or String</typeparam>
    public class Response<T>
    {
        /// <summary>
        /// Contains the actual response data object or list of objects from each request, 
        /// depending on the cardinality of the response data, this is an array (card. * or +), or a single object (card. 1 or ?)
        /// </summary>
        public T data { get; set; }

        /// <summary>
        /// Response code, as listed in Status Codes, indicates how the request was handled. 
        /// To avoid confusion with HTTP codes, at least four digits are used.
        /// 1xxx -- Success
        /// 2xxx -- Client errors – The data sent by the client can not be processed by the server
        /// 3xxx -- Server errors – The server encountered an internal error
        /// </summary>
        public int status_code { get; set; }

        /// <summary>
        /// An optional status message which may help when debugging.
        /// </summary>
        public string status_message { get; set; }

        /// <summary>
        /// The time this message was generated.
        /// </summary>
        [Required]
        public DateTime timestamp { get; set; }
    }
}
