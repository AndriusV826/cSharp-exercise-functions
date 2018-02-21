using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        /*static void Main(string[] args)
        {
            Console.WriteLine("HEY HEY HEY HEY HEY");
        
            abc();
            Console.WriteLine("wawawyyywa");
            Console.ReadKey();
        }

        static void abc()
        {
            Console.WriteLine("HEY HEY HEY");
            
            Console.WriteLine("Sudiev");
        }*/

        /*static void Main(string[] args)
        {
            Console.WriteLine("Iveskite du skacius");
            Console.WriteLine("Pirmas");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Antras");
            int b = Convert.ToInt32(Console.ReadLine());
            suma(a,b);
            skirtumas(a, b);
            sandauga(a, b);
            dalmuo(a, b);
            Console.ReadKey();
        }
        static void suma(int vienas, int du)
        {
            Console.WriteLine("Suma " + (vienas + du));
        }

        static void skirtumas(int vienas, int du)
        {
            Console.WriteLine("Skirtumas " + (vienas - du));
        }
        static void sandauga(int vienas, int du)
        {
            Console.WriteLine("Sandauga " + (vienas * du));
        }
        static void dalmuo(int vienas, int du)
        {
            Console.WriteLine("Dalmuo " + (vienas / du));
        }*/

        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite svori kilogramais");
            float a = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Iveskite ugi metrais");
            float b = Convert.ToSingle(Console.ReadLine());
            float t = KMI(a, b);
            Console.WriteLine(t);
            mase();
            Console.ReadKey();
        }
        static float KMI(float c, float d)
        {
            return (c / (d * d));
        }

        static void mase(float t)
        {
            if (t < 15)
            {
                Console.WriteLine("Badaujantis zmogus");
            }
            else if ((t >= 15) && (t < 18.5f))
            {
                Console.WriteLine("liesas zmogus");
            }
            else if ((t>=18.5f) && (t<25))
            {
                Console.WriteLine("normalaus svorio zmogus");
            }
            else if ((t>=25)&&(t<30))
            {
                Console.WriteLine("Virssvorio turintis zmogus");
            }
            else if ((t>=30)&&(t<40))
            {
                Console.WriteLine("nutukes zmogus");
            }
            else if (t>=40)
            {
                Console.WriteLine("ligotai nutukes zmogus");
            }
        }


    }

}
