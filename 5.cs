using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SET1._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Extrageti si afisati a k-a cifra de la sfarsitul unui numar. Cifrele se numara de la dreapta la stanga. 
            Console.WriteLine("Introduceti un numar:");
            string numar = Console.ReadLine();
            Console.Write("Introduceti pozitia cifrei k :");
            int k = int.Parse(Console.ReadLine());

            if (k >= 1 && k <= numar.Length)
            {
                char cifra = numar[numar.Length - k];
                Console.WriteLine($"Cifra a {k}-a de la sfarsitul numarului este: {cifra}");
            }
            else
            {
                Console.WriteLine("Pozitia cifrei (k) este incorecta. Numarul are doar " + numar.Length + " cifre de la dreapta la stanga.");
            }
            Console.ReadLine();
        }
    }
}