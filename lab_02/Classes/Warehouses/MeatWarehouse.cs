using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_02.Classes.Warehouses
{
    public class MeatWarehouse : Warehouse
    {
        public MeatWarehouse():base() 
        {
        }
        public MeatWarehouse(MeatWarehouse warehouse) : base(warehouse) { }

    }
}
