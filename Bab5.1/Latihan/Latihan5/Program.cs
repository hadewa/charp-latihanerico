using System;

namespace Latihan5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            string input;

            input = Console.ReadLine();
            int.TryParse(input, out a);

            switch(a + 1)
            {
                case 1: Console.Write("nol\n");
                break;
                case 2: Console.Write("Satu\n");
                break;
                case 3: Console.Write("Dua\n");
                break;
                default:
                    a = -1;
                    Console.Write("Min satu\n");
                    break;
            }
        }
    }
}
/* Bab 5 - Latihan5
Tugas   :   Pengenalan statement switch 
*/