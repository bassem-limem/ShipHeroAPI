using ShipHeroAPI.Entities.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipHeroAPI.Settings
{
    public class RequestMessageHandler
    {

        public string ResponseMessage(ResponseMessage response)
        {
            if(response.Code == "200")
            {
                return "Operation successful";
            }
            else if(response.Code == "400")
            {
                return "Bad request";
            }
            else if (response.Code == "401")
            {
                return "Unauthorized user";
            }
            else
            {
                return "Unknown problem";
            }
        }
    }
}
