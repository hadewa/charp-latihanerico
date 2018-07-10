using System;

namespace BugBuster1
{
    class Program
    {
        static void Main(string[] args)
        {
            int bil1, bil2, bil3;

            bil1 = 3;
            bil2 = -1;
            bil3 =  20;

            if(bil1 >= 1)
            {
                bil2 = bil1 * 2;
                bil3 = bil2 / bil1;
                Console.Write("{0} {1} {2}", bil1, bil2, bil3);
            }
            else if(bil2 < 0)
            {
                bil2++;
                bil3++;
                Console.Write("{0} {1} {2}", bil1, bil2, bil3);
            }
            else if(bil3 < 10)
            {
                bil3 = bil2 + 1;
                bil2 = bil3 - 2;
                Console.Write("{0} {1} {2}", bil1, bil2, bil3);
            }
            else
            bil3 = 0;
        }
    }
}
/* Bab 5 - Bug Buster nomor 1
1.) Baris ke-9, diakhir perintah seharusnya menggunakan titik-koma.
2.) Baris ke-12, menambahkan isi variabel bil2.
3.) Baris ke-13, menambahkan isi variabel bil3.
4.) Baris ke-18, diakhir perintah mengganti l menjadi titik-koma.
5.) Baris ke-19, menambahkan perintah untuk menampilkan output.
6.) Baris ke-21, mengganti if() menjadi else if().
7.) Baris ke-22, menambahkan kurawal buka. 
8.) Baris ke-25, menambahkan perintah untuk menampilkan output.
9.) Baris ke-26, menambahkan kurawal tutup.
10.) Baris ke-27, mengganti if() menjadi else if().
11.) Baris ke-28, menambahkan kurawal hidup.
12.) Baris ke-30, varibel bil 3 seharusnya variabel bil3.
13.) Baris ke-31, menambahkan perintah untuk menampilkan output.
*/