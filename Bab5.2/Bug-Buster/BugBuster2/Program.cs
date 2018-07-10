using System;

namespace BugBuster2
{
    class Program
    {
        static void Main(string[] args)
        {
            int bil = 3;

            if(bil % 2 == 0)
                Console.Write("{0}\n", bil = bil + 1);
            else
                Console.Write("{0}\n", bil = bil + 2);

            switch(bil - 2)
            {
                case 1: Console.Write("{0}\n", bil = bil*1);
                break;
                case 2: Console.Write("{0}\n", bil = bil*2);
                break;
                case 3: Console.Write("{0}\n", bil = bil*3);
                break;
                default: Console.Write("{0}\n", bil = bil*0);
                break;
            }
        }
    }
}
/* Bab 5 Bug Buster nomor 2
1.) Baris ke-12, menambahkan perintah untuk menampilkan output.
2.) Baris ke-14, menambahkan perintah untuk menampilkan output.
3.) Baris ke-18, menambahkan perintah untuk menampilkan output.
4.) Baris ke-19, menambahkan perintah break; (setiap case harus diberi perintah break;).
5.) Baris ke-20, menambahkan perintah untuk menampilkan output.
6.) Baris ke-21, menambahkan perintah break; (setiap case harus diberi perintah break;).
7.) Baris ke-22, menambahkan perintah untuk menampilkan output.
8.) Baris ke-23, menambahkan perintah break; (setiap case harus diberi perintah break;).
9.) Baris ke-24, menambahkan perintah untuk menampilkan output.
10.) Baris ke-25, menambahkan perintah break; (setiap case harus diberi perintah break;).
*/