using System;

namespace TrackingNo2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            string input;

            input = Console.ReadLine();
            int.TryParse(input, out a);
            input = Console.ReadLine();
            int.TryParse(input, out b);

            c = a++;
            a = --b;
            b = c++;

            Console.Write("{0} {1} {2}", a, b, c);
        }
    }
}
/* Bab 4 - Tracking nomor 2
Soal    :   Tentukanlah apa yang ditampilkan ke layar oleh kode
            program di bawah ini jika input yang diberikan adalah 2 dan
            3.
            
Hasil   :   2 2 3 */