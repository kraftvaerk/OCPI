using OCPI.DTO.v2_1_1.Shared;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OCPI.DTO.v2_1_1.Session
{
    public interface ISessionsCpoEndpoint
    {
        /// <summary>
        /// Fetch Sessions from the CPO systems.
        /// </summary>
        /// <param name="date_from">Only return Sessions that have last_updated after this Date/Time.</param>
        /// <param name="date_to">Only return Sessions that have last_updated before this Date/Time.</param>
        /// <param name="offset">The offset of the first object returned. Default is 0.</param>
        /// <param name="limit">Maximum number of objects to GET.</param>
        /// <returns></returns>
        Task<OcpiResponse<IEnumerable<Session>>> Get(DateTime date_from, DateTime? date_to, int? offset, int? limit);
    }
}
