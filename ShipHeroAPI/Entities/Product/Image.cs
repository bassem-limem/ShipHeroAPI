using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipHeroAPI.Entities.Product
{
    public class Image
    {
        [JsonProperty("src")]
        public string Url
        {
            get;
            set;
        }
        [JsonProperty("position")]
        public int Position
        {
            get;
            set;
        }
    }
}
