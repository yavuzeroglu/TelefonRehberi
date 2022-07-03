using System;

namespace Telefon_Rehberi {
    internal class Program
    {
        static void Main(string[] args)
        {
            


            Rehber rehber = new();

            string program = "";
            while (program != "cikis")
            {
                Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :) \nProgramdan Çıkış için 'çıkış' giriniz");
                Console.WriteLine("********************");
                Console.WriteLine("(1) Yeni Numara Kaydetmek");
                Console.WriteLine("(2) Varolan Numarayı Silmek");
                Console.WriteLine("(3) Varolan Numarayı Güncelleme");
                Console.WriteLine("(4) Rehberi Listelemek");
                Console.WriteLine("(5) Rehberde Arama Yapmak");

                program = Console.ReadLine();

                switch(program) {
                    case "1":
                        rehber.Kayit();
                        break;
                    case "2":
                        rehber.Silmek();
                        break;
                    case "3":
                        rehber.Guncelleme();
                        break;
                    case "4":
                        rehber.Listeleme();
                        break;
                    case "5":
                        rehber.Arama();
                        break;
                    case "çıkış": 
                        break;
                    default : Console.WriteLine("1-5 arası bir işlem seçiniz veya çıkış ile çıkınız.");
                    break;
                    
                }
            }

        }
    }
}