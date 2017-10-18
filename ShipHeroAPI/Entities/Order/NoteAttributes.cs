using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipHeroAPI.Entities.Order
{
    public class NoteAttributes
    {

        [JsonProperty("name")] 
        public string NoteName
        {
            get;
            set;
        }

        [JsonProperty("value")]
        public string NoteValue
        {
            get;
            set;
        }
    }
}
