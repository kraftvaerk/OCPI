using System;
using System.Collections.Generic;
using System.Text;

namespace OCPI.DTO.v2_1_1.Shared
{
    public class OcpiPaginationHeaders
    {
        /// <summary>
        /// Link to the 'next' page should be provided, when this is NOT the last page.
        /// The Link should also contain any filters present in the original request. 
        /// See example below.
        /// </summary>
        /// <example>
        ///   Link: &lt;https://www.server.com/ocpi/cpo/2.0/cdrs/?offset=200&amp;limit=50&gt;; rel="next"
        /// </example>
        public string Link { get; set; }
        
        /// <summary>
        /// Total number of objects available in the server system that match the give query 
        /// (including the given query parameters for example: date_to and date_from but excluding limit and offset) 
        /// and that are available to this client. 
        /// For example: The CPO server might return less CDR objects to an eMSP then the total number of CDRs available in the CPO system.
        /// </summary>
        public string TotalCount { get; set; }

        /// <summary>
        /// Number of objects that are returned. Note that this is an upper limit, if there are not enough remaining objects to return, fewer objects than this upper limit number will be returned.
        /// </summary>
        public string Limit { get; set; }
    }
}
