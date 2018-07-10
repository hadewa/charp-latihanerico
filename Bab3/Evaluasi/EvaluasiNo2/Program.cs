using System;

namespace EvaluasiNo2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Bab 3 - Evaluasi nomor 2
            Soal : Apakah perbedaan antara B++ dan ++B? 
            */
            
            int B, x, y;
            B = 5;
            x = B++;
            y = ++B;
            Console.Write("B++ = {0}\n++B = {0}", x, y );
        }
    }
}
