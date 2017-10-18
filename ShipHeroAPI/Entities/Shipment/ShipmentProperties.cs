using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipHeroAPI.Entities.Shipment
{
    public class ShipmentProperties
    {
        [JsonProperty("shipment_id")]
        public string ShipmentId
        {
            get;
            set;
        }

        [JsonProperty("order_id")]
        public string OrderId
        {
            get;
            set;
        }

        [JsonProperty("carrier")]
        public string Carrier
        {
            get;
            set;
        }

        [JsonProperty("shipping_method")]
        public string ShippingMethod
        {
            get;
            set;
        }

        [JsonProperty("tracking_number")]
        public string TruckingNumber
        {
            get;
            set;
        }
        
        [JsonProperty("cost")]
        public string Cost
        {
            get;
            set;
        }

        [JsonProperty("label")]
        public Label Label
        {
            get;
            set;
        }

        [JsonProperty("customs_info")]
        public ICollection<string> CustomsInfo
        {
            get;
            set;
        }

        [JsonProperty("dimensions")]
        public Dimensions Dimensions
        {
            get;
            set;
        }

        [JsonProperty("address")]
        public Address Address
        {
            get;
            set;
        }

    }

    public class Address
    {
        [JsonProperty("name")]
        public string Name
        {
            get;
            set;
        }

        [JsonProperty("address1")]
        public string AddressLine1
        {
            get;
            set;
        }

        [JsonProperty("address2")]
        public string AddressLine2
        {
            get;
            set;
        }

        [JsonProperty("city")]
        public string City
        {
            get;
            set;
        }

        [JsonProperty("state")]
        public string State
        {
            get;
            set;
        }

        [JsonProperty("postal_code")]
        public string PostalCode
        {
            get;
            set;
        }

        [JsonProperty("country")]
        public string Country
        {
            get;
            set;
        }
    }

    public class Dimensions
    {
        [JsonProperty("weight")]
        public string Weight
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

        [JsonProperty("width")]
        public string Width
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

    }

    public class Label
    {
        [JsonProperty("pdf")]
        public string PDF
        {
            get;
            set;
        }

        [JsonProperty("png")]
        public ICollection<string> PNG
        {
            get;
            set;
        }
    }
}
