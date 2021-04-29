using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reliable
{
    public class NewBarcodesTable
    {
        [Newtonsoft.Json.JsonProperty("Id")]
        public string Id { get; set; }

        public string ItemCode { get; set; }
        public string SupplierUPCCode { get; set; }
        public string BinNumber { get; set; }
    }
}
