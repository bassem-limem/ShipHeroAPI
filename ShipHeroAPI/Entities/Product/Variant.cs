using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipHeroAPI.Entities.Product
{
    public class Variant
    {

        [JsonProperty("sku")]
        public string SKU
        {
            get;
            set;
        }

        [JsonProperty("parent_sku")]
        public string ProductSKU
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

        [JsonProperty("available_inventory")]
        public int AvailableInventory
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

        [JsonProperty("barcode")]
        public int Barecode
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

        [JsonProperty("value")]
        public double Value
        {
            get;
            set;
        }

        [JsonProperty("customs_value")]
        public string CustomValue
        {
            get;
            set;
        }

        [JsonProperty("customs_description")]
        public string CustomDescription
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

        [JsonProperty("images")]
        public ICollection<Image> Images
        {
            get;
            set;
        }

        [JsonProperty("vendors")]
        public string Vendors
        {
            get;
            set;
        }
    }
}
