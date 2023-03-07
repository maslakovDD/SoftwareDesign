using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab_02.Classes;

namespace lab_02.Interfaces
{
    public interface IWarehouseManager
    {
        public Product AddProduct(Product product);
        public Product RemoveProduct(Product product);
        public void PrintReport();
        public void PrintAllReports();
    }
}
