using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    internal class Factorial
    {
        public static int Sum(int num) {
            int bandera = num - 1;
            if (num > 0)
            {
                for (int i = 1; i <=bandera; i++)
                {
                    num=num*i;
                }
            }
            else { 
            
                num= 0;
            }
            return num;
        }

       
    }
}
