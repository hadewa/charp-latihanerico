using System;

namespace Programming4
{
    class Program
    {
        static void Main(string[] args)
        {
            int sisi, luas;
            string input;

            input = Console.ReadLine();
            int.TryParse(input, out sisi);

            luas = sisi*sisi;

            Console.Write("{0}", luas);
        }
    }
}
/* Bab 4 - Programming nomor 4
Soal            =   Buatlah sebuah program yang meminta nilai sisi sebuah
                    bujursangkar dan menampilkan luas bujursangkar tersebut
                    ke layar.

Contoh Input    =   4
Contoh Output   =   16 
*/