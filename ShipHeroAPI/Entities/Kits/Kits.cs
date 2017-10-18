using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipHeroAPI.Entities.Kits
{
    public class Kits
    {
        [JsonProperty("parent_sku")]
        public string ParentSKU
        {
            get;
            set;
        }

        [JsonProperty("kit_build")]
        public int KitBuild
        {
            get;
            set;
        }

        [JsonProperty("components")]
        public ICollection<Components> Components
        {
            get;
            set;
        }
    }
}
