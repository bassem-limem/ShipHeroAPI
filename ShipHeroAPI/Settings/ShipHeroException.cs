using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ShipHeroAPI.Settings
{
    public class ShipHeroException : Exception
    {
        private string _MethodName { get; set; }

        private string _Message { get; set; }

        public ShipHeroException() { }

        public ShipHeroException(string message) : base(message) { }

        public ShipHeroException(string method, string message) : base(message)
        {
            this._MethodName = method;
            this._Message = message;
        }


    }
}
