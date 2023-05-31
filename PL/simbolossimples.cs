using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PL
{
    internal class simbolossimples
    {
        public static string simbolosSimples(string str){
            //Range range = 1..5;
            char[] chars = str.ToCharArray();
            string respuesta = "verdadera";
            int[] ascii=new int[chars.Length];
            int cont = 0;
            for (int i = 0; i < chars.Length; i++)
            {
                ascii[i] = (int)chars[i];
            }
            for (int x = cont; x <= ascii.Length-1; x++)
            {
                if (respuesta == "verdadera")
                {
                    for (int y = 97; y < 122; y++)
                    {
                        if (ascii[cont] == y)
                        {
                            if(x+1 < ascii.Length-1)
                            
                            if (ascii[x - 1] == 43)
                            {
                                respuesta = "verdadera";
                                break;
                            }
                            else
                            {
                                respuesta = "falso";
                                break;
                            }
                        }
                    }
                }
                else {
                    break;
                }
                cont =cont+1;
            }
            return respuesta;
        }
    }
}
