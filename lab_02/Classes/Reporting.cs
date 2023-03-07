using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab_02.Classes.WarehouseManagers;
using lab_02.Classes.Warehouses;

namespace lab_02.Classes
{
    public class Reporting
    {
        private List<string> _reports;
        private Warehouse _warehouse;
        private Product _product;
        private WarehouseInfoManager _warehouseInfoManager;
        public Reporting(Warehouse warehouse)
        {
            _warehouse = warehouse;
            _reports = new List<string>();
            _warehouseInfoManager = new(warehouse);
        }

        public void CreateRevenueInvoice(Product product)
        {
            _product = product;
            StringBuilder res = new StringBuilder();
            res.AppendLine($"Revenue invoice:\n{"Product comes",-10}\t{"Summary price",-10}");
            res.AppendLine($"{_product.Name,-10}\t{_product.Price.ToString(),-10}\nProducts in warehouse:\n{_warehouseInfoManager.GetWarehouseProductsInfo(),-10}\n");
            
            _reports.Add(res.ToString());
        }
        public void CreateSalesInvoice(Product product)
        {
            _product = product;
            StringBuilder res = new StringBuilder();
            res.AppendLine($"Sale invoice:\n{"Product sold",-10}\t{"Summary price",-10}");
            res.AppendLine($"{_product.Name,-10}\t{_product.Price.ToString(),-10}\nProducts in warehouse:\n{_warehouseInfoManager.GetWarehouseProductsInfo(),-10}\n");
            _reports.Add(res.ToString());
        }
        public List<string> GetAllReports()
        {
            return _reports;
        }
        public string GetLastReport()
        {
            return _reports[_reports.Count-1];
        }
    }
}
