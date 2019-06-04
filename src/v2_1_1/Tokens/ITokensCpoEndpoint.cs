using OCPI.DTO.v2_1_1.Shared;
using System.Threading.Tasks;

namespace OCPI.DTO.v2_1_1.Tokens
{
    public interface ITokensCpoEndpoint
    {
        /// <summary>
        /// If the eMSP wants to check the status of a Token in the CPO system it might GET the object from the CPO system for validation purposes. 
        /// The eMSP is the owner of the objects, so it would be illogical if the CPO system had a different status or was missing an object.
        /// </summary>
        /// <param name="country_code">Country code of the eMSP requesting this GET from the CPO system.</param>
        /// <param name="party_id">Party ID (Provider ID) of the eMSP requesting this GET from the CPO system.</param>
        /// <param name="token_uid">Token.uid of the Token object to retrieve.</param>
        /// <returns>The requested Token object.</returns>
        Task<OcpiResponse<Token>> Get(string country_code, string party_id, string token_uid);

        /// <summary>
        /// New or updated Token objects are pushed from the eMSP to the CPO.
        /// </summary>
        /// <param name="token">In the put request a new or updated Token object is sent.</param>
        /// <param name="country_code">Country code of the eMSP sending this PUT request to the CPO system.</param>
        /// <param name="party_id">Party ID (Provider ID) of the eMSP sending this PUT request to the CPO system.</param>
        /// <param name="token_uid">Token.uid of the (new) Token object (to replace).</param>
        /// <returns></returns>
        Task<OcpiResponse> Put(Token token, string country_code, string party_id, string token_uid);

        /// <summary>
        /// Same as the PUT method, but only the fields/objects that have to be updated have to be present, other fields/objects that are not specified are considered unchanged.
        /// </summary>
        /// <param name="token">In the put request a new or updated Token object is sent.</param>
        /// <param name="country_code">Country code of the eMSP sending this PUT request to the CPO system.</param>
        /// <param name="party_id">Party ID (Provider ID) of the eMSP sending this PUT request to the CPO system.</param>
        /// <param name="token_uid">Token.uid of the (new) Token object (to replace).</param>
        /// <returns></returns>
        Task<OcpiResponse> Patch(Token token, string country_code, string party_id, string token_uid);
    }
}
