using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratik_Patika_Kütüphane
{
    //Kitap adında bir class tanımlıyoruz.
    public class Kitap
    {
        // Properties
        public string KitapAdi { get; set; }
        public string YazarAdi { get; set; }
        public string YazarSoyadi { get; set; }
        public string Yayinevi { get; set; }
        public DateTime KayitTarihi { get; set; }

        private int _sayfaSayisi;

        public int SayfaSayisi
        {
            get { return _sayfaSayisi; }

            set 
            {
                if (value < 0)
                    throw new Exception("Sayfa sayısı negatif olamaz");
                _sayfaSayisi = value; 
            }
        }

        //Default Consturctor - Parametre almayan.
        public Kitap()
        {
            KitapAdi = "Adı Aylin";
            YazarAdi = "Ayşe";
            YazarSoyadi = "Kulin";
            SayfaSayisi = 398;
            Yayinevi = "Remzi Kitabevi";
            KayitTarihi = DateTime.Now; // Oluşturulma anındaki tarih
            Console.WriteLine($"Yeni kitap kaydedildi: {KitapAdi}");
        }

        // Parametre alan Constructor
        public Kitap(string kitapAdi, string yazarAdi, string yazarSoyadi, string yayinevi, int sayfaSayisi)
        {
            KitapAdi = kitapAdi;
            YazarAdi = yazarAdi;
            YazarSoyadi = yazarSoyadi;
            Yayinevi = yayinevi;
            KayitTarihi = DateTime.Now; // Oluşturulma anındaki tarih
            SayfaSayisi = sayfaSayisi;
            
        }
        // Kitap bilgilerini ekrana yazdıran bir metot

        public void BilgileriGoster()
        {
            Console.WriteLine($" Kitap Adı: {KitapAdi} \n Yazar Adı: {YazarAdi} \n Sayfa Sayısı: {SayfaSayisi} \n " +
                $"Yayınevi: {Yayinevi} \n Kayıt Tarihi: {KayitTarihi}");
        }
    }
}
