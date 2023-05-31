using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    internal class Palabralarga
    {
        public static string palabramaslarga(string str) {

            string [] cadena=str.Split(' ');
            int[] caracteres= new int[cadena.Length];
            int pos = 0;
            for (int i = 0; i < cadena.Length; i++)
            {
                caracteres[i] = cadena[i].Length;
            }
            Array.Sort(caracteres);
            Array.Reverse(caracteres);
            
            

            for (int i = 0; i < caracteres.Length; i++)
            {
                if (cadena[i].Length == caracteres[0])
                {
                    pos = i;
                }
            }
            str = cadena[pos].ToString();
            return str;
        }
    }
}
