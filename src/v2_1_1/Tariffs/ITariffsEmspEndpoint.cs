using System.Threading.Tasks;
using OCPI.DTO.v2_1_1.Shared;

namespace OCPI.DTO.v2_1_1.Tariffs
{
    public interface ITariffsEmspEndpoint
    {
        /// <summary>
        /// If the CPO wants to check the status of a Tariff in the eMSP system it might GET the object from the eMSP system for validation purposes.
        /// The CPO is the owner of the objects, so it would be illogical if the eMSP system had a different status or was missing an object.
        /// </summary>
        /// <param name="country_code">Country code of the CPO requesting this PUT to the eMSP system</param>
        /// <param name="party_id">Party ID (Provider ID) of the CPO requesting this PUT to the eMSP system</param>
        /// <param name="tariff_id">Tariff.id of the Tariff object to retrieve</param>
        /// <returns>The requested Tariff object</returns>
        Task<OcpiResponse<Tariff>> Get(string country_code, string party_id, string tariff_id);

        /// <summary>
        /// New or updated Tariff objects are pushed from the CPO to the eMSP
        /// </summary>
        /// <param name="country_code">Country code of the CPO requesting this PUT to the eMSP system.</param>
        /// <param name="party_id">Party ID (Provider ID) of the CPO requesting this PUT to the eMSP system</param>
        /// <param name="tariff_id">Tariff.id of the (new) Tariff object (to replace)</param>
        /// <param name="tariff">Request body</param>
        /// <returns></returns>
        Task<OcpiResponse> Put(string country_code, string party_id, string tariff_id, Tariff tariff);

        /// <summary>
        /// The PATCH method works the same as the PUT method, except that the fields/objects that have to be updated have to be present,
        /// other fields/objects that are not specified are considered unchanged.
        /// </summary>
        /// <param name="country_code">Country code of the CPO requesting this PUT to the eMSP system.</param>
        /// <param name="party_id">Party ID (Provider ID) of the CPO requesting this PUT to the eMSP system</param>
        /// <param name="tariff_id">Tariff.id of the (new) Tariff object (to replace)</param>
        /// <param name="tariff">Request body</param>
        /// <returns></returns>
        Task<OcpiResponse> Patch(string country_code, string party_id, string tariff_id, PartialTariff tariff);

        /// <summary>
        /// Delete a no longer valid Tariff object
        /// </summary>
        /// <param name="country_code">Country code of the CPO requesting this PUT to the eMSP system.</param>
        /// <param name="party_id">Party ID (Provider ID) of the CPO requesting this PUT to the eMSP system</param>
        /// <param name="tariff_id">Tariff.id of the (new) Tariff object (to replace)</param>
        /// <returns></returns>
        Task<OcpiResponse> Delete(string country_code, string party_id, string tariff_id);
    }
}