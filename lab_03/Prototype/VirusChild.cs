using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    internal class VirusChild : Virus
    {
        private DateTime _birthDate { get; set; }
        private Virus _parent { get; set; }
        public VirusChild(int weight,int age, string type, DateTime birthDate, Virus parent) : base(weight,age,type)
        {
            _birthDate = birthDate;
            _parent = (Virus) parent;
            _parent.AddChild(this);
        }
        public VirusChild(VirusChild virusChild) : base(virusChild)
        {
            this._birthDate = virusChild._birthDate;
            this._parent = (Virus) virusChild._parent;
            _parent.AddChild(this);
        }
        public Virus SetParent(Virus parent)
        {
            parent.AddChild(this);
            _parent.RemoveChild(this);
            return _parent = parent;
        }
        public new IVirus Clone()
        {
            return new VirusChild(this);
        }
        public override string ToString()
        {
            return new StringBuilder()
                .AppendLine($"Type: {_type}")
                .AppendLine($"Weight: {_weight}")
                .AppendLine($"Age: {_age}")
                .AppendLine($"Birth date: {_birthDate.ToString()}")
                .AppendLine($"Parent:\n{_parent.ToString()}")
                .ToString();
        }
    }
}
