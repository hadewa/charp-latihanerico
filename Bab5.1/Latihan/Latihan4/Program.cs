using System;

namespace Latihan4
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int a;
            input = Console.ReadLine();
            int.TryParse(input, out a);

            if(a > 0)
            {
                Console.Write("{0} adalah bilangan positif.\n", a);
                if(a%7 == 0)
                {
                    Console.Write("{0} adalah bilangan kelipatan tujuh.\n", a);
                }
                else
                {
                    Console.Write("{0} bukan bilangan kelipatan tujuh.\n", a);
                }
            }
            else
            {
                Console.Write("{0} adalah nol atau bilangan negatif.\n", a);
            }
        }
    }
}

/* Bab 5 - Latihan4
Tugas   :   Membuat program dengan Advanced Technique (if() bersarang) 
*/