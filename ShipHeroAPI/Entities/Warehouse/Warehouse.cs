using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipHeroAPI.Entities.Warehouse
{
    public class Warehouse
    {
        public string Available
        {
            get;
            set;
        }

        public string InventoryBin
        {
            get;
            set;
        }

        public string InventoryOverStockBin
        {
            get;
            set;
        }

        public string Backorder
        {
            get;
            set;
        }

        public string WarehouseType
        {
            get;
            set;
        }

        public string OnHand
        {
            get;
            set;
        }

        public string Allocated
        {
            get;
            set;
        }
    }
}
