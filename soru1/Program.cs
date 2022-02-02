using System;

namespace odev1_algoritma_soruları
{
    class Program
    {
        static void Main(string[] args)
        {

            //Soru 1: Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). 
            //Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
            //Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.

            Console.Write("Bir pozitif sayı giriniz: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("{0} adet pozitif sayı giriniz", n);
            int[] sayiDizisi = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("{0}. sayıyı giriniz: ", i + 1);
                sayiDizisi[i] = int.Parse(Console.ReadLine());
            }
            //int[] ciftSayilar= new int[n];
            foreach (var sayi in sayiDizisi)
            {
                if (sayi % 2 == 0)
                    Console.WriteLine(sayi);
            }


        }
    }

}
