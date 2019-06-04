using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using OCPI.DTO.v2_1_1.Shared;

namespace OCPI.DTO.v2_1_1.Locations
{
    public interface ILocationsCpoEndpoint
    {
        /// <summary>
        /// Depending on the URL Segments provided, the GET request can either be used to retrieve information about a list of 
        /// available locations and EVSEs at this CPO: GET List Or it can be used to get information about a specific Location, 
        /// EVSE or Connector: GET Object
        /// </summary>
        /// <param name="date_from">Only return Locations that have last_updated after this Date/Time.</param>
        /// <param name="date_to">Only return Locations that have last_updated before this Date/Time.</param>
        /// <param name="offset">The offset of the first object returned. Default is 0.</param>
        /// <param name="limit">Maximum number of objects to GET.</param>
        /// <returns>The endpoint returns a list of Location objects The header will contain the pagination related headers.</returns>
        Task<OcpiResponse<IEnumerable<Location>>> Get(DateTime? date_from, DateTime? date_to, int? offset, int? limit);

        /// <summary>
        /// Depending on the URL Segments provided, the GET request can either be used to retrieve information about a list of 
        /// available locations and EVSEs at this CPO: GET List Or it can be used to get information about a specific Location, 
        /// EVSE or Connector: GET Object
        /// </summary>
        /// <param name="location_id">Location.id of the Location object to retrieve.</param>
        /// <returns>If a Location object was requested: the Location object.</returns>
        Task<OcpiResponse<Location>> GetLocation(string location_id);

        /// <summary>
        /// Depending on the URL Segments provided, the GET request can either be used to retrieve information about a list of 
        /// available locations and EVSEs at this CPO: GET List Or it can be used to get information about a specific Location, 
        /// EVSE or Connector: GET Object
        /// </summary>
        /// <param name="location_id">Location.id of the Location object to retrieve.</param>
        /// <param name="evse_uid">Evse.uid, required when requesting an EVSE or Connector object.</param>
        /// <returns>If an EVSE object was requested: the EVSE object.</returns>
        Task<OcpiResponse<EVSE>> GetEVSE(string location_id, string evse_uid);

        /// <summary>
        /// Depending on the URL Segments provided, the GET request can either be used to retrieve information about a list of 
        /// available locations and EVSEs at this CPO: GET List Or it can be used to get information about a specific Location, 
        /// EVSE or Connector: GET Object
        /// </summary>
        /// <param name="location_id">Location.id of the Location object to retrieve.</param>
        /// <param name="evse_uid">Evse.uid, required when requesting an EVSE or Connector object.</param>
        /// <param name="connector_id">Connector.id, required when requesting a Connector object.</param>
        /// <returns>If a Connector object was requested: the Connector object.</returns>
        Task<OcpiResponse<Connector>> GetConnector(string location_id, string evse_uid, string connector_id);
    }
}