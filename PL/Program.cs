using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PL
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int op = 0;
                while (op!=6)
                {

                
                Console.WriteLine("Ingrese la opcion que dese hacer: \n1.-Factorial\n2.-Cambio de letra" +
                "\n3.-sopa de letras\n4.-palabra mas larga\n5.-Cadena Verdadera o Falsa");
             op= int.Parse(Console.ReadLine());
            

           
            switch (op)
            {
                case 1:
                    Console.WriteLine("Ingrese un numero");
                    int res=Factorial.Sum(int.Parse(Console.ReadLine()));
                    Console.WriteLine("El factorial del numero es: "+res);
                    break;
                    case 2:
                    Console.WriteLine("Ingrese una palabra");
                    string cambio = CambioLetras.letra(Console.ReadLine());
                    Console.WriteLine("El resultado es: "+cambio);
                    break;
                    case 3:
                    Console.WriteLine("Ingrese una palabra");
                    string sopa=SopaLetras.sopaL(Console.ReadLine());
                    Console.WriteLine("El resultado es: "+sopa);
                    break;
                    case 4:
                    Console.WriteLine("Ingrese una oracion");
                    string palabra = Palabralarga.palabramaslarga(Console.ReadLine());
                    Console.WriteLine("La palabra mas larga es: "+palabra);
                    break;
                    case 5:
                    Console.WriteLine("Ingrese una cadena: ");
                    string bandera = simbolossimples.simbolosSimples(Console.ReadLine());
                    Console.WriteLine("La cadena es "+bandera);
                    break;
                default:
                    break;
            }
            }
            }
            catch (Exception)
            {

                Console.WriteLine("Debe de ingresar una opcion valida");
            }
            Console.ReadLine();
        }
    }
}
