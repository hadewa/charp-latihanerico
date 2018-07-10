using System;

namespace Programming3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            string input;

            input = Console.ReadLine();
            int.TryParse(input, out a);

            Console.Write("{0}", a);
        }
    }
}
/* Bab 4 - Programming nomor 3
Soal            =   Buatlah sebuah program yang meminta nilai untuk sebuah 
                    variabel integer dan menampilkan nilai tersebut ke layar.
                    
Contoh Intput   =   5
Contoh Output   =   5 
*/