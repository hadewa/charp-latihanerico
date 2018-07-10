using System;

namespace Latihan2
{
    class Program
    {
        static void Main(string[] args)
        {
            int bilangan;
            string input;

            Console.Write("Masukkan input : ");
            input = Console.ReadLine();
            int.TryParse(input, out bilangan);

            if(bilangan < 0)
            {
                Console.Write("Negatif\n");
            }
            else if(bilangan > 0)
            {
                Console.Write("Positif\n");
            }
            else
            {
                Console.Write("Nol\n");
            }
        }
    }
}
// Bab 5 - Latihan2 elseif()