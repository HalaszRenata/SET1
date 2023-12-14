using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SET1._19
{
    internal class Program
    {
        static void Main(string[] args)
        //Determinati daca un numar e format doar cu 2 cifre care se pot repeta. De ex. 23222 sau 9009000 sunt astfel de numere, pe cand 593 si 4022 nu sunt. 
        {
            Console.Write("Introduceti un numar: ");
            int num = int.Parse(Console.ReadLine());
            bool hasOnlyTwoRepeatingDigits = CheckForTwoRepeatingDigits(num);
            if (hasOnlyTwoRepeatingDigits)
            {
                Console.WriteLine($"{num} este format doar din doua cifre care se pot repeta.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine($"{num} nu este format doar din doua cifre care se pot repeta.");
                Console.ReadLine();
            }
        }
        static bool CheckForTwoRepeatingDigits(int num)
        {
            string numStr = num.ToString();
            int distinctDigitCount = numStr.Distinct().Count();
            return distinctDigitCount == 2;
        }
    }
}
