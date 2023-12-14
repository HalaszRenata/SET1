using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SET1._14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Determianti daca un numar n este palindrom. (un numar este palindrom daca citit invers obtinem un numar egal cu el, de ex. 121 sau 12321. 
            Console.Write("Introduceti un numar: ");
            int numar = int.Parse(Console.ReadLine());
            int numar1=0, numar2=numar
            while(numar!=0)
            {
                numar1 = numar1 * 10 + numar % 10;
                numar /= 10;
            }    

            if (numar1 == numar2)
            {
                Console.WriteLine($"{numar2} este un număr palindrom.");
            }
            else
            {
                Console.WriteLine($"{numar2} nu este un număr palindrom.");
            }
            Console.ReadLine();
        }
    }
}
