using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipHeroAPI.Entities.Shipment
{
    public class ShipmentOutput
    {
        [JsonProperty("Message")]
         public string Message { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("orders")]
        public OrdersOutput Orders { get; set; }

    }

    public class OrdersOutput
    {
        [JsonProperty("total")]
        public int TotalOrders { get; set; }
        
        [JsonProperty("results")]
        public ICollection<Results> Results { get; set; }
    }

    public class Results
    {
        [JsonProperty("status")]
        public string Status { get; set; }


        [JsonProperty("shipping_name")]
        public string ShippingName { get; set; }


        [JsonProperty("order_id")]
        public string OrderId { get; set; }

        [JsonProperty("shipper_id")]
        public string ShipperId { get; set; }

        [JsonProperty("date")]
        public string CreatedAt { get; set; }


        [JsonProperty("line_items")]
        public ICollection<LineItems> Products { get; set; }

        [JsonProperty("tracking")]
        public string TrackingNumber { get; set; }


        [JsonProperty("order")]
        public Order.Order Order { get; set; }

        [JsonProperty("carrier")]
        public string ShippingPlatforme { get; set; }

        [JsonProperty("shipper_email")]
        public string CustomerMail { get; set; }

        [JsonProperty("warehouse")]
        public string Warehouse { get; set; }

        [JsonProperty("order_number")]
        public string OrderNumber { get; set; }

        [JsonProperty("method")]
        public string ShippingPlatformeMethod { get; set; }
    }

    public class LineItems
    {
        [JsonProperty("sku")]
        public string SKU { get; set; }

        [JsonProperty("partner_line_item_id")]
        public string PartnerProductId { get; set; }

        [JsonProperty("quantity")]
        public int Qty { get; set; }
    }
}
