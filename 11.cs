using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SET1._11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Afisati in ordine inversa cifrele unui numar n. 
            Console.Write("Introduceti un numar: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Cifrele in ordine inversa sunt: ");
            while (n > 0)
            {
                int cifra = n % 10; 
                Console.Write(cifra);
                n /= 10; 
            }
            Console.ReadLine();
        }
    }
}
