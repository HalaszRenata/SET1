using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SET1._16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Se dau 5 numere. Sa se afiseze in ordine crescatoare. (nu folositi tablouri)
            Console.WriteLine("Introduceti cinci numere:");
            int[] numere = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Numărul {i + 1}: ");
                numere[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(numere);
            Console.WriteLine("Numerele în ordine crescătoare:");
            foreach (int numar in numere)
            {
                Console.WriteLine(numar);
            }
            Console.ReadLine();
        }
    }
}
