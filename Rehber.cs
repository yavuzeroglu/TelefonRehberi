using System;
using System.Collections.Generic;

namespace Telefon_Rehberi 
{
    public class Rehber {
        List<Kartvizit> kartvizits = new List<Kartvizit>();

        public Rehber(){
            kartvizits.Add(new Kartvizit("Acil","Yardim","112"));
            kartvizits.Add(new Kartvizit("Yangın","Yardim","110"));
            kartvizits.Add(new Kartvizit("Polis","Yardim","155"));
            kartvizits.Add(new Kartvizit("Jandarma","Yardim","156"));
            kartvizits.Add(new Kartvizit("Orman","Yangını","177"));
        }

        public void Kayit(){
            Kartvizit kart1 = new Kartvizit();
            Console.WriteLine("(1) Yeni Numara Kaydetmek");
            Console.WriteLine("Lütfen isim giriniz :");
            kart1.Ad = Console.ReadLine();
            Console.WriteLine("Lütfen soyisim giriniz :");
            kart1.Soyad = Console.ReadLine();
            Console.WriteLine("Lütfen telefon numarası giriniz :");
            kart1.TelefonNumarasi = Console.ReadLine();

            kartvizits.Add(kart1);

        }

        public void Silmek(){
            string isimsoyisim;
            int silmeyeDevam =2;
            while (silmeyeDevam == 2 )
            {
                Console.WriteLine(" Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
                isimsoyisim = Console.ReadLine();
                foreach (var item in kartvizits)
                {
                    if ((kartvizits.IndexOf(item)==kartvizits.Count -1 && !(isimsoyisim.ToLower()==item.Ad.ToLower() || isimsoyisim.ToLower() == item.Soyad.ToLower()))){
                        Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                        Console.WriteLine
                        ("Silmeyi Sonlandırmak için : (1)");
                        Console.WriteLine
                        ("Yeniden denemek için      : (2)");
                        silmeyeDevam = Convert.ToInt32(Console.ReadLine());
                    }
                    else if(isimsoyisim.ToLower()== item.Ad.ToLower() 
                    || isimsoyisim.ToLower() == item.Soyad.ToLower()){
                       Console.WriteLine("{0} {1} : {2} kişi rehberden silinmek üzere onaylıyor musunuz ? (y/n)",item.Ad,item.Soyad,item.TelefonNumarasi);

                       if(Convert.ToChar(Console.ReadLine()) == 'y'){
                        Console.WriteLine("{0} {1} : {2} kişi silindi.",item.Ad,item.Soyad,item.TelefonNumarasi);
                        kartvizits.RemoveAt(kartvizits.IndexOf(item));
                        silmeyeDevam =1;
                        break;
                       } 
                       else{
                        continue;
                       }
                       
                    }
                }


            }

            
            

        }
        public void Guncelleme()
        {
            Console.WriteLine("Güncelleme");
            string isimsoyisim;
            int guncellemeyeDevam = 2; 
            while(guncellemeyeDevam == 2) {
                Console.WriteLine("Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz :");
                isimsoyisim = Console.ReadLine();

                foreach (var item in kartvizits)
                {
                    if(kartvizits.IndexOf(item) == kartvizits.Count-1 &&!(isimsoyisim.ToLower()== item.Ad.ToLower() || isimsoyisim.ToLower()==item.Soyad.ToLower())){
                        Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                        Console.WriteLine
                        ("Güncellemeyi sonlandırmak için    : (1)");
                        Console.WriteLine
                        ("Yeniden denemek için              : (2)");
                        guncellemeyeDevam = Convert.ToInt32(Console.ReadLine());

                    }
                    else if (isimsoyisim.ToLower() == item.Ad.ToLower() || isimsoyisim.ToLower() == item.Soyad.ToLower()){
                        Console.WriteLine("{0} {1} : {2} kişinin bilgileri güncellenmek üzere, onaylıyor musunuz ? (y/n)",item.Ad,item.Soyad,item.TelefonNumarasi);

                        if(Convert.ToChar(Console.ReadLine()) == 'y') {
                            Console.WriteLine
                                ("Lütfen isim giriniz :");
                            item.Ad = Console.ReadLine();
                            Console.WriteLine
                                ("Lütfen soyisim giriniz :");
                            item.Soyad = Console.ReadLine();
                            Console.WriteLine
                                ("Lüfen yeni numarayı giriniz :");    
                            item.TelefonNumarasi = Console.ReadLine();

                            Console.WriteLine("{0} {1} :{2} kişi olarak güncellendi.");

                            guncellemeyeDevam = 1;
                            break;
                        }
                        else{
                            continue;
                        }

                    }

                    }
                }
            }

            public void Listeleme(){
                
                Console.WriteLine("Telefon Rehberi");
                Console.WriteLine("**********************");
                foreach (var item in kartvizits)
                {
                    Console.WriteLine("isim : "+item.Ad);
                    Console.WriteLine("soyisim :"+item.Soyad);
                    Console.WriteLine("Telefon Numarası :"+item.TelefonNumarasi);
                }
            }

            public void Arama(){
                Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
                Console.WriteLine("*************************");
                Console.WriteLine("Isim veya soyisime göre arama yapmak için: (1)");
                Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");
                int aramaTipi = Convert.ToInt32(Console.ReadLine());

                if(aramaTipi == 1) {
                    Console.WriteLine("İsim veya Soyisim Giriniz : ");
                    string isimsoyisim = Console.ReadLine();

                    foreach (var item in kartvizits)
                    {
                        if((kartvizits.IndexOf(item) == kartvizits.Count -1) && !(isimsoyisim.ToLower()== item.Ad.ToLower() || isimsoyisim.ToLower() == item.Soyad.ToLower()))
                        {
                            if(!kartvizits.Contains(item)){
                                Console.WriteLine("aradığınız krtiterlere uygun veri rehberde bulunamadı.");
                            }
                        }
                        else if (isimsoyisim.ToLower() == item.Ad.ToLower() || isimsoyisim.ToLower() == item.Soyad.ToLower()){
                            Console.WriteLine("İsim : {0}",item.Ad);
                            Console.WriteLine("Soyisim : {0}",item.Soyad);
                            Console.WriteLine("Telefon Numarası : {0}",item.TelefonNumarasi);
                        }
                    }
                }
                else if (aramaTipi == 2)
                {
                    Console.WriteLine("Arama yapmak için telefon numarası giriniz: ");
                    string telno = Console.ReadLine();

                    foreach (var item in kartvizits)
                    {
                        if((kartvizits.IndexOf(item) == kartvizits.Count - 1 ) && !(telno.ToLower() == item.TelefonNumarasi.ToLower()))
                        {
                            if(!kartvizits.Contains(item)){
                                Console.WriteLine("aradığınız krtiterlere uygun veri rehberde bulunamadı");
                            } 
                        }
                    }
                }

            }

        }

    }
    
