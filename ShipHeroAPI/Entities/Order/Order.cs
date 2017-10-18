using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipHeroAPI.Entities.Order
{
    public class Order
    {
        [JsonProperty("token")]
        public string Token
        {
            get;
            set;
        }

        [JsonProperty("email")]
        public string Email
        {
            get;
            set;
        }

        [JsonProperty("line_items")]
        public ICollection<LineItem> LineItems
        {
            get;
            set;
        }

        [JsonProperty("shipping_lines")]
        public ShippingLines ShippingLines
        {
            get;
            set;
        }

        [JsonProperty("shipping_address")]
        public ShippingAddress ShippingAddress
        {
            get;
            set;
        }

        //[JsonProperty("billing_address")]
        //public BillingAddress BillingAddress
        //{
        //    get;
        //    set;
        //}

        [JsonProperty("total_tax")]
        public string TotalTax
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

        //[JsonProperty("partner_order_id")]
        //public string PartnerOrderId
        //{
        //    get;
        //    set;
        //}

        [JsonProperty("profile")]
        public string Profile
        {
            get;
            set;
        }

        //[JsonProperty("default_warehouse")]
        //public string DefaultWarehouse
        //{
        //    get;
        //    set;
        //}

        //[JsonProperty("gift_note")]
        //public string GiftNote
        //{
        //    get;
        //    set;
        //}

        //[JsonProperty("packing_note")]
        //public string PackingNote
        //{
        //    get;
        //    set;
        //}

        //[JsonProperty("payment_hold")]
        //public int PaymentHold
        //{
        //    get;
        //    set;
        //}

        //[JsonProperty("fraud_hold")]
        //public int FraudHold
        //{
        //    get;
        //    set;
        //}

        //[JsonProperty("address_hold")]
        //public int AddressHold
        //{
        //    get;
        //    set;
        //}

        //[JsonProperty("operator_hold")]
        //public int OperatorHold
        //{
        //    get;
        //    set;
        //}

        [JsonProperty("subtotal_price")]
        public string SubtotalPrice
        {
            get;
            set;
        }

        [JsonProperty("created_at")]
        public string CreatedAt
        {
            get;
            set;
        }

        [JsonProperty("fulfillment_status")]
        public string FulfillmentStatus
        {
            get;
            set;
        }

        [JsonProperty("required_ship_date")]
        public string RequiredShipDate
        {
            get;
            set;
        }

        [JsonProperty("total_discounts")]
        public string TotalDiscounts
        {
            get;
            set;
        }

        [JsonProperty("total_price")]
        public string TotalPrice
        {
            get;
            set;
        }

        //[JsonProperty("gift_invoice")]
        //public int GiftInvoice
        //{
        //    get;
        //    set;
        //}

        //[JsonProperty("require_signature")]
        //public int RequireSignature
        //{
        //    get;
        //    set;
        //}

        //[JsonProperty("note_attributes")]
        //public ICollection<NoteAttributes> NoteAttributes
        //{
        //    get;
        //    set;
        //}

        //[JsonProperty("order_number")]
        //public string OrderNumber
        //{
        //    get;
        //    set;
        //}


    }
}
