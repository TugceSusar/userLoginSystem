using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace örnek_uygulama
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Ogrenci> Oliste = new List<Ogrenci>()
            {
                new Ogrenci() {Ad = "Enes", Soyad= " Cakir", Tc=89765432103, Cinsiyet= 'E', Yas= 28, CalismaDurumu= true, Username= "enes", Password= "cakir"},
                new Ogrenci() {Ad = "Bugra", Soyad="Coskun", Tc=96325874112, Cinsiyet= 'E', Yas= 28, CalismaDurumu= true, Username= "bugra", Password= "coskun"},
                new Ogrenci() {Ad = "Senay", Soyad="Susar", Tc=96325874113, Cinsiyet= 'K', Yas= 22, CalismaDurumu= true, Username= "senay", Password= "susar"},
                new Ogrenci() {Ad = "Taner", Soyad="Susar", Tc=96325874114,  Cinsiyet= 'E', Yas= 32, CalismaDurumu= true,Username="taner", Password= "susar"},
                new Ogrenci() {Ad = "Tugce", Soyad="Susar Cakir", Tc=96325874115,  Cinsiyet= 'K', Yas= 28, CalismaDurumu = false, Username= "tugce", Password = "susarcakir"},
            };
            int hak = 3;
            hak--;
            Console.WriteLine("**************");
            Console.WriteLine("--------KULLANICI GİRİŞ SİSTEMİ---------");
            Console.WriteLine("**************");
            Console.WriteLine("Kullanıcı Adını Giriniz");
            string username = Console.ReadLine();


            foreach (Ogrenci item1 in Oliste)
            {

                if (item1.Username == username)
                {
                    Console.WriteLine("Kullanıcı adı doğru");
                    Console.ReadLine();
                    Console.Clear();

                    Console.WriteLine("Password giriniz");
                    string password = Console.ReadLine();


                    if (item1.Password == password)
                    {
                        Console.WriteLine("Parola Doğru");


                        bool durum = true;
                        while (durum)
                        {
                            menu:
                            Console.WriteLine("**************");
                            Console.WriteLine("--------KULLANICI GİRİŞ SİSTEMİ---------");
                            Console.WriteLine("**************");
                            Console.WriteLine("--------İŞLEM SEÇİNİZ---------");


                            Console.WriteLine("Kullanıcı Ekle\t[1]");
                            Console.WriteLine("Kullanıcı Listele\t[2]");
                            Console.WriteLine("Kullanıcı Sil\t[3]");
                            Console.WriteLine("Programı Kapat \t[0]");
                            Console.WriteLine("Seçim Yapınız");
                            int secim = Convert.ToInt32(Console.ReadLine());

                            switch (secim)
                            {
                                case 1:
                                    Console.WriteLine("Adınızı giriniz: ");
                                    string ad = Console.ReadLine();
                                    Console.WriteLine("Soyadınızı giriniz: ");
                                    string soyad = Console.ReadLine();
                                    Console.WriteLine("Kimlik numaranızı giriniz: ");
                                    ulong tc = ulong.Parse(Console.ReadLine());
                                    Console.WriteLine("Cinsiyetiniz: ");
                                    char cinsiyet = char.Parse( Console.ReadLine());
                                    Console.WriteLine("Çalışma Durunmunuz: ");
                                    bool calismaDurumu = bool.Parse(Console.ReadLine());
                                    Console.WriteLine("Kullanıcı Adınız:");
                                    string Username = Console.ReadLine();
                                    Console.WriteLine("Password giriniz: ");
                                    string Password = Console.ReadLine();
                                    Oliste.Add(new Ogrenci { Ad = ad, Soyad = soyad, Tc = tc, Cinsiyet = cinsiyet, CalismaDurumu = calismaDurumu, Username = username, Password = password });
                                    break;


                                case 2:
                                    Console.WriteLine("-------ÖĞRENCİ lİSTESİ----------");

                                    foreach (Ogrenci item in Oliste)
                                    {
                                        Console.WriteLine(item.Ad + "---" + item.Soyad + "---" + item.Tc + "---" + item.Cinsiyet + "---" + item.CalismaDurumu + "---" + item.Username + "---" + item.Password);
                                       
                                    }
                                    break;

                                case 3:
                                    Console.WriteLine("------- KULLANICI SİLME İŞLEMİ --------");
                                    foreach (Ogrenci item in Oliste)
                                    {
                                        Console.WriteLine("Silmek istediğiniz indeks numarasını giriniz");

                                        int i = Convert.ToInt32(Console.ReadLine());
                                        Oliste.RemoveAt(i);
                                        Console.Clear();
                                        goto menu;
                                       
                                    }
                                  
                                    foreach (Ogrenci item in Oliste)
                                    {
                                        Console.WriteLine(item.Ad + "---" + item.Soyad + "---" + item.Tc + "---" + item.Cinsiyet + "---" + item.CalismaDurumu + "---" + item.Username + "---" + item.Password);

                                    }
                                    
                                    break;

                                case 0:
                                    Console.WriteLine("-------- PROGRAMI KAPATINIYOR --------");
                                    durum = false;
                                    break;

                            }

                        }

                    }

                }
              
                
            }
            if (hak==0)
            {
                Console.Clear();
                Console.WriteLine("Giriş Başarısız");

                Console.WriteLine("Çıkış Yapılıyor");
                Console.ReadLine();


            }
           
            Console.WriteLine("Giriş Başarısız");
            Console.ReadLine();
        }
    }
}