
using Pratik_Patika_Kütüphane;

// Default constructor ile nesne oluşturma

Kitap kitap1 = new Kitap();
kitap1.BilgileriGoster();

Console.WriteLine("--------------------");

// Parametreli constructor ile nesne oluşturma

Kitap kitap2 = new Kitap("Adı Aylin", "Ayşe", "Kulin", "Remzi Kitabevi", 398);
kitap2 .BilgileriGoster();
