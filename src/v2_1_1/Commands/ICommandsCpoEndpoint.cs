using OCPI.DTO.v2_1_1.Shared;
using System.Threading.Tasks;

namespace OCPI.DTO.v2_1_1.Commands
{
    public interface ICommandsCpoEndpoint
    {
        /// <summary>
        /// Send a command to the CPO, requesting the CPO to send the command to the Charge Point
        /// </summary>
        /// <param name="reserveNow">ReserveNow object, for the RESERVE_NOW command, with information needed to reserve a (specific) connector of a Charge Point for a given Token.</param>
        /// <returns>
        /// Result of the command request, by the CPO (not the Charge Point). 
        /// So this indicates if the CPO understood the command request and was able to send it to the Charge Point. This is not the response by the Charge Point
        /// </returns>
        Task<OcpiResponse<CommandResponse>> ReserveNow(ReserveNow reserveNow);

        /// <summary>
        /// Send a command to the CPO, requesting the CPO to send the command to the Charge Point
        /// </summary>
        /// <param name="startSession">StartSession object, for the START_SESSION command, with information needed to start a sessions.</param>
        /// <returns>
        /// Result of the command request, by the CPO (not the Charge Point). 
        /// So this indicates if the CPO understood the command request and was able to send it to the Charge Point. This is not the response by the Charge Point
        /// </returns>
        Task<OcpiResponse<CommandResponse>> StartSession(StartSession startSession);

        /// <summary>
        /// Send a command to the CPO, requesting the CPO to send the command to the Charge Point
        /// </summary>
        /// <param name="stopSession">StopSession object, for the STOP_SESSION command, with information needed to stop a sessions.</param>
        /// <returns>
        /// Result of the command request, by the CPO (not the Charge Point). 
        /// So this indicates if the CPO understood the command request and was able to send it to the Charge Point. This is not the response by the Charge Point
        /// </returns>
        Task<OcpiResponse<CommandResponse>> Stopsession(StopSession stopSession);

        /// <summary>
        /// Send a command to the CPO, requesting the CPO to send the command to the Charge Point
        /// </summary>
        /// <param name="unlockConnector">UnlockConnector object, for the UNLOCK_CONNECTOR command, with information needed to unlock a connector of a Charge Point.</param>
        /// <returns>
        /// Result of the command request, by the CPO (not the Charge Point). 
        /// So this indicates if the CPO understood the command request and was able to send it to the Charge Point. This is not the response by the Charge Point
        /// </returns>
        Task<OcpiResponse<CommandResponse>> UnlockConnector(UnlockConnector unlockConnector);
    }
}
