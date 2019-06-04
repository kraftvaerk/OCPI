using System.Threading.Tasks;
using OCPI.DTO.v2_1_1.Shared;

namespace OCPI.DTO.v2_1_1.Version
{
    public interface IVersionDetailsEndpoint
    {
        /// <summary>
        /// Fetch information about the supported endpoints for this version
        /// </summary>
        /// <returns></returns>
        Task<OcpiResponse<VersionDetailsResponse>> Get(string versionNumber);
    }
}