using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    internal class CambioLetras
    {
        public static string letra(string str) {

            char[] chars = str.ToCharArray();
            int[] ascii=new int[chars.Length];
            for (int i = 0; i < chars.Length; i++)
            {
                ascii[i]= (int)chars[i];
            }
            
            for (int i = 0; i < chars.Length; i++)
            {
                //for (int x = 'a'; x < 'z'; x++)
                //{
                //    char[] charstemp = new char[1];

                //    if (chars[i] == x)
                //    {
                //        x = x + 1;
                //        charstemp[0] = (char)x;
                //        chars[i] = charstemp[0];
                //        break;
                //    }
                //}
                ascii[i] = ascii[i]+1;
                chars[i] = (char)ascii[i];
            }

            str=string.Join("", chars);
            return str;
        
        }
    }
}
