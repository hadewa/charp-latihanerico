using System;

namespace Bug_Buster
{
    class Program
    {
        static void Main(string[] args)
        {
            int bilangan;

            // Ini komentar lho..
            bilangan = 5;

            /* Ini juka komentar lhi.. */
            Console.Write("{0}", bilangan);
        }
    }
    /* Bab 2 - Bug Buster
    Kesalahan :
    1.) Penulisan kurawal pada baris 8 dan 16 (< > seharusnya { }).
    2.) Penulisan pendeklarasian pada baris 9 (integer seharusnya int).
    3.) Penulisan garis miring pada baris 11 (\\ seharusnya //)
    4.) Penulisan tanda pada akhir komentar pada baris 14 (/* seharusnya * /).
    */
    
}