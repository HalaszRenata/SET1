using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SET1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Determinati daca n se divide cu k, unde n si k sunt date de intrare. 
            Console.WriteLine("Introduceti valoarea lui n : ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti valoarea numarului k : ");
            int k = int.Parse(Console.ReadLine());
            if (n % k == 0)
            {
                Console.WriteLine($"{n} se divide cu {k}.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine($"{n} nu se divide cu {k}.");
                Console.ReadLine();
            }
        }
    }
}
