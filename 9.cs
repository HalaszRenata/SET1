using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SET1._9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Afisati toti divizorii numarului n.
            Console.Write("Introduceti un numar: ");
            int numar = int.Parse(Console.ReadLine());
            Console.WriteLine($"Divizorii numarului {numar} sunt:");
            for (int i = 1; i <= numar; i++)
            {
                if (numar % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
    }
}
