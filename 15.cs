using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SET1._15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Se dau 3 numere. Sa se afiseze in ordine crescatoare. 
            Console.WriteLine("Introduceti trei numere:");
            Console.Write("Numărul 1: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Numărul 2: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("Numărul 3: ");
            int num3 = int.Parse(Console.ReadLine());
            if (num1 <= num2 && num1 <= num3)
            {
                if (num2 <= num3)
                {
                    Console.WriteLine($"Numerele în ordine crescătoare: {num1}, {num2}, {num3}");
                }
                else
                {
                    Console.WriteLine($"Numerele în ordine crescătoare: {num1}, {num3}, {num2}");
                }
            }
            else if (num2 <= num1 && num2 <= num3)
            {
                if (num1 <= num3)
                {
                    Console.WriteLine($"Numerele în ordine crescătoare: {num2}, {num1}, {num3}");
                }
                else
                {
                    Console.WriteLine($"Numerele în ordine crescătoare: {num2}, {num3}, {num1}");
                }
            }
            else
            {
                if (num1 <= num2)
                {
                    Console.WriteLine($"Numerele în ordine crescătoare: {num3}, {num1}, {num2}");
                }
                else
                {
                    Console.WriteLine($"Numerele în ordine crescătoare: {num3}, {num2}, {num1}");
                }
                Console.ReadLine();
            }
        }
    }
}
