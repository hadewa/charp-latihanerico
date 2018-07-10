using System;

namespace Tracking1
{
    class Program
    {
        static void Main(string[] args)
        {
            int bil;
            string input;

            input = Console.ReadLine();
            int.TryParse(input, out bil);

            if (bil % 2 == 0)
                bil = bil + 1;
            Console.Write("{0}\n", bil);
        }
    }
}
/* Bab 5 - Tracking nomor1
Soal    :   Tentukanlah apa yang ditampilkan ke layar oleh kode
            program di bawah ini jika input yang diberikan adalah 2 dan
            3.

Jawaban :   3 dan 3.    
*/