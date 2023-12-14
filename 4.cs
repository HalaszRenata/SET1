using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SET1._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Detreminati daca un an y este an bisect. 
            Console.WriteLine("Introduceti anul : ");
            int an = int.Parse(Console.ReadLine());

            if (an % 4 == 0 && (an % 100 != 0 || an % 400 == 0))
            {
                Console.WriteLine($"{an} este un an bisect");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine($"{an} nu este un an bisect");
                Console.ReadLine();
            }
        }
    }
}
