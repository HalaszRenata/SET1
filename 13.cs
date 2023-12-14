using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SET1._13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Determianti cati ani bisecti sunt intre anii y1 si y2.
            Console.Write("Introduceti y1: ");
            int y1 = int.Parse(Console.ReadLine());
            Console.Write("Introduceti y2: ");
            int y2 = int.Parse(Console.ReadLine());
            int y = 0;

            for (int i = y1; i <= y2; i++)
            {
                if ((i % 4 == 0) && ((i % 100 != 00)|| (i % 400 == 0)))
                {
                    y++;
                }
            }
            Console.Write($"Sunt {y} ani bisecti intre {y1} si {y2}");
            Console.ReadLine();
        }
    }
}
