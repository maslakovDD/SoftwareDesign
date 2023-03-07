using lab_02.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_02.Classes.Warehouses
{
    public class DairyWarehouse : Warehouse
    {
        public DairyWarehouse() : base()
        {

        }
        public DairyWarehouse(DairyWarehouse dairyWarehouse) : base(dairyWarehouse)
        {

        }
    }
}
