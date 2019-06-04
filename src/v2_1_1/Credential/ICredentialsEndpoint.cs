using System.Threading.Tasks;
using OCPI.DTO.v2_1_1.Shared;

namespace OCPI.DTO.v2_1_1.Credential
{
    public interface ICredentialsEndpoint
    {
        /// <summary>
        /// Retrieves the credentials object to access the server's platform.
        /// The request body is empty, the response contains the credentials object to access the server's platform.
        /// This credentials object also contains extra information about the server such as its business details.
        /// </summary>
        /// <returns>Retrieves the credentials object to access the server's platform</returns>
        Task<OcpiResponse<Credentials>> Get();

        /// <summary>
        /// A POST initiates the registration process for this endpoint's version.
        /// The server must also fetch the client's endpoints for this version.
        /// </summary>
        /// <param name="credentials">
        /// Provides the server with credentials to access the client's system.
        /// This credentials object also contains extra information about the client such as its business details.
        /// </param>
        /// <returns>
        /// If successful, the server must generate a new token and respond with the client's new credentials to access the server's system. The credentials object in the response also contains extra information about the server such as its business details.
        ///
        /// This must return a HTTP status code 405: method not allowed if the client was already registered.
        /// </returns>
        Task<OcpiResponse<Credentials>> Post(Credentials credentials);

        /// <summary>
        /// A PUT will switch to the version that contains this credentials endpoint if it's different from the current version.
        /// The server must fetch the client's endpoints again, even if the version has not changed.
        /// </summary>
        /// <param name="credentials">
        /// Provides the server with updated credentials to access the client's system.
        /// This credentials object also contains extra information about the client such as its business details.
        /// </param>
        /// <returns>
        /// If successful, the server must generate a new token for the client and respond with the client's updated credentials to access the server's system.
        /// The credentials object in the response also contains extra information about the server such as its business details.
        ///
        /// This must return a HTTP status code 405: method not allowed if the client was not registered yet.
        /// </returns>
        Task<OcpiResponse<Credentials>> Put(Credentials credentials);
        
        /// <summary>
        /// Informs the server that its credentials to access the client's system are now invalid and can no longer be used.
        /// Both parties must end any automated communication. This is the unregistration process.
        /// </summary>
        /// <returns>
        /// This must return a HTTP status code 405: method not allowed if the client was not registered.
        /// </returns>
        Task<OcpiResponse> Delete();
    }
}