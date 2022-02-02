using System;

namespace soru3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n).
            //Sonrasında kullanıcıdan n adet kelime girmesi isteyin.
            //Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.

            Console.Write("Bir pozitif sayı giriniz: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("{0} adet pozitif kelime giriniz", n);
            string[] kelimeDizisi = new string[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("{0}. kelimeyi giriniz: ", i + 1);
                kelimeDizisi[i] = Console.ReadLine();
            }

            Array.Reverse(kelimeDizisi);
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0}, ",kelimeDizisi[i]);
            }

        }
    }
}
