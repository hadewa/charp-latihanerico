using System;

namespace Programming1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            string input;

            Console.Write("Masukkan input : ");
            input = Console.ReadLine();
            int.TryParse(input, out a);

            if(a % 2 == 0)
                Console.Write("Genap\n");
            else
            {
                Console.Write("Ganjil\n");
            }
        }
    }
}
/* Bab 5 - Programming nomor 1
Tugas           =   Buatlah program yang meminta sebuah bilangan dan
                    menentukan apakah bilangan tersebut adalah bilangan
                    ganjil atau genap.

Contoh Input    =   1.) 5
                    2.) 16
                    
Contoh Output   =   1.) Ganjil
                    2.) Genap
*/