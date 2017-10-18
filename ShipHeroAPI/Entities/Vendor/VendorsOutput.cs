using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipHeroAPI.Entities.Vendor
{
    public class VendorsOutput
    {
        [JsonProperty("code")]
        public string Code
        {
            get;
            set;
        }

        [JsonProperty("Message")]
        public string Message
        {
            get;
            set;
        }

        [JsonProperty("vendors")]
        public ICollection<VendorOutput> Vendors
        {
            get;
            set;
        }
    }

    public class VendorOutput
    {
        [JsonProperty("vendor_id")]
        public string Id
        {
            get;
            set;
        }


        [JsonProperty("name")]
        public string Name
        {
            get;
            set;
        }
    }
}
