using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Proglamaya başlangıç için temel kurs";
            string kurs3 = "Java";
            string kurs4 = "Python";

            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);
            Console.WriteLine(kurs4);

            //array - dizi       //yukardakinde iki kere yazıyoruz.ama dizide 21.satıra eklemen yeterli.

            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", "Proglamaya başlangıç için temel kurs", "Java", "Python", "C#" };

            for (int i = 0; i <kurslar.Length; i++) //kaç kurs var sonradan  3 mü olur 5 mi olur bielemyiz.dinamik olması için kurslar.Length ekledik
            {                                       //length- kurs sayısı.
                Console.WriteLine(kurslar[i]);  // c.w(i); dersen 0,1,2 yazar.ama ben kursların i. elemanını yazdrmak istyorum.
            }

            Console.WriteLine("For bitti");

            foreach (string kurs in kurslar)   //yukardaki for yerine foreach te kullanablirsin.for daha genel kullanılır.each dizileri daha kolay dolaşmak için.
            {
                Console.WriteLine(kurs); //her bir eleman için kurs takma adını kullanıyor.sen istedini diyeblrsin.
            }

            Console.WriteLine("sayfa sonu - footer");
        }


        
    }
}
