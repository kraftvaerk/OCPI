using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using OCPI.DTO.v2_1_1.Shared;

namespace OCPI.DTO.v2_1_1.CDRs
{
    public interface ICdrCpoEndpoint
    {
        /// <summary>
        /// Fetch CDRs, last updated (which in the current version of OCPI can only be the creation date/time)
        /// between the {date_from} and {date_to} (paginated)
        /// </summary>
        /// <param name="date_from">Only return CDRs that have last_updated after this Date/Time.</param>
        /// <param name="date_to">Only return CDRs that have last_updated before this Date/Time.</param>
        /// <param name="offset">The offset of the first object returned. Default is 0.</param>
        /// <param name="limit">Maximum number of objects to GET.</param>
        /// <returns>The endpoint returns a list of CDRs matching the given parameters in the GET request,
        /// the header will contain the pagination related headers.</returns>
        Task<OcpiResponse<IEnumerable<CDR>>> Get(DateTime? date_from, DateTime? date_to, int? offset, int? limit);
    }
}