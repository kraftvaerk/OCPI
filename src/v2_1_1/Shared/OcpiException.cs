using System;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace OCPI.DTO.v2_1_1.Shared
{
    // https://stackoverflow.com/questions/94488/what-is-the-correct-way-to-make-a-custom-net-exception-serializable
    // Not sure if still applicable to .NET Core 2+ since the question and the answer are from 2008
    [Serializable]
    public sealed class OcpiException : Exception, ISerializable
    {
        /// <summary>
        /// OCPI status code
        /// </summary>
        public int StatusCode { get; } = (int) StatusCodes.GENERIC_SERVER_ERROR;

        public OcpiException()
        {
        }

        public OcpiException(string message) : this(message, 3000)
        {
        }

        public OcpiException(string message, int statusCode) : base(message)
        {
            StatusCode = statusCode;
        }

        public OcpiException(string message, StatusCodes statusCode) : base(message)
        {
            StatusCode = (int)statusCode;
        }

        public OcpiException(string message, Exception innerException) : base(message, innerException)
        {
        }

        public OcpiException(string message, int statusCode, Exception innerException) : base(message, innerException)
        {
            StatusCode = statusCode;
        }

        public OcpiException(string message, StatusCodes statusCode, Exception innerException) : base(message, innerException)
        {
            StatusCode = (int)statusCode;
        }

        private OcpiException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
            StatusCode = info.GetInt32("StatusCode");
        }

        [SecurityPermission(SecurityAction.Demand, SerializationFormatter = true)]
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            if (info == null)
            {
                throw new ArgumentNullException("info");
            }

            info.AddValue("StatusCode", StatusCode);

            // MUST call through to the base class to let it save its own state
            base.GetObjectData(info, context);
        }

    }
}