using System;

namespace Latihan3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Bab 4 - Latihan3
            Menghitung luas segitiga v2 */

            float alas, tinggi, luas;
            string input;

            Console.Write("Menghitung luas segitiga v1.2\n\nMasukkan nilai alas : ");
            input = Console.ReadLine();
            float.TryParse(input, out alas);

            Console.Write("Masukkan nilai tinggi : ");
            input = Console.ReadLine();
            float.TryParse(input, out tinggi);

            luas = (alas*tinggi)/2;

            Console.Write("Hasil : {0}\n", luas);
        }
    }
}