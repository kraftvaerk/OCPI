namespace OCPI.DTO.v2_1_1.Shared
{
    public enum StatusCodes : int
    {
        /// <summary>
        /// Success
        /// </summary>
        SUCCESS = 1000,

        /// <summary>
        /// Generic client error
        /// </summary>
        GENERIC_CLIENT_ERROR = 2000,
        /// <summary>
        /// Invalid or missing parameters
        /// </summary>
        INVALID_PARAMETERS = 2001,
        /// <summary>
        /// Not enough information, for example: Authorization request with too little information.
        /// </summary>
        NOT_ENOUGH_INFORMATION = 2002,
        /// <summary>
        /// Unknown Location, for example: Command: START_SESSION with unknown location.
        /// </summary>
        UNKNOWN_LOCATION = 2003,

        /// <summary>
        /// Generic server error
        /// </summary>
        GENERIC_SERVER_ERROR = 3000,
        /// <summary>
        /// Unable to use the client's API.
        /// For example during the credentials registration: When the initializing party requests
        /// data from the other party during the open POST call to its credentials endpoint.
        /// If one of the GETs can not be processed, the party should return this error in the POST response.
        /// </summary>
        UNABLE_TO_USE_API = 3001,
        /// <summary>
        /// Unsupported version.
        /// </summary>
        UNSUPPORTED_VERSION = 3002,
        /// <summary>
        /// No matching endpoints or expected endpoints missing between parties.
        /// Used during the registration process if the two parties do not have any mutual modules or endpoints available,
        /// or the minimum expected by the other party implementation.
        /// </summary>
        NO_MATCHING_ENDPOINTS = 3003
    }
}