using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //naming covention
        //syntax
        public void Ekle(Urun urun)  //buraya urun paramtrsi ekleyince program.cs de de (urun1) gibi urun paramestresiyle çağırman gerek.()çağırırsan hata verir.
        {
            Console.WriteLine("Tebrikler.Sepete eklendi! : " + urun.Adi); //başına tebrikler koyarsan burda tüm sayfalarda ekler bunu.urunadi nida sonradan ekledik.
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Tebrikler.Sepete eklendi! : " + urunAdi);
        }
    }
}
