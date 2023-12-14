using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SET1._6
{
    internal class Program
    { 
        //Detreminati daca trei numere pozitive a, b si c pot fi lungimile laturilor unui triunghi. 
        static bool PotFiLaturiTriunghi(int a, int b, int c)
        {
         if (a > 0 && b > 0 && c > 0)
         {
          return (a + b > c) && (a + c > b) && (b + c > a);
         }
          return false;
        }
        static void Main(string[] args)
        {

            Console.Write("Introduceti lungimea laturii a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Introduceti lungimea laturii b: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Introduceti lungimea laturii c: ");
            int c = int.Parse(Console.ReadLine());

            if (PotFiLaturiTriunghi(a, b, c))
            {
                Console.WriteLine("Cele trei numere pot fi lungimile laturilor unui triunghi.");
            }
            else
            {
                Console.WriteLine("Cele trei numere nu pot forma un triunghi.");
            }
            Console.ReadLine();

        }
    }
}
