using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetodDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad+" "+ musteri.Soyad+ " Müşteri olarak eklendi...");
            
        }
        public void Listele(Musteri musteri)
        {
           
            Console.WriteLine(musteri.Id+" "+musteri.Ad+" "+ musteri.Soyad);
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Silme İşlemi");
            Console.WriteLine(musteri.Ad + " " + musteri.Soyad + " Müşterisi silindi...");
        }

    }
}
