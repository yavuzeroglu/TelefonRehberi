using System;

namespace Telefon_Rehberi {
    public class Kartvizit{
        string ad;
        string soyad;
        string telefonNumarasi;

        public string Ad { get => ad; set => ad = value; }
        public string Soyad { get => soyad; set => soyad = value; }

       public string TelefonNumarasi { get => telefonNumarasi; set => telefonNumarasi = value; }

        public Kartvizit(string ad, string soyad, string telefonNumarasi)
        {
            Ad = ad;
            Soyad = soyad;
            TelefonNumarasi = telefonNumarasi;
        }

        public Kartvizit()
        {}

    }
}