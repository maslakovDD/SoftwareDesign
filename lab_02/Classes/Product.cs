using lab_02.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab_02.Classes;

namespace lab_02.Classes
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public string Category { get; set; }
        public ICurrency Price { get; set; } // Liskov substitution principle: field has type ICurrency, but instance can has any type of implemetned classes and dependency inversion principle
        public string Measurement { get; set; }
        public Product(string name, string category, ICurrency price, string measurement, string? descriptioin = null)
        {
            Id = Guid.NewGuid();
            Name = name;
            Price = price;
            Measurement = measurement;
            Description = descriptioin;
            Category = category;
        }
        public void DecreasePrice(int cash, int coins)
        {
            this.Price.Cash -= cash;
            this.Price.Coins -= coins;
        }

        public void ConvertCurrency(ICurrency convertedCurrency)
        {

        }
        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            else
            {
                if (obj is Product)
                {
                    var item = obj as Product;
                    return item.Name == Name && item.Price.Equals(Price) && item.Category == Category;
                }
                else return false;
            }
        }
    }
}
