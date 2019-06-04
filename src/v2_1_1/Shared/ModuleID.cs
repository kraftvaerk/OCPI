using System;
using System.Collections.Generic;
using System.Text;

namespace OCPI.DTO.v2_1_1.Shared
{
    public static class ModuleID
    {
        /// <summary>
        /// A Charge Detail Record is the description of a concluded charging session. The CDR is the only billing-relevant object. CDRs are sent from the CPO to the eMSP after the charging session has ended. There is no requirement to send CDRs semi-realtime, it is seen as good practice to send them as soon as possible. But if there is an agreement between parties to send them for example once a month, that is also allowed by OCPI.
        /// </summary>
        public const string CDRs = "cdrs";
        /// <summary>
        /// The Commands module enables remote commands to be sent to a Location/EVSE.
        /// </summary>
        public const string Commands = "commands";
        /// <summary>
        /// Required for all implementations
        /// </summary>
        public const string CredentialsAndRegistration = "credentials";
        /// <summary>
        /// The Location objects live in the CPO back-end system. They describe the charging locations of that operator.
        /// </summary>
        public const string Locations = "locations";
        /// <summary>
        /// The Session object describes one charging session. The Session object is owned by the CPO back-end system, and can be GET from the CPO system, or pushed by the CPO to another system.
        /// </summary>
        public const string Sessions = "sessions";
        /// <summary>
        /// The Tariffs module gives eMSPs information about the tariffs used by the CPO.
        /// </summary>
        public const string Tariffs = "tariffs";
        /// <summary>
        /// The tokens module gives CPOs knowledge of the token information of an eMSP. eMSPs can push Token information to CPOs, CPOs can build a cache of known Tokens. When a request to authorize comes from a Charge Point, the CPO can check against this cache. With this cached information they know to which eMSP they can later send a CDR.
        /// </summary>
        public const string Tokens = "tokens";

    }
}
