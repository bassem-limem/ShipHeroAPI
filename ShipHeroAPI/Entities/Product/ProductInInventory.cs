using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipHeroAPI.Entities.Product
{
    public class ProductInInventory
    {
        [JsonProperty("token")]
        public string Token
        {
            get;
            set;
        }


        [JsonProperty("sku")]
        public string SKU
        {
            get;
            set;
        }

        [JsonProperty("title")]
        public string Title
        {
            get;
            set;
        }

        [JsonProperty("quantity")]
        public int Quantity
        {
            get;
            set;
        }

        [JsonProperty("new_quantity")]
        public int NewQuantity
        {
            get;
            set;
        }

        [JsonProperty("warehouse")]
        public string Warehouse
        {
            get;
            set;
        }

        [JsonProperty("tariff_code")]
        public string TariffCode
        {
            get;
            set;
        }

        [JsonProperty("price")]
        public string Price
        {
            get;
            set;
        }

        [JsonProperty("value")]
        public string Value
        {
            get;
            set;
        }

        [JsonProperty("vendor_sku")]
        public string VendorSKU
        {
            get;
            set;
        }

        [JsonProperty("bin")]
        public string Bin
        {
            get;
            set;
        }

        [JsonProperty("overstock_bin")]
        public string OverStock_Bin
        {
            get;
            set;
        }

        [JsonProperty("height")]
        public string Height
        {
            get;
            set;
        }

        [JsonProperty("width")]
        public string Width
        {
            get;
            set;
        }

        [JsonProperty("length")]
        public string Length
        {
            get;
            set;
        }

        [JsonProperty("weight")]
        public string Weight
        {
            get;
            set;
        }
    }
}
