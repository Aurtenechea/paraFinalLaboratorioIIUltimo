using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3
{
    public abstract class AbstractEmployee : Person
    {
        public AbstractEmployee(string name, int age, int dni, float salary)
            : base(name, age, dni)
        {}

        /*  esto es posible aunque carece de sentido. */
        public abstract override void myName();
    }
}
