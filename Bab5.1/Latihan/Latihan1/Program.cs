using System;

namespace Latihan1
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
                Console.Write("\nBilangan tersebut adalah Negatif\n");
            }
            else
            {
                Console.Write("Bilangan tersebut adalah Positif\n");
            }    
        }
    }
}

// Bab 5 - Latihan1 Perintah if()