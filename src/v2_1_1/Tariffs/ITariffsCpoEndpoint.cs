using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using OCPI.DTO.v2_1_1.Shared;

namespace OCPI.DTO.v2_1_1.Tariffs
{
    public interface ITariffsCpoEndpoint
    {
        /// <summary>
        /// Fetch information about all Tariffs
        /// If additional parameters: {date_from} and/or {date_to} are provided,
        /// only Tariffs with (last_updated) between the given date_from and date_to will be returned.
        /// This request is paginated, it supports the pagination related URL parameters
        /// </summary>
        /// <param name="date_from">Only return Tariffs that have last_updated after this Date/Time</param>
        /// <param name="date_to">Only return Tariffs that have last_updated before this Date/Time</param>
        /// <param name="offset">The offset of the first object returned. Default is 0.</param>
        /// <param name="limit">Maximum number of objects to GET.</param>
        /// <returns></returns>
        Task<OcpiResponse<IEnumerable<Tariff>>> Get(DateTime? date_from, DateTime? date_to, int? offset, int? limit);
    }
}