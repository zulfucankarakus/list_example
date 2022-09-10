using System;
using System.Collections.Generic;
using System.Text;

namespace ListeOrnekleri
{
    class Ogrenci
    {
        public string Ad { get; set; }
        public int No { get; set; }
        public SUBE Subesi { get; set; }
        public int Not { get; set; }
        public int Yas { get; set; }
        public CINSIYET Cinsiyet { get; set; }
        public ALAN Alan { get; set; }


        public Ogrenci()
        {

        }
        public Ogrenci(int no, string ad, SUBE sube, int not,int yas,CINSIYET cinsiyet,ALAN alan)
        {
            this.No = no;
            this.Ad = ad;
            this.Subesi = sube;
            this.Not = not;
            this.Yas = yas;
            this.Cinsiyet = cinsiyet;
            this.Alan = alan;
        }

    }


    public enum ALAN
    {
        Sayisal, 
        Sozel,
        EsitAgirlik
    }
    public enum CINSIYET
    {
        Kiz, 
        Erkek
    }

    public enum SUBE
    {
        A,
        B,
        C,
        D
    }


}
