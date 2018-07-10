using System;

namespace Tracking2
{
    class Program
    {
        static void Main(string[] args)
        {
            int bil;
            string input;

            input = Console.ReadLine();
            int.TryParse(input, out bil);

            if(bil % 2 ==0)
                Console.Write("Genap\n");
            if(bil > 0)
                Console.Write("Positif\n");
            if(bil % 2 !=0)
            {
                Console.Write("Ganjil\n");
                if(bil > 0)
                    Console.Write("Positif\n");
                else
                {
                    Console.Write("Negatif\n");
                }
            }
        }
    }
}
/* Bab 5 - Tracking nomor 2
Soal    :   Tentukanlah apa yang ditampilkan ke layar oleh kode
            program di bawah ini jika input yang diberikan adalah
            2, 3, -2, dan 3.

Jawaban :   1.) Genap
                Positif
            2.) Positif
                Ganjil
                Positif
            3.) Genap
            4.) Ganjil
                Negatif 
*/