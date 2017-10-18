using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipHeroAPI.Entities.Order
{
    public class ShippingLines
    {
        [JsonProperty("title")]
        public string Title
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

        [JsonProperty("method")]
        public string Method
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
    }
}
