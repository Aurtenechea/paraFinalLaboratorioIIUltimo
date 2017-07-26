using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica5
{
    sealed class Boss : Employee
    {
        public Boss(string name, int age, int dni, float salary)
            : base(name, age, dni, salary)
        {
        }

        public override void myName()
        {
            Console.WriteLine("Nombre del BOSS: " + this.name);
        }
    }
}
