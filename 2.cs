using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SET1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // Rezolvati ecuatia de gradul 2 cu o necunoscuta: ax ^ 2 + bx + c = 0, unde a, b si c sunt date de intrare. Tratati toate cazurile posibileRezolvati ecuatia de gradul 2 cu o necunoscuta: ax ^ 2 + bx + c = 0, unde a, b si c sunt date de intrare. Tratati toate cazurile posibile
            Console.WriteLine("Introduceti valoarea lui a : ");
            double a = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti valoarea lui b : ");
            double b = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti valoarea lui c : ");
            double c = int.Parse(Console.ReadLine());
            double delta = b * b - 4 * a * c;


            if ( delta > 0)
            {
                Console.WriteLine("In acest caz  vom avea solutiile : ");
                Console.WriteLine("Prima solutie : ");
                double x1 = ((-b + Math.Sqrt(delta)) / (2 * a));
                Console.WriteLine(x1);
                Console.WriteLine("A doua solutie : ");
                double x2 = ((-b + Math.Sqrt(delta)) / (2 * a));
                Console.WriteLine(x2);
                Console.ReadLine();
            }
            if (delta == 0)
            {
                Console.WriteLine("Exista o solutie reaala.Solutia ecuatiei este : ");
                double x = -b / 2 * a;
                Console.WriteLine(x);
                Console.ReadLine();
            }
            if (delta < 0)
            {
                Console.WriteLine("Nu exista solutii reale.");
                Console.ReadLine();
            }
;
        }
    }
}
