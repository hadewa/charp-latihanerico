using System;

namespace Programming2
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

            if(a % 400 == 0)
                    Console.Write("Kabisat\n");
            else if((a % 400 != 0) && (a % 100 == 0))
                    Console.Write("Bukan Kabisat\n");
            else if((a % 400 != 0) && (a % 100 != 0))
                { 
                    if(a%4 == 0)
                        Console.Write("Kabisat\n");
                }
            else if((a % 400 != 0) && (a % 100 != 0))
                {
                    if(a % 4 != 0)
                        Console.Write("Bukan Kabisat\n");
                }
        }
    }
}
/* Bab 5 - Programming nomor 2
Tugas           :   Buatlah program untuk menentukan apakah tahun yang
                    dimasukkan adalah tahun kabisat atau bukan. Tahun
                    kabisat adalah tahun yang habis dibagi 4, tetapi
                    tidak habis dibagi 100 kecuali kelipatan 400.

Contoh Input    :   1.) 1999
                    2.) 1900
                    3.) 1616
                    4.) 1600

Contoh Output   :   1.) Bukan kabisat
                    2.) Bukan kabisat
                    3.) Kabisat
                    4.) Kabisat 

Kelemahan       :   Tidak bisa mengeluarkan input tahun 1999
*/