using System;

namespace ClassMetotDemo
    {
        class Program
        {
            static void Main(string[] args)
            {
                Musteri musteri = new Musteri();
                musteri.isim = "Deren";
                musteri.soyisim = "Karabulak";
                musteri.yas = 19;
                musteri.Id = 25465;

                Musteri musteri2 = new Musteri();
                musteri2.isim = "Henry";
                musteri2.soyisim = "Cavill";
                musteri2.yas = 37;
                musteri2.Id = 19854;

                Musteri musteri3 = new Musteri();
                musteri3.isim = "Fiona";
                musteri3.soyisim = "Gallagher";
                musteri3.yas = 28;
                musteri3.Id = 45456;

                Musteri[] musteriler = new Musteri[] { musteri, musteri2, musteri3 };

                foreach (var x in musteriler)
                {
                    Console.WriteLine("İsim : " + x.isim + "\n" + "Soyisim : " + x.soyisim + "\n" + "Yaş : " + x.yas + "\n" + "Id : " + x.Id + "\n");
                    Console.WriteLine("---------------------");
                }

                MusteriManager musterimanager = new MusteriManager();
                musterimanager.Add(musteri);
                musterimanager.Cancel(musteri);
                musterimanager.List(musteri);

                musterimanager.Add(musteri2);
                musterimanager.Cancel(musteri2);
                musterimanager.List(musteri2);

                musterimanager.Add(musteri3);
                musterimanager.Cancel(musteri3);
                musterimanager.List(musteri3);


            }
        }
    }

