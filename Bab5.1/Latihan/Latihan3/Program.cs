using System;

namespace Latihan3
{
    class Program
    {
        static void Main(string[] args)
        {
            float alas, tinggi, luas;
            string input;

            Console.Write("Menghitung luas segitiga v1.3\n\nMasukkan nilai alas : ");
            input = Console.ReadLine();

            float.TryParse(input, out alas);

            Console.Write("Masukkan nilai tinggi : ");
            input = Console.ReadLine();
            float.TryParse(input, out tinggi);

            if(alas > 0 && tinggi > 0)
            {
                luas = (alas*tinggi)/2;
                Console.Write("Luas segitiga : {0}\n", luas);
            }
            else
            {
                Console.Write("Nilai Alas dan Tinggi harus lebih dari nol.\n");
            }
        }
    }
}
/* Bab 5 - Latihan3
Tugas   :   Memperbaiki program segitiga dengan menggunakan statement if() 
*/