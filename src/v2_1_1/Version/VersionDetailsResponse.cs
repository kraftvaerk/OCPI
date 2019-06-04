using System.Collections.Generic;

namespace OCPI.DTO.v2_1_1.Version
{
    public class VersionDetailsResponse
    {
        public string version { get; set; }
        public IEnumerable<Endpoint> endpoints { get; set; }
    }
}