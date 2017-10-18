using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipHeroAPI.Entities.Vendor
{
    public class ProductInVendor
    {
        [JsonProperty("token")]
        public string Token
        {
            get;
            set;
        }

        [JsonProperty("data")]
        public ICollection<Data> Data
        {
            get;
            set;
        }

    }

    public class Data
    {
        [JsonProperty("sku")]
        public string SKU
        {
            get;
            set;
        }

        [JsonProperty("vendor_id")]
        public string VendorId
        {
            get;
            set;
        }

        [JsonProperty("price")]
        public double Price
        {
            get;
            set;
        }

        [JsonProperty("manufacturer_sku")]
        public string ManufacturerSKU
        {
            get;
            set;
        }

    }
}
