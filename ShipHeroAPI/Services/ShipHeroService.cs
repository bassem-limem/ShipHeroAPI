using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ShipHeroAPI.Services
{
    public abstract class ShipHeroService
    {
        protected Uri _ShipHeroUri { get; set; }
        protected string _AccessToken { get; set; }

        
        /// <summary>
        /// Create a new instance of ShipHeroService
        /// </summary>
        /// <param name="ShipHeroUrl">ShipHero Url</param>
        /// <param name="ShipHeroAccessToken">ShipHero Access Token</param>
        protected ShipHeroService( string ShipHeroUrl, string ShipHeroAccessToken)
        {
            _ShipHeroUri = new Uri(ShipHeroUrl);
            _AccessToken = ShipHeroAccessToken;
        }


        //to complete the rest of methods ...

    }
}
