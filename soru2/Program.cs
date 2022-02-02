using System;

namespace soru2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m).
            //Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.
            //Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.

            
            Console.Write("Birinci sayıyı giriniz: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("İkinci sayıyı giriniz: ");
            int m = int.Parse(Console.ReadLine());

            Console.WriteLine("{0} adet pozitif sayı giriniz", n);
            int[] sayiDizisi = new int[n];

             for (int i = 0; i < n; i++)
            {
                Console.Write("{0}. sayıyı giriniz: ", i + 1);
                sayiDizisi[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("{0}'e eşit ya da tam bölünen sayılar şunlardır: ",m);
            foreach (var sayi in sayiDizisi)
            {
                if(sayi ==m || sayi%m==0)
                    Console.WriteLine(sayi);
                
            }
        }
    }
}
