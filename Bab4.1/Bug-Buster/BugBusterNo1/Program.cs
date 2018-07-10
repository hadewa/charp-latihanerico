using System;

namespace BugBusterNo1
{
    class Program
    {
        static void Main(string[] args)
        {
            float myFloat;
            int myInteger;
            string input;

            input = Console.ReadLine();
            int.TryParse(input, out myInteger);

            input = Console.ReadLine();
            float.TryParse(input, out myFloat);

            Console.Write("myFloat = {0}", myFloat);
            Console.Write("\nmyInteger = {0}\n", myInteger + 3);
        }
    }
}
/* Bab 4 - Bug Buster nomor 1
1.) Baris ke-10, penulisan titik-koma (: seharusnya ;).
2.) Baris ke-13, penulisan Console.ReadLine (Console.WriteLine seharusnya Console.ReadLine).
3.) Baris ke-14, tidak sinkron (myFloat seharusnya myInteger)
4.) Baris ke-17, tidak sinkron (muInteger seharusnya myFloat)
5.) Baris ke-19, penulisan simbol "&" (&myFloat seharusnya myFloat) 
*/
