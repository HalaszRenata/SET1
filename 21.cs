using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SET_1._21
{
    internal class Program
    {
        static void Main(string[] args)
        //Ghiciti un numar intre 1 si 1024 prin intrebari de forma "numarul este mai mare sau egal decat x?"
        {
            Console.WriteLine("Ghiceste un numar intre 1 si 1024.");
            int limitaInferioara = 1;
            int limitaSuperioara = 1024;
            while (true)
            {
                int guess = (limitaInferioara + limitaSuperioara) / 2;
                Console.Write($"Numarul este mai mare sau egal decat {guess}? (da/nu): ");
                string raspuns = Console.ReadLine().ToLower();
                if (raspuns == "da")
                {
                    limitaInferioara = guess + 1;
                }
                else if (raspuns == "nu")
                {
                    limitaSuperioara = guess - 1;
                }
                else
                {
                    Console.WriteLine("Raspuns invalid. Va rugam sa raspundeti cu 'da' sau 'nu'.");
                    Console.ReadLine();
                }
                if (limitaInferioara > limitaSuperioara)
                {
                    Console.WriteLine("Nu ai raspuns corect sau ai folosit raspunsuri invalide. Verifica input-ul si incearca din nou.");
                    Console.ReadLine();
                    break;
                }
                if (limitaInferioara == limitaSuperioara)
                {
                    Console.WriteLine($"Numarul ghicit este: {limitaInferioara}");
                    Console.ReadLine();
                    break;
                }
            }
        }

    }
}
