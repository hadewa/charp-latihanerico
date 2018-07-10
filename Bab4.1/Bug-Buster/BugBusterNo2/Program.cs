using System;

namespace BugBusterNo2
{
    class Program
    {
        static void Main(string[] args)
        {
            int variabelInteger;
            string input;

            Console.Write("Masukkan sebuah bilangan bulat : ");
            input = Console.ReadLine();
            int.TryParse(input, out variabelInteger);

            Console.Write("Bilangan yang diberikan adalah {0}", variabelInteger);
        }
    }
}
/* Bab 4 - Bug Buster nomor 2
1.) Baris ke-12, penulisan menampilkan output (Console.ReadLine seharusnya Console.Write).
2.) Baris ke-14, penulisan yang terbalik (int.TryParse seharusnya ditempatkan di awal).
3.) Baris ke-14, tidak ada operator '=' di dalam operasi .TryParse
4.) Baris ke-16, syntax untuk menampilkan ke layar (' seharusnya "). 
*/