using System;

namespace Latihan2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Bab 4 - Latihan2
            Menghitung Luas Segitiga v1 */
            
            int alas, tinggi, luas;
            string input;

            Console.Write("Menghitung luas segitiga v1\n\nMasukkan nilai alas : ");
            input = Console.ReadLine();
            int.TryParse(input, out alas);

            Console.Write("Masukkan nilai tinggi : ");
            input = Console.ReadLine();
            int.TryParse(input, out tinggi);

            luas = (alas*tinggi)/2;

            Console.Write("Luas segitiga : {0}\n", luas);
        }
    }
}
