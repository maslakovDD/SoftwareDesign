using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_02.Classes
{
    public class Category
    {
        private Guid _id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }

        public Category(string name)
        {
            _id = new Guid();
            Name = name;
        }

        public Category(string name, string description)
        {
            _id = new Guid();
            Name = name;
            Description = description;
        }
        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            else
            {
                if (obj is Category)
                {
                    var item = obj as Category;
                    return _id == item._id;
                }
                else return false;
            }
        }
    }
}
