using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtroNamespace
{
    public static class ExtMethod
    {
        public static Array getArray(this Random r, int cant)
        {
            int[] nums = new int[cant];
            for (int i = 0; i < cant; i++)
            {
                nums[i] = r.Next(0, 100);
            }

            return nums;
        }

        public static String ToString(this Array s)
        {
            return "hola gato";
        }
    }

   
}
