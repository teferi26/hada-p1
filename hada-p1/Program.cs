using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hada_p1
{
    class Program
    {
        static void Main(string[] args)
        {
            String s, r;
            r = "s";
            do
            {
                Console.WriteLine("De que unidad partes? (h,m,s)\n");
                s = Console.ReadLine();
                if (s != "m" && s != "s"&& s!="h")
                {
                    Console.WriteLine("No has introducido bien el parámetro, vamos a volver a intentarlo :). \n");
                }
                else if (s == "h")
                {
                    Console.WriteLine("Introduce el número de horas:\t");
                    HadaP1.Houres2Minutes(double.Parse(Console.ReadLine()));
                    Console.WriteLine("¿Quieres realizar otra conversion?\n");
                    r = Console.ReadLine();
                }
                else if (s == "m")
                {
                    Console.WriteLine("Introduce el número de minutos:\t");
                    HadaP1.Minutes2Seconds(double.Parse(Console.ReadLine()));
                    Console.WriteLine("¿Quieres realizar otra conversion?\n");
                    r = Console.ReadLine();
                }
                else if (s=="s")
                {
                    Console.WriteLine("Introduce el número de segundos:\t");
                    HadaP1.Minutes2Seconds(double.Parse(Console.ReadLine()));
                    Console.WriteLine("¿Quieres realizar otra conversion?\n");
                    r = Console.ReadLine();
                }
            } while (r == "s");

        }
    }
}
