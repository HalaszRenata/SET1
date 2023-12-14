using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SET1._12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Determinati cate numere integi divizibile cu n se afla in intervalul [a, b]. 
            Console.Write("Introduceti un numar: ");
            int numar = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti un interval de numere: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int k = 0;
            for (int i = a; i <= b; i ++)
            {
                if (i % numar == 0)
                {
                    k++;
                }
                Console.WriteLine($"Sunt {k} numere intregi care se divid cu {numar} si apartine intervalului [{a},{b}]");
                Console.ReadLine();
            }

        }
    }
}
