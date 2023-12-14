using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SET1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Rezolvati ecuatia de gradul 1 cu o necunoscuta: ax+b = 0, unde a si b sunt date de intrare. 
            Console.WriteLine("Introduceti valoarea lui a : ");
            double a = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti valoarea lui b : ");
            double b = int.Parse(Console.ReadLine());
            double x;
            x = -b / a;
            Console.WriteLine($"Pentru ecuatia ax+b solutia este : {x}");
            Console.ReadLine();
        }
    }
}
