using System.Collections.Generic;
using System.Threading.Tasks;
using OCPI.DTO.v2_1_1.Shared;

namespace OCPI.DTO.v2_1_1.Version
{
    public interface IVersionInformationEndpoint
    {
        /// <summary>
        /// Fetch all supported OCPI versions of this CPO or eMSP
        /// </summary>
        /// <returns></returns>
        Task<OcpiResponse<IEnumerable<Versions>>> Get();
    }
}