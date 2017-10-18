using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipHeroAPI.Entities.Vendor
{
    public class Vendor
    {
        [JsonProperty("token")]
        public string Token
        {
            get;
            set;
        }

        [JsonProperty("vendor_name")]
        public string Name
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

        [JsonProperty("vendor_account_number")]
        public string AccountNumber
        {
            get;
            set;
        }

        [JsonProperty("vendor_address1")]
        public string AddressLine1
        {
            get;
            set;
        }

        [JsonProperty("vendor_address2")]
        public string AddressLine2
        {
            get;
            set;
        }

        [JsonProperty("vendor_city")]
        public string City
        {
            get;
            set;
        }

        [JsonProperty("vendor_state")]
        public string State
        {
            get;
            set;
        }

        [JsonProperty("vendor_zip")]
        public string ZipCode
        {
            get;
            set;
        }

        [JsonProperty("vendor_country")]
        public string Country
        {
            get;
            set;
        }

        [JsonProperty("vendor_phone")]
        public string Phone
        {
            get;
            set;
        }

        [JsonProperty("internal_note")]
        public string InternalNote
        {
            get;
            set;
        }

        [JsonProperty("default_po_note")]
        public string DefaultPONote
        {
            get;
            set;
        }
    }
}
