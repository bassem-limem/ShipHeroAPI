using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipHeroAPI.Entities.Order
{
    public class OrderHistory
    {
        [JsonProperty("token")]
        public string Token
        {
            get;
            set;
        }
        
        [JsonProperty("order_id")]
        public int OrderId
        {
            get;
            set;
        }

        [JsonProperty("username")]
        public string Username
        {
            get;
            set;
        }

        [JsonProperty("information")]
        public string HistoryContent
        {
            get;
            set;
        }
    }
}
