using System;

namespace EvaluasiNo5
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Bab 3 - Evaluasi nomor 5
            Soal : Berpakah nilai x setelah kumpulan statement ini
            dijalankan?
            a = 5;
            b = -- a + 4;
            x = a + b; 
            */

            int a, b, x;
            a = 5;
            b = -- a + 4;
            x = a + b;

            Console.Write("x = {0}", x);
        }
    }
}