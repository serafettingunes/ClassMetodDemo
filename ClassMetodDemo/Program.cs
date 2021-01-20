using System;

namespace ClassMetodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int kayit = 0;
            Musteri musteri = new Musteri();
            musteri.Ad = "Ali";
            musteri.Soyad = "Yılmaz";
            musteri.Id = 1;

            Musteri musteri2 = new Musteri();
            musteri2.Ad = "Can";
            musteri2.Soyad = "Kaan";
            musteri2.Id = 2;
            Console.WriteLine("Seçmek istediğiniz işlemin numarasına  basınız!");
            Console.WriteLine("1 Müşteri Ekleme");
            Console.WriteLine("2 Müşteri Listeleme");
            Console.WriteLine("3 Müşteri Silme");
            MusteriManager musteriManager = new MusteriManager();
        git:
            int x = Convert.ToInt32(Console.ReadLine());
            if (x < 1 && x > 3)
            {
                goto git;
            }
            else
            {
                if (x == 1)
                {
                    kayit = 1;
                    musteriManager.Ekle(musteri);
                    musteriManager.Ekle(musteri2);
                }
                else if (x == 2 && kayit == 1)
                {
                    Console.WriteLine("Listeleme ");
                    musteriManager.Listele(musteri);
                    musteriManager.Listele(musteri2);
                }
                else if (x == 3&& kayit==1)
                {
                    musteriManager.Sil(musteri);
                    musteriManager.Sil(musteri2);
                    kayit = 0;
                }
                goto git;
            }



        }
    }
}
