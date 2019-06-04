using System.Threading.Tasks;
using OCPI.DTO.v2_1_1.Shared;

namespace OCPI.DTO.v2_1_1.Locations
{
    public interface ILocationsEmspEndpoint
    {
        /// <summary>
        /// If the CPO wants to check the status of a Location, EVSE or Connector object in the eMSP system,
        /// it might GET the object from the eMSP system for validation purposes.
        /// The CPO is the owner of the objects, so it would be illogical if the eMSP system had a different status or was missing an object.
        /// If a discrepancy is found, the CPO might push an update to the eMSP via a PUT or PATCH call.
        /// </summary>
        /// <param name="country_code">Country code of the CPO requesting this PUT to the eMSP system.</param>
        /// <param name="party_id">Party ID (Provider ID) of the CPO requesting this PUT to the eMSP system.</param>
        /// <param name="location_id">Location.id of the Location object to retrieve.</param>
        /// <returns>If a Location object was requested: the Location object.</returns>
        Task<OcpiResponse<Location>> GetLocation(string country_code, string party_id, string location_id);

        /// <summary>
        /// If the CPO wants to check the status of a Location, EVSE or Connector object in the eMSP system,
        /// it might GET the object from the eMSP system for validation purposes.
        /// The CPO is the owner of the objects, so it would be illogical if the eMSP system had a different status or was missing an object.
        /// If a discrepancy is found, the CPO might push an update to the eMSP via a PUT or PATCH call.
        /// </summary>
        /// <param name="country_code">Country code of the CPO requesting this PUT to the eMSP system.</param>
        /// <param name="party_id">Party ID (Provider ID) of the CPO requesting this PUT to the eMSP system.</param>
        /// <param name="location_id">Location.id of the Location object to retrieve.</param>
        /// <param name="evse_uid">Evse.uid, required when requesting an EVSE or Connector object.</param>
        /// <returns>If an EVSE object was requested: the EVSE object.</returns>
        Task<OcpiResponse<EVSE>> GetEVSE(string country_code, string party_id, string location_id, string evse_uid);

        /// <summary>
        /// If the CPO wants to check the status of a Location, EVSE or Connector object in the eMSP system,
        /// it might GET the object from the eMSP system for validation purposes.
        /// The CPO is the owner of the objects, so it would be illogical if the eMSP system had a different status or was missing an object.
        /// If a discrepancy is found, the CPO might push an update to the eMSP via a PUT or PATCH call.
        /// </summary>
        /// <param name="country_code">Country code of the CPO requesting this PUT to the eMSP system.</param>
        /// <param name="party_id">Party ID (Provider ID) of the CPO requesting this PUT to the eMSP system.</param>
        /// <param name="location_id">Location.id of the Location object to retrieve.</param>
        /// <param name="evse_uid">Evse.uid, required when requesting an EVSE or Connector object.</param>
        /// <param name="connector_id">Connector.id, required when requesting a Connector object.</param>
        /// <returns>If a Connector object was requested: the Connector object.</returns>
        Task<OcpiResponse<Connector>> GetConnector(string country_code, string party_id, string location_id, string evse_uid, string connector_id);

        /// <summary>
        /// Push new/updated Location, EVSE and/or Connectors to the eMSP
        /// </summary>
        /// <param name="country_code">Country code of the CPO requesting this PUT to the eMSP system.</param>
        /// <param name="party_id">Party ID (Provider ID) of the CPO requesting this PUT to the eMSP system.</param>
        /// <param name="location_id">Location.id of the Location object to retrieve.</param>
        /// <param name="location">New Location object, or Location object to replace.</param>
        /// <returns>OcpiResponse object</returns>
        Task<OcpiResponse> PutLocation(string country_code, string party_id, string location_id, Location location);

        /// <summary>
        /// Push new/updated Location, EVSE and/or Connectors to the eMSP
        /// </summary>
        /// <param name="country_code">Country code of the CPO requesting this PUT to the eMSP system.</param>
        /// <param name="party_id">Party ID (Provider ID) of the CPO requesting this PUT to the eMSP system.</param>
        /// <param name="location_id">Location.id of the Location object to retrieve.</param>
        /// <param name="evse_uid">Evse.uid, required when requesting an EVSE or Connector object.</param>
        /// <param name="evse">	New EVSE object, or EVSE object to replace.</param>
        /// <returns>OcpiResponse object</returns>
        Task<OcpiResponse> PutEVSE(string country_code, string party_id, string location_id, string evse_uid, EVSE evse);

        /// <summary>
        /// Push new/updated Location, EVSE and/or Connectors to the eMSP
        /// </summary>
        /// <param name="country_code">Country code of the CPO requesting this PUT to the eMSP system.</param>
        /// <param name="party_id">Party ID (Provider ID) of the CPO requesting this PUT to the eMSP system.</param>
        /// <param name="location_id">Location.id of the Location object to retrieve.</param>
        /// <param name="evse_uid">Evse.uid, required when requesting an EVSE or Connector object.</param>
        /// <param name="connector_id">Connector.id, required when requesting a Connector object.</param>
        /// <param name="connector">New Connector object, or Connector object to replace.</param>
        /// <returns>OcpiResponse object</returns>
        Task<OcpiResponse> PutConnector(string country_code, string party_id, string location_id, string evse_uid, string connector_id, Connector connector);

        /// <summary>
        /// Patch new/updated Location, EVSE and/or Connectors to the eMSP
        /// </summary>
        /// <param name="country_code">Country code of the CPO requesting this PUT to the eMSP system.</param>
        /// <param name="party_id">Party ID (Provider ID) of the CPO requesting this PUT to the eMSP system.</param>
        /// <param name="location_id">Location.id of the Location object to retrieve.</param>
        /// <param name="location">New Location object, or Location object to replace.</param>
        /// <returns>OcpiResponse object</returns>
        Task<OcpiResponse> PatchLocation(string country_code, string party_id, string location_id, PartialLocation location);

        /// <summary>
        /// Patch new/updated Location, EVSE and/or Connectors to the eMSP
        /// </summary>
        /// <param name="country_code">Country code of the CPO requesting this PUT to the eMSP system.</param>
        /// <param name="party_id">Party ID (Provider ID) of the CPO requesting this PUT to the eMSP system.</param>
        /// <param name="location_id">Location.id of the Location object to retrieve.</param>
        /// <param name="evse_uid">Evse.uid, required when requesting an EVSE or Connector object.</param>
        /// <param name="evse">	New EVSE object, or EVSE object to replace.</param>
        /// <returns>OcpiResponse object</returns>
        Task<OcpiResponse> PatchEVSE(string country_code, string party_id, string location_id, string evse_uid, PartialEVSE evse);

        /// <summary>
        /// Patch new/updated Location, EVSE and/or Connectors to the eMSP
        /// </summary>
        /// <param name="country_code">Country code of the CPO requesting this PUT to the eMSP system.</param>
        /// <param name="party_id">Party ID (Provider ID) of the CPO requesting this PUT to the eMSP system.</param>
        /// <param name="location_id">Location.id of the Location object to retrieve.</param>
        /// <param name="evse_uid">Evse.uid, required when requesting an EVSE or Connector object.</param>
        /// <param name="connector_id">Connector.id, required when requesting a Connector object.</param>
        /// <param name="connector">New Connector object, or Connector object to replace.</param>
        /// <returns>OcpiResponse object</returns>
        Task<OcpiResponse> PatchConnector(string country_code, string party_id, string location_id, string evse_uid, string connector_id, PartialConnector connector);
    }
}