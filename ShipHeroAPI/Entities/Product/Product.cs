using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ShipHeroAPI.Entities.Product
{
    public class Product
    {
        [JsonProperty("token")]
        public string Token
        {
            get;
            set;
        }

        [JsonProperty("barcode")]
        public string BarCode
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

        [JsonProperty("brand")]
        public string Brand
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

        [JsonProperty("type")]
        public string Type
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

        [JsonProperty("track_inventory")]
        public bool TrackInventory
        {
            get;
            set;
        }

        [JsonProperty("warhouse")]
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

        [JsonProperty("customs_value")]
        public double CustomsValue
        {
            get;
            set;
        }

        [JsonProperty("customs_description")]
        public string CustomsDescription
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

        [JsonProperty("images")]
        public ICollection<Image> Images
        {
            get;
            set;
        }

        [JsonProperty("variants")]
        public ICollection<Variant> Variants
        {
            get;
            set;
        }
    }

}
