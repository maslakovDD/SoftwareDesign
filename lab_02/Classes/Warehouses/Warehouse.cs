using lab_02.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_02.Classes.Warehouses
{
    public abstract class Warehouse
    {
        public ICurrency? Currency { get; set; }
        public List<Product> Products { get; set; } = new();
        public string? LastDeliveryDate { get; set; }
        public string? LastDeliveryTime { get; set; }
        public Warehouse()
        {
        }
        public Warehouse(Warehouse warehouse)
        {
            Products = warehouse.Products;
            LastDeliveryDate = warehouse.LastDeliveryDate;
            LastDeliveryTime = warehouse.LastDeliveryTime;
        }
    }
}
