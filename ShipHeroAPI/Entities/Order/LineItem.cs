using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipHeroAPI.Entities.Order
{
    public class LineItem
    {

        [JsonProperty("id")]
        public string Id
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

        [JsonProperty("name")]
        public string Name
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

        [JsonProperty("variant_title")]
        public string VariantTitle
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

        [JsonProperty("barcode")]
        public string Barecode
        {
            get;
            set;
        }

        [JsonProperty("quantity")]
        public string Quantity
        {
            get;
            set;
        }

        [JsonProperty("product_id")]
        public string ProductId
        {
            get;
            set;
        }

        //[JsonProperty("product_shots")]
        //public ICollection<ProductShot> ProductShots
        //{
        //    get;
        //    set;
        //}

        //[JsonProperty("default_warehouse")]
        //public string DefaultWarehouse
        //{
        //    get;
        //    set;
        //}

        //[JsonProperty("sell_ahead")]
        //public int AvailableQty
        //{
        //    get;
        //    set;
        //}
    }

    public class ProductShot
    {
        [JsonProperty("url")]
        public string ImageUrl
        {
            get;
            set;
        }

        [JsonProperty("sort")]
        public string ImageListing
        {
            get;
            set;
        }
    }
}
