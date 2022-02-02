using System;

namespace soru4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin.
            //Cümledeki toplam kelime ve harf sayısını console'a yazdırın.

            Console.Write("Bir cümle yazınız: ");
            string text = Console.ReadLine();

            string[] textSplit = text.Split(" ");
            char[] harfler = text.ToCharArray();
            Console.WriteLine("Cümle içindeki kelime sayısı: "+textSplit.Length);
            Console.WriteLine("Cümle içindeki harf sayısı: "+harfler.Length);

            

            foreach (var item in textSplit)
            {
                Console.WriteLine("Cümle içindeki kelimeler: "+item);
                
            }
            foreach (var harf in harfler)
            {
                Console.Write(" ,"+harf);
            }

        }
    }
}
