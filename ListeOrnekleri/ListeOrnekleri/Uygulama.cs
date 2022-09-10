using System;
using System.Collections.Generic;
using System.Linq;

namespace ListeOrnekleri
{
    class Uygulama
    {
        public void Calistir()
        {
            List<Ogrenci> ogrenciler = new List<Ogrenci>();

            Ogrenci o1 = new Ogrenci(1, "Naz", SUBE.A, 10, 20, CINSIYET.Kiz, ALAN.Sayisal);
            ogrenciler.Add(o1);
            ogrenciler.Add(new Ogrenci(2, "Elif", SUBE.A, 45, 25, CINSIYET.Kiz, ALAN.Sozel));
            ogrenciler.Add(new Ogrenci(3, "Busra", SUBE.B, 56, 30, CINSIYET.Kiz, ALAN.EsitAgirlik));
            ogrenciler.Add(new Ogrenci(4, "Hakan", SUBE.B, 67, 35, CINSIYET.Erkek, ALAN.Sozel));
            ogrenciler.Add(new Ogrenci(5, "Ahmet", SUBE.B, 89, 40, CINSIYET.Erkek, ALAN.Sayisal));
            ogrenciler.Add(new Ogrenci(6, "Mehmet", SUBE.C, 23, 45, CINSIYET.Erkek, ALAN.EsitAgirlik));
            ogrenciler.Add(new Ogrenci(7, "Beril", SUBE.C, 74, 50, CINSIYET.Kiz, ALAN.Sozel));
            ogrenciler.Add(new Ogrenci(8, "Nurgül", SUBE.D, 56, 55, CINSIYET.Kiz, ALAN.EsitAgirlik));
            ogrenciler.Add(new Ogrenci(9, "Burak", SUBE.D, 63, 21, CINSIYET.Erkek, ALAN.Sayisal));
            ogrenciler.Add(new Ogrenci(10, "Eren", SUBE.D, 11, 33, CINSIYET.Erkek, ALAN.Sayisal));
            ogrenciler.Add(new Ogrenci(11, "Sarp", SUBE.D, 65, 23, CINSIYET.Erkek, ALAN.EsitAgirlik));
            ogrenciler.Add(new Ogrenci(12, "Osman", SUBE.A, 77, 18, CINSIYET.Erkek, ALAN.Sozel));
            ogrenciler.Add(new Ogrenci(13, "Halit", SUBE.B, 55, 35, CINSIYET.Erkek, ALAN.Sayisal));
            ogrenciler.Add(new Ogrenci(14, "Berke", SUBE.C, 35, 43, CINSIYET.Erkek, ALAN.Sozel));
            ogrenciler.Add(new Ogrenci(15, "Aslı", SUBE.A, 43, 26, CINSIYET.Kiz, ALAN.Sayisal));
            ogrenciler.Add(new Ogrenci(16, "Selim", SUBE.D, 71, 19, CINSIYET.Erkek, ALAN.Sozel));
            ogrenciler.Add(new Ogrenci(17, "Melek", SUBE.D, 62, 24, CINSIYET.Kiz, ALAN.EsitAgirlik));
            ogrenciler.Add(new Ogrenci(18, "Derya", SUBE.C, 75, 31, CINSIYET.Kiz, ALAN.EsitAgirlik));
            ogrenciler.Add(new Ogrenci(19, "Melis", SUBE.B, 40, 42, CINSIYET.Kiz, ALAN.Sayisal));
            ogrenciler.Add(new Ogrenci(20, "Melda", SUBE.B, 90, 22, CINSIYET.Kiz, ALAN.EsitAgirlik));
            ogrenciler.Add(new Ogrenci(21, "Onur", SUBE.C, 68, 17, CINSIYET.Erkek, ALAN.Sozel));
            ogrenciler.Add(new Ogrenci(22, "Fatih", SUBE.D, 73, 27, CINSIYET.Erkek, ALAN.Sayisal));
            ogrenciler.Add(new Ogrenci(23, "Salih", SUBE.D, 81, 39, CINSIYET.Erkek, ALAN.EsitAgirlik));
            ogrenciler.Add(new Ogrenci(24, "Çağan", SUBE.A, 87, 38, CINSIYET.Erkek, ALAN.Sozel));
            ogrenciler.Add(new Ogrenci(25, "Emre", SUBE.B, 75, 25, CINSIYET.Erkek, ALAN.EsitAgirlik));
            ogrenciler.Add(new Ogrenci(26, "Ufak", SUBE.C, 79, 20, CINSIYET.Erkek, ALAN.Sayisal));

        }

        public void ListeYazdir(List<Ogrenci> liste)
        {
            Console.WriteLine("No".PadRight(5) + "Ad".PadRight(10) + "Yas".ToString().PadRight(5) + "Cinsiyet".ToString().PadRight(10)
                + "Sube".PadRight(5) + "Not".PadRight(5) + "Alan");
            Console.WriteLine("".PadRight(52, '-'));

            foreach (Ogrenci item in liste)
            {
                Console.WriteLine(item.No.ToString().PadRight(5) + item.Ad.PadRight(10) + item.Yas.ToString().PadRight(5) + item.Cinsiyet.ToString().PadRight(10)
                    + item.Subesi.ToString().PadRight(5) + item.Not.ToString().PadRight(5) + item.Alan);
            }
        }
    }
}

