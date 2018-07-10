using System;

namespace EvaluasiNo6
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Bab 3 - Evaluasi nomor 6
            Soal : Berapakah nilai varibel a, b, c,dan d setelah kumpulan
            statement ini dijalankan?
            float a, b, c;
            int d;
            
            a = 1+3*5;
            b = --a/3;
            c = a-b;
            d = (c+2)/2; 
            */

            float a, b, c;
            int d;

            a = 1+3*5;
            b = --a/3;
            c = a - b;
            d = 2/2;

            Console.Write("a = {.0#}\nb = {.1#}\nc = {.2#}\nd = {3}", a, b, c, d);
        }
    }
}