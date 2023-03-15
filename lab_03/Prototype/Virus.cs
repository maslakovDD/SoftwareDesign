using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    internal class Virus : IVirus
    {
        protected int _weight { get; set; }
        protected int _age { get; set; }
        protected string _type { get; set; }
        private List<Virus> _children { get; set; } = new List<Virus>();

        public Virus(int weight, int age, string type)
        {
            _age = age;
            _type = type;
            _weight = weight;
        }
        public Virus(Virus virus)
        {
            _weight = virus._weight;
            _age = virus._age;
            _type = virus._type;
        }   
        public IVirus Clone()
        {
            return new Virus(this);
        }
        public int SetWeight(int weight)
        {
            return _weight = weight;
        }
        public int SetAge(int age)
        {
            return _age = age;
        }
        public string SetType(string type)
        {
            return _type = type;
        }
        public void AddChild<T>(T child) where T : Virus
        {
            this._children.Add(child);
        }
        public void RemoveChild<T>(T child) where T : Virus
        {
            if (_children.Any((p) => p.GetHashCode() == child.GetHashCode()))
                this._children.Remove(child);
            else throw new Exception("There is no child");
        }
        public override string ToString()
        {
            return new StringBuilder()
                .AppendLine($"Type: {_type}")
                .AppendLine($"Weight: {_weight}")
                .AppendLine($"Age: {_age}")
                .AppendLine($"Children count: {_children.Count}")
                .ToString();
        }
    }
}
