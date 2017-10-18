using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipHeroAPI.Entities.Kits
{
    public class Components
    {
        [JsonProperty("sku")]
        public ICollection<string> SKU
        {
            get;
            set;
        }

        [JsonProperty("qty")]
        public ICollection<string> Qty
        {
            get;
            set;
        }

    }
}
