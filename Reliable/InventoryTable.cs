using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reliable
{
    public class InventoryTable
    {
        [Newtonsoft.Json.JsonProperty("Id")]
        public string Id { get; set; }

        public string ItemCode { get; set; }
        public string ItemDescription { get; set; }
        public string ItemExtendedDescription { get; set; }
        public string Comments2 { get; set; }
        public string SupplierUPCCode { get; set; }
        public string BinNumber { get; set; }


    }
}
