using System.Threading.Tasks;
using OCPI.DTO.v2_1_1.Shared;

namespace OCPI.DTO.v2_1_1.CDRs
{
    public interface ICdrEmspEndpoint
    {
        /// <summary>
        /// Fetch CDRs from the eMSP system.
        /// </summary>
        /// <param name="id">Uniquely identifies the CDR within the CPOs platform (and suboperator platforms).</param>
        /// <returns>The endpoint returns the requested CDR, if it exists</returns>
        Task<OcpiResponse<CDR>> Get(string id);

        /// <summary>
        /// Creates a new CDR.
        /// The post method should contain the full, final CDR object.
        /// </summary>
        /// <param name="cdr">New CDR object.</param>
        /// <returns>The response should contain the URL to the just created CDR object in the eMSP system.</returns>
        Task<OcpiResponse> Post(CDR cdr);
    }
}