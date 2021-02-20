using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun(); //str veri tipinde nasıl urunadı vs yazıyorsan burda da urun tipinde urun1 gibi düşün.ve burda yanına new de ekliyoruz.
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            //type-safe -- tip güvenli
            foreach (Urun urun in urunler) //ilk urun veri tipi ikincisi takma ad(istedini vereblrsin) ilk Urun yerine var da yazsan o arka planda  Urun yapar onu.üstüne gelince göreblrsin.
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati); 
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-------------------------");
            }

            Console.WriteLine("-----------------------Metotlar----------------------"); //cw tab tab la hızlı yazarsın.ayrıca tab ve enterle geçişi unutma.

            //instance - örnek 
            //encapsulation  - urun.cs de yeni özellik ekleyince class old. için hiçbir satırım patlamadı.

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil armut", 12, 10);
            sepetManager.Ekle2("Elma", "Yeşil elma", 12, 9);
            sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 12, 8);
        }
    }
}


//Dont repeat yourself - DRY - Clean Code - Best Practice(en iyi uyg. teknikleri)