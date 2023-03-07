using lab_02.Classes.Warehouses;
using lab_02.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_02.Classes.WarehouseManagers
{
    public class WarehouseManager : IWarehouseManager
    {
        private List<Product> _products { set; get; }
        private Warehouse _warehouse { get; set; }
        private Reporting _reporting { get; set; }
        public WarehouseManager(Warehouse warehouse)
        {
            _warehouse = warehouse;
            _products = warehouse.Products;
            _reporting = new(_warehouse);
        }

        public Product AddProduct(Product product)
        {
            
            if (_isProductExists(product))
            {
                throw new Exception("Product is already exists!");
            }
            else
            {
                _warehouse.LastDeliveryDate = DateTime.UtcNow.ToString("dd.MM.yy");
                _warehouse.LastDeliveryTime = DateTime.Now.ToString("hh:mm:ss");
                _reporting.CreateRevenueInvoice(product);

                _products.Add(product);
                return product;
            }
        }
        public Product RemoveProduct(Product product)
        {
            if (!_isProductExists(product)) throw new Exception("This product doesn`t exist in warehouse!");
            else
            {
                _reporting.CreateSalesInvoice(product);
                _products.Remove(product);
                return product;
            }
        }
        public void PrintReport()
        {
            Console.WriteLine(_reporting.GetLastReport());
        }

        public void PrintAllReports()
        {
            foreach (string item in _reporting.GetAllReports())
            {
                Console.WriteLine($"{item}\n");
            }
        }
        private bool _isProductExists(Product product)
        {
            return _products.Any((p) => p.Equals(product));
        }

        
    }
}
