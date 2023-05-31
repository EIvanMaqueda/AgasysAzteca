using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    internal class SopaLetras
    {
        public static string sopaL(string str) {
            char[] chars = str.ToCharArray();
            Array.Sort(chars);//ordena el arreglo de mayor a menor
            str=string.Join("", chars);
            return str;
        }
    }
}
