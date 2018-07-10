using System;

namespace EvaluasiNo3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Bab 3 - Evaluasi nomor 3
            Soal : Jika nilai A = 10, apakah isi variabel C dan A setelah statement C= A++ - 3;
            dijalankan? 
            */

            int A, C;

            A = 10;
            C = A++ - 3;

            Console.Write("C = {0}\nA = {0}", C, A);
        }
    }
}