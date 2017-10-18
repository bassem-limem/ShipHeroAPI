using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipHeroAPI.Entities.Order
{
    public class ShippingAddress
    {
        [JsonProperty("first_name")]
        public string FirstName
        {
            get;
            set;
        }

        [JsonProperty("last_name")]
        public string LastName
        {
            get;
            set;
        }


        [JsonProperty("company")]
        public string CompanyName
        {
            get;
            set;
        }

        [JsonProperty("phone")]
        public string Phone
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

        [JsonProperty("province")]
        public string StateName
        {
            get;
            set;
        }

        [JsonProperty("province_code")]
        public string StateCode
        {
            get;
            set;
        }

        [JsonProperty("zip")]
        public string ZipCode
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
        
        [JsonProperty("country_code")]
        public string CountryCode
        {
            get;
            set;
        }

    }
}
