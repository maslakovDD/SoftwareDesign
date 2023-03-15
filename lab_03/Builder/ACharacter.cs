using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public abstract class ACharacter
    {
        protected string _name { get; set; }
        protected int _damage { get;set; }
        protected int _hitPoints { get; set; }
        protected int _weapon { get; set; }
        protected int _armor { get; set; }
        protected string _ability { get; set; }
    }
}
