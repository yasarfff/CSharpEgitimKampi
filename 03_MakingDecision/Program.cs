using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If

            //Console.Write("Lütfen Şifreyi Giriniz: ");
            //string password;
            //password = Console.ReadLine();

            //if (password == "abcd")
            //{
            //    Console.WriteLine("Şifre Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre Yanlış");
            //}

            // Karar yapıları birden fazla şartla yazılabilir: 

            //string capital, country;
            //Console.Write("Başkenti Giriniz: ");
            //capital = Console.ReadLine();

            //Console.Write("Ülkeyi Giriniz: ");
            //country = Console.ReadLine();

            //if (capital == "ankara" & country == "türkiye")
            //{
            //    Console.Write("Veriler Doğrulandı");
            //}
            //else
            //{
            //    Console.Write("Hatalı Bilgiler");
            //}


            //aritmetik değerlerle karar yapıları:



            // Birden fazla if kullanımı:
            // Sınav sonucu değerlendirme:

            //int exam1, exam2, exam3, average;
            //string result = "Hata!";

            //Console.Write("1. Sınav Notunuzu Girin: ");
            //exam1 = int.Parse(Console.ReadLine());

            //Console.Write("2. Sınav Notunuzu Girin: ");
            //exam2 = int.Parse(Console.ReadLine());

            //Console.Write("3. Sınav Notunuzu Girin: ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Sınav Ortlaması: " + average);

            //if (average > 0 & average <= 50)
            //{
            //    result = "Sonuç Fezahat";
            //}

            //if (average > 50 & average <= 70)
            //{
            //    result = "Sonuç Orta";
            //}

            //if (average > 70 & average <= 84)
            //{
            //    result = "Sonuç İyi";
            //}

            //if (average > 84 & average <= 100)
            //{
            //    result = "Sonuç Çok İyi";
            //}
            //if (average > 0 & average <= 50)
            //{
            //    result = "Sonuç Fezahat";
            //}

            //if (average > 50 & average <= 70)
            //{
            //    result = "Sonuç Orta";
            //}

            //if (average > 70 & average <= 84)
            //{
            //    result = "Sonuç İyi";
            //}

            //if (average > 84 & average <= 100)
            //{
            //    result = "Sonuç Çok İyi";
            //}

            //Console.WriteLine(result);

            // if ve else veya  | kullanımı:
            //string city;
            //Console.Write("Lütfen Şehir Girişi Yapınız: ");
            //city = Console.ReadLine();

            //if (city == "adana" | city == "ankara" | city == "bursa" | city== "trabzon")
            //{
            //    Console.WriteLine("Şehir mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("Şehir mevcut değil");
            //}

            // eşit olmama != durum sorgusu:
            //string username;
            //Console.WriteLine("Lütfen Kullanıcı Adı Giriniz: ");
            //username = Console.ReadLine();

            //if (username != "admin")
            //{
            //    Console.WriteLine("Bu kullanıcı adı kabul edilemez");
            //}
            //else
            //{
            //    Console.WriteLine("Hoş Geldiniz");
            //}

            #endregion

            #region Mod İşlemleri

            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.Write("Lütfen 1. Sayıyı Giriniz: ");
            //int number1= int.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. Sayıyı Giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;

            //Console.Write("1. sayının, 2. sayıya bölümünden kalan: " + result);

            // Mod İle sayının tek çift olma durumunu sorgulama:
            //Console.Write("Lütfen Sayıyı Girin: ");
            //int number = int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.Write("Sayı Çifttir");
            //}
            //else
            //{
            //    Console.Write("Sayı Tektir");
            //}

            // Takım bulma örneği:

            //char team;
            //Console.Write("Lütfen Takım Sembolünü Girin: ");
            //team = char.Parse(Console.ReadLine());

            //if (team == 'g' | team == 'G')
            //{
            //    Console.Write("Galatasaray");
            //}

            //if (team == 'f' | team == 'F')
            //{
            //    Console.Write("Fenerbahçe");
            //}

            //if (team == 'b' | team == 'B')
            //{
            //    Console.Write("Beşiktaş");
            //}

            #endregion

            #region Örnek Proje Uygulması

            //Console.WriteLine("*** C# Eğitim Kampı Restoran ***");
            //Console.WriteLine();
            //Console.WriteLine("-----------------------------------");
            //Console.WriteLine("1- Ana Yemekler ");
            //Console.WriteLine("2- Çorbalar ");
            //Console.WriteLine("3- Pizzalar ");
            //Console.WriteLine("4- İçecekler ");
            //Console.WriteLine("5- Tatlılar ");
            //Console.WriteLine("-----------------------------------");
            //Console.WriteLine();

            //string menuItem;

            //Console.WriteLine("Detayını Görmek İstediğiniz Menü Seçimi: ");
            //menuItem = Console.ReadLine();

            //if (menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------- Ana Yemekler ----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Köri Soslu Tavuk");
            //    Console.WriteLine("2- Kızartma Tabağı");
            //    Console.WriteLine("3- Fasulye Pilav");
            //    Console.WriteLine("4- Fırında Somon");
            //    Console.WriteLine("5- Patlıcan Musakka");
            //    Console.WriteLine();
            //    Console.WriteLine("---------- Ana Yemekler ----------");

            //    Console.WriteLine();
            //}

            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------- Çorbalar ----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Mercimek Çorbası");
            //    Console.WriteLine("2- Ezogelin Çorbası");

            //    Console.WriteLine();
            //    Console.WriteLine("---------- Çorbalar ----------");

            //    Console.WriteLine();
            //}

            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------- Pizzalar ----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Akdeniz Pizza");
            //    Console.WriteLine("2- Margaritha");
            //    Console.WriteLine("3- Tavuklu Pizza");

            //    Console.WriteLine();
            //    Console.WriteLine("---------- Pizzalar ----------");

            //    Console.WriteLine();
            //}

            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------- İçecekler ----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Kola");
            //    Console.WriteLine("2- Ayran");
            //    Console.WriteLine("3- Su");
            //    Console.WriteLine();
            //    Console.WriteLine("---------- İçecekler ----------");

            //    Console.WriteLine();
            //}

            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------- Tatlılar ----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Triliçe");
            //    Console.WriteLine("2- Kazandibi");
            //    Console.WriteLine("3- Sütlaç");
            //    Console.WriteLine();
            //    Console.WriteLine("---------- Tatlılar ----------");

            //    Console.WriteLine();
            //}
            #endregion

            #region Switch Case 

            //Console.Write("Lütfen Ay Girişi Yapın: ");
            //int monthNumber = int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1: Console.WriteLine("Ocak"); break;
            //    case 2: Console.WriteLine("Şubat"); break;
            //    case 3: Console.WriteLine("Mart"); break;
            //    case 4: Console.WriteLine("Nisan"); break;
            //    case 5: Console.WriteLine("Mayıs"); break;
            //    case 6: Console.WriteLine("Haziran"); break;
            //    case 7: Console.WriteLine("Temmuz"); break;
            //    case 8: Console.WriteLine("Ağustos"); break;
            //    case 9: Console.WriteLine("Eylül"); break;
            //    case 10: Console.WriteLine("Ekim"); break;
            //    case 11: Console.WriteLine("Kasım"); break;
            //    case 12: Console.WriteLine("Aralık"); break;

            //    default:
            //        Console.WriteLine("Hatalı Veri Girişi");
            //        break;
            //}

            #endregion

            #region Switch Case Hesap Makinesi

            int number1, number2, result;
            char symbol;

            Console.Write("1. Sayıyı Giriniz: ");
            number1 = int.Parse(Console.ReadLine());

            Console.Write("2. Sayıyı Giriniz: ");
            number2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Toplama = +");
            Console.WriteLine("Çıkarma = -");
            Console.WriteLine("Çarpma = *");
            Console.WriteLine("Bölme = /");
            Console.Write("Lütfen Yapmak İstediğiniz İşlemi Seçiniz:");
            symbol = char.Parse(Console.ReadLine());

            switch (symbol)
            {
                case '+':
                    result = number1 + number2;
                    Console.WriteLine("Toplam = " + result);
                    break;


                case '-':
                    result = number1 - number2;
                    Console.WriteLine("Fark = " + result);
                    break;

                case '*':
                    result = number1 * number2;
                    Console.WriteLine("Çarpım = " + result);
                    break;

                case '/':
                    result = number1 + number2;
                    Console.WriteLine("Bölüm = " + result);
                    break;

                default:
                    Console.WriteLine("Hatalı Seçim Yaptınız");
                    break;
            }

            #endregion

            Console.ReadKey();

        }
    }
}

// Karar Yapıları: Çıktı sonucuna göre programı yönlendirdiğimiz yapılarda kullanırız.
// Karar yapılarından sonra noktalı virgül konulmaz. Süslü parantez açılır.
// Ctrl + k + d kodları düzenler.
// mod sembolü programlamada % ile ifade edilir.
// Switch Case : Switch kod blogunun anahtarıdır. Karar yapısıdır.
// break ; ile işlemin bittiğini bildiririz. koşuldan çıkmak için kırılma yaşanır.