using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipHeroAPI.Entities.Shipment
{
    public class Shipment
    {

        [JsonProperty("token")]
        public string Token
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

        [JsonProperty("create_shipment")]
        public int CreateShipment
        {
            get;
            set;
        }

        [JsonProperty("notify_customer_via_store")]
        public int NotifyCustomer
        {
            get;
            set;
        }

        [JsonProperty("profile")]
        public string Profile
        {
            get;
            set;
        }

        

        [JsonProperty("shipment")]
        public ShipmentProperties ShipmentProperties
        {
            get;
            set;
        }

        [JsonProperty("line_items")]
        public ICollection<ShipmentLineItems> LineItems
        {
            get;
            set;
        }


    }

    public class ShipmentLineItems
    {
        [JsonProperty("id")]
        public int Id
        {
            get;
            set;
        }

        [JsonProperty("quntity")]
        public int Quntity
        {
            get;
            set;
        }
    }
}
