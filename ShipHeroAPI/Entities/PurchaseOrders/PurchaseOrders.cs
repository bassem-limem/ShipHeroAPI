using Newtonsoft.Json;
using ShipHeroAPI.Entities.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipHeroAPI.Entities.PurchaseOrders
{
    public class PurchaseOrders
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

        //[JsonProperty("po_id")]
        //public int Id
        //{
        //    get;
        //    set;
        //}

        //[JsonProperty("po_number")]
        //public string PONumber
        //{
        //    get;
        //    set;
        //}

        [JsonProperty("vendor_name")]
        public string VendorName
        {
            get;
            set;
        }

        //[JsonProperty("vendor_id")]
        //public int VendorId
        //{
        //    get;
        //    set;
        //}

        //[JsonProperty("vendor_account_number")]
        //public string VendorAccountNumber
        //{
        //    get;
        //    set;
        //}

        //[JsonProperty("vendor_address1")]
        //public string VendorAddressLine1
        //{
        //    get;
        //    set;
        //}

        //[JsonProperty("vendor_address2")]
        //public string VendorAddressLine2
        //{
        //    get;
        //    set;
        //}

        //[JsonProperty("vendor_city")]
        //public string VendorCity
        //{
        //    get;
        //    set;
        //}

        //[JsonProperty("vendor_state")]
        //public string VendorState
        //{
        //    get;
        //    set;
        //}

        //[JsonProperty("vendor_zip")]
        //public string VendorZipCode
        //{
        //    get;
        //    set;
        //}

        //[JsonProperty("vendor_country")]
        //public string VendorCountry
        //{
        //    get;
        //    set;
        //}

        [JsonProperty("vendor_phone")]
        public string VendorPhone
        {
            get;
            set;
        }

        [JsonProperty("expected_date")]
        public string ExpectedReceiveDate
        {
            get;
            set;
        }

        //[JsonProperty("packing_note")]
        //public string PackingNote
        //{
        //    get;
        //    set;
        //}

        //[JsonProperty("shipping_method")]
        //public string ShippingMethod
        //{
        //    get;
        //    set;
        //}

        //[JsonProperty("shipping_carrier")]
        //public string ShippingCarrier
        //{
        //    get;
        //    set;
        //}

        //[JsonProperty("tracking_number")]
        //public string TruckingNumber
        //{
        //    get;
        //    set;
        //}

        //[JsonProperty("warehouse")]
        //public string Warehouse
        //{
        //    get;
        //    set;
        //}

        [JsonProperty("line_items")]
        public ICollection<LineItem> LineItems
        {
            get;
            set;
        }

        //[JsonProperty("subtotal_price")]
        //public string SubtotalPrice
        //{
        //    get;
        //    set;
        //}

        //[JsonProperty("shipping_price")]
        //public string ShippingPrice
        //{
        //    get;
        //    set;
        //}

        //[JsonProperty("total_discounts")]
        //public string TotalDiscounts
        //{
        //    get;
        //    set;
        //}

        //[JsonProperty("total_tax")]
        //public string TotalTax
        //{
        //    get;
        //    set;
        //}

        //[JsonProperty("total_price")]
        //public string TotalPrice
        //{
        //    get;
        //    set;
        //}

        //Required , the Format : yyyy/MM/dd HH:mm:ss
        [JsonProperty("created_at")]
        public string CreatedAt
        {
            get;
            set;
        }
    }
}
