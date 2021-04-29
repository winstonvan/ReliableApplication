using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reliable
{
    public class InventoryCountTable
    {
        [Newtonsoft.Json.JsonProperty("Id")]
        public string Id { get; set; }

        public string ItemCode { get; set; }
        public string ItemDescription { get; set; }
        public string LocationCounted { get; set; }
        public string Comments2 { get; set; }
        public string QuantityCounted { get; set; }
        public string PrimaryUnit { get; set; }
        public string AdditionalNotes { get; set; }
    }
}
