using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Add(Musteri musteri)
        {
            Console.WriteLine("İsim : " + musteri.isim + "\n" + "Soyisim : " + musteri.soyisim + "\n" + "Yaş : " + musteri.yas + "\n" + "Id : " + musteri.Id + "\n" + "Müşteri eklendi.");
            Console.WriteLine("---------------------");
        }

        public void Cancel(Musteri musteri)
        {
            Console.WriteLine("İsim : " + musteri.isim + "\n" + "Soyisim : " + musteri.soyisim + "\n" + "Yaş : " + musteri.yas + "\n" + "Id : " + musteri.Id + "\n" + "Müşteri çıkarıldı.");
            Console.WriteLine("---------------------");
        }

        public void List(Musteri musteri)
        {
            Console.WriteLine("İsim : " + musteri.isim + " ");
            Console.WriteLine("Soyisim : " + musteri.soyisim + " ");
            Console.WriteLine("Yaş : " + musteri.yas + " ");
            Console.WriteLine("Id : " + musteri.Id + " ");
            Console.WriteLine("---------------------");
        }
    }
}

