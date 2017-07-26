using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica19._3
{
    class ClaseDos
    {
        public static int operator + (ClaseDos a, int b)
        {
            return 0;
        }

        public static explicit operator ClaseDos(int a )
        {
            return new ClaseDos();
        }

        public void opParameter(int a , int ?b){
            
        }
    }
}
