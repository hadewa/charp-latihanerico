using System;

namespace Programming3
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, c;
            char q, w, e, r, t;
            string input;

            q = '+';
            w = '-';
            e = '*';
            r = '/';

            Console.Write ("Program kalkulator sederhana v1.1\n\nMasukkan input:\n");

            input = Console.ReadLine();
            float.TryParse(input, out a);

            input = Console.ReadLine();
            char.TryParse(input, out t);

            input = Console.ReadLine();
            float.TryParse(input, out b);
            
            if (t == q)
                Console.Write("{0}\n", a+b);
            else if (t == w)
                Console.Write("{0}\n", a-b);
            else if (t == e)
                Console.Write("{0}\n", a*b);
            else if (t == r)
            {    
                c = a/b;
                if (b <= 0)
                    {
                        Console.Write("Semua bilangan tidak dapat dibagi dengan 0\n");
                    }
                else
                    {
                        Console.Write("{0}\n", c);
                    }
            }
            else
                Console.Write("Tidak ada operator {0}.\n", t);
        }
    }
}
/* Bab5 - Programming nomor 3
Tugas           :   Buatlah program kalkulator sederhana yang meminta 2
                    buah nilai dan sebuah operator, kemudian tampilkan
                    hasilnya ke layar. Operator yang dapat dipakai adalah
                    +, -, *, dan /. 
                
Contoh Input    :   1.) 5.3                         3.) 5
                        -                               ^
                        2                               2

                    2.) 5                           4.) 0
                        /                               /
                        0                               5

Contoh Output   :   1.) 3.3                         3.) Tidak ada operator ^ 
                    
                    2.) Semua bilangan tidak        4.) 0
                        dapat dibagi dengan 0.
*/