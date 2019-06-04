using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using OCPI.DTO.v2_1_1.Shared;

namespace OCPI.DTO.v2_1_1.Session
{
    public interface ISessionsEmspEndpoint
    {
        /// <summary>
        /// The CPO system might request the current version of a Session object from the eMSP system for, for example validation purposes, or the CPO system might have received a error on a PATCH.
        /// </summary>
        /// <param name="country_code">Country code of the CPO requesting this GET to the eMSP system.</param>
        /// <param name="party_id">Party ID (Provider ID) of the CPO requesting this GET to the eMSP system.</param>
        /// <param name="session_id">id of the Session object to get from the eMSP system.</param>
        /// <returns></returns>
        Task<OcpiResponse<Session>> Get(string country_code, string party_id, string session_id);

        /// <summary>
        /// Inform the system about a new/updated session in the eMSP backoffice by PUTing a Session object
        /// </summary>
        /// <param name="session">new Session object.</param>
        /// <param name="country_code">Country code of the CPO requesting this PUT to the eMSP system.</param>
        /// <param name="party_id">Party ID (Provider ID) of the CPO requesting this PUT to the eMSP system.</param>
        /// <param name="session_id">id of the new or updated Session object</param>
        /// <returns></returns>
        Task<OcpiResponse> Put(Session session, string country_code, string party_id, string session_id);

        /// <summary>
        /// Same as the PUT method, but only the fields/objects that have to be updated have to be present, other fields/objects that are not specified are considered unchanged.
        /// </summary>
        /// <param name="sessionPatch"></param>
        /// <param name="country_code"></param>
        /// <param name="party_id"></param>
        /// <param name="session_id"></param>
        /// <returns></returns>
        Task<OcpiResponse> Patch(JObject sessionPatch, string country_code, string party_id, string session_id);
    }
}
