using System;

namespace TrackingNo1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            string input;

            input = Console.ReadLine();
            int.TryParse(input, out a);
            input = Console.ReadLine();
            int.TryParse(input, out b);

            a = a+b;
            b = b+a;

            Console.Write("{0} {1}", a, b);
        }
    }
}
/* Bab 4 - Tracking nomor 1
Soal    :   Tentukanlah apa yang ditampilkan ke layar oleh kode
            program di bawah ini jika input yang diberikan adalah 2 dan
            3.

Hasil   :   5 8 
*/