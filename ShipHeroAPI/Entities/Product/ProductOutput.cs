using Newtonsoft.Json;
using ShipHeroAPI.Entities.Kits;
using ShipHeroAPI.Entities.Warehouse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipHeroAPI.Entities.Product
{
    public class ProductOutput
    {
        [JsonProperty("Message")]
        public string Message
        {
            get;
            set;
        }

        [JsonProperty("code")]
        public string Code
        {
            get;
            set;
        }

        [JsonProperty("products")]
        public ProductOutputProprieties Products
        {
            get;
            set;
        }

    }

    public class ProductOutputProprieties
    {
        [JsonProperty("results")]
        public ICollection<Results> Results
        {
            get;
            set;
        }
    }

    public class Results
    {
        [JsonProperty("sku")]
        public string SKU
        {
            get;
            set;
        }

        [JsonProperty("kit_components")]
        public ICollection<Components> KitComponents
        {
            get;
            set;
        }
         
        [JsonProperty("warehouses")]
        public ICollection<ShipHeroAPI.Entities.Warehouse.Warehouse> Warehouses
        {
            get;
            set;
        }

        [JsonProperty("build_kit")]
        public int BuildKit
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

        [JsonProperty("kit")]
        public int Kit
        {
            get;
            set;
        }
    }
}
