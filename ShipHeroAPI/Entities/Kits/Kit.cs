using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipHeroAPI.Entities.Kits
{
    class Kit
    {
        [JsonProperty("token")]
        public string Token
        {
            get;
            set;
        }

        [JsonProperty("kits")]
        public ICollection<Kits> Kits
        {
            get;
            set;
        }

    }
}
