using System.Threading.Tasks;
using OCPI.DTO.v2_1_1.Shared;

namespace OCPI.DTO.v2_1_1.Commands
{
    public interface ICommandsEmspEndpoint
    {
        /// <summary>
        /// Receive the asynchronous response from the Charge Point.
        /// </summary>
        /// <param name="commandResponse">Result of the command request, from the Charge Point.</param>
        /// <returns></returns>
        Task<OcpiResponse> Post(CommandResponse commandResponse);
    }
}