using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SET1._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.RedaLine());
            int c = int.Parse(Console.ReadLine());
            a = a * b;
            b = a / b;
            a = a / b;
            Console.WriteLine($"{a} si {b}");
            Console.ReadLine();
        }
    }
}
