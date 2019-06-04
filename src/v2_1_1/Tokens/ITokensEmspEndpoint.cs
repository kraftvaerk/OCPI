using OCPI.DTO.v2_1_1.Shared;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OCPI.DTO.v2_1_1.Tokens
{
    public interface ITokensEmspEndpoint
    {
        /// <summary>
        /// Fetch information about Tokens known in the eMSP systems.
        /// </summary>
        /// <param name="date_from">Only return Tokens that have last_updated after this Date/Time.</param>
        /// <param name="date_to">Only return Tokens that have last_updated before this Date/Time.</param>
        /// <param name="offset">The offset of the first object returned. Default is 0.</param>
        /// <param name="limit">Maximum number of objects to GET.</param>
        /// <returns></returns>
        Task<OcpiResponse<IEnumerable<Token>>> Get(DateTime? date_from, DateTime? date_to, int? offset, int? limit);

        /// <summary>
        /// Do a 'real-time' authorization request to the eMSP system, validating if a Token might be used (at the optionally given Location).
        ///Example endpoint structure: /ocpi/emsp/2.0/tokens/{token_uid}/authorize?{type=token_type} The /authorize is required for the real-time authorize request.
        ///
        /// When the eMSP receives a 'real-time' authorization request from a CPO that contains too little information(no LocationReferences provided) to determine if the Token might be used, the eMSP SHOULD respond with the OCPI status: 2002
        /// </summary>
        /// <param name="token_uid">Token.uid of the Token for which this authorization is.</param>
        /// <param name="tokenType">Token.type of the Token for which this authorization is. Default if omitted: RFID</param>
        /// <returns></returns>
        Task<OcpiResponse<AuthorizationInfo>> Post(string token_uid, TokenType? tokenType);
    }
}
