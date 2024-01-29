using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KontrolaTokaPrograma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;

            Console.WriteLine("Unesite duljinu stranice x:");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("Unesite duljinu stranice y:");
            y = int.Parse(Console.ReadLine());

            Console.WriteLine("Unesite duljinu stranice z:");
            z = int.Parse(Console.ReadLine());

            if (x > 0 && y > 0 && z > 0)
            {
                if (x * x + y * y == z * z || x * x + z * z == y * y || y * y + z * z == x * x)
                {
                    Console.WriteLine("Unesene vrijednosti predstavljaju stranice pravokutnog trokuta.");
                }
                else
                {
                    Console.WriteLine("Unesene vrijednosti ne predstavljaju stranice pravokutnog trokuta.");
                }
            }
            else
            {
                Console.WriteLine("Unesene vrijednosti moraju biti veće od 0.");
            }

            Console.ReadKey();  
        }
    }
}
