using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SET1._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //(Swap restrictionat) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. Se cere sa se inverseze valorile lor fara a folosi alte variabile suplimentare.  
            Console.Write("Introduceti valoarea pentru a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Introduceti valoarea pentru b: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"Valoarea initiala a lui a: {a}");
            Console.WriteLine($"Valoarea initiala a lui b: {b}");
            a = a * b;
            b = a / b;
            a = a / b;
            Console.WriteLine($"Valoarea inversata a lui a: {a}");
            Console.WriteLine($"Valoarea inversata a lui b: {b}");
            Console.ReadLine();
        }
    }
}
