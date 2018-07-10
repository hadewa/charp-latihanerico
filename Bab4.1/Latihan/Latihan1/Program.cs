using System;

namespace Latihan1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bab 4 - Latihan1

            string input;

            int bilangan1;
            float bilangan2;

            Console.Write("Masukkan bilangan bulat : ");
            input = Console.ReadLine();
            int.TryParse(input, out bilangan1);

            Console.Write("Masukkan bilangan berkoma : ");
            input = Console.ReadLine();
            float.TryParse(input, out bilangan2);
        }
    }
}
