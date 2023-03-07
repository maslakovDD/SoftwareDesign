using lab_02.Classes.Warehouses;
using lab_02.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_02.Classes.WarehouseManagers
{
    public class WarehouseInfoManager : IWarehouseInfo
    {
        private Warehouse _warehouse { get; set; }
        public WarehouseInfoManager(Warehouse warehouse)
        {
            _warehouse = warehouse;
        }

        public string GetWarehouseProductsInfo()
        {
            string res = $"{"Name",-5}\t{"Price",-10}\t{"Measurement",-5}\n";
            if (_warehouse.Products.Count > 0)
                foreach (Product product in _warehouse.Products)
                {
                    res += $"{product.Name,-5}\t{product.Price,-10}\t{product.Measurement,-5}\n";
                }
            else
                res = "There is no products in the warehouse!";
            return res;
        }
        public string GetWarehouseInfo()
        {
            StringBuilder res = new StringBuilder();
            res.AppendLine("Warehouse general information: ");
            if (_warehouse.LastDeliveryDate == null)
                res.AppendLine($"Last delivery time:\tno information");
            else
                res.AppendLine($"Last delivery time:\t{_warehouse.LastDeliveryTime} {_warehouse.LastDeliveryDate}");
            res.AppendLine($"Product quantity:\t{_warehouse.Products.Count}");
            return res.ToString();
        }
    }
}
