using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region YazdırmaKomutları

            //Console.Write("Merhaba Dünya");
            //Console.WriteLine("Selam");

            //Console.WriteLine("**** Yemek Kategorileri ****");
            //Console.WriteLine();
            //Console.WriteLine("1- Çorbalar");
            //Console.WriteLine("2- Ana Yemekler");
            //Console.WriteLine("3- Soğuk Başlangıçlar");
            //Console.WriteLine("4- Salatalar");
            //Console.WriteLine("5- Tatlılar");
            //Console.WriteLine("6- İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("**** Yemek Kategorileri ****");

            #endregion

            #region Değişkenler
            // Değişken_türü değişken_adi; şeklinde tanımlanır.

            #region String Değişkenler

            //string name;
            //name = "Fatma";
            //Console.WriteLine(name);

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city; // Bir satırda birden fazla değişken tanımlanabilir.

            //customerName = "Fatma";
            //customerSurname = "Yaşar";
            //customerPhone = "+90 555 555 55 55";
            //customerEmail = "deneme@gmail.com";
            //district = "Kadıköy";
            //city = "İstanbul";

            //Console.WriteLine("**** Rezervasyon Kartı ****");
            //Console.WriteLine();
            //Console.WriteLine("-----------------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email Adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("-----------------------------------------");

            //customerName = "Ayşegül";
            //customerSurname = "Kaya";
            //customerPhone = "+90 111 111 11 11";
            //customerEmail = "test@gmail.com";
            //district = "Fatih";
            //city = "İstanbul";

            //// Programlamada değişken atama işlemi hiyerarşik bir düzende yapılır. Değerlerin okunması ve işlenmesi, kod satırlarında yukarıdan aşağıya doğru yapılır.

            //Console.WriteLine();
            //Console.WriteLine("-----------------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email Adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("-----------------------------------------");
            #endregion

            #region İnt Değişkenler

            //int number = 24;
            //Console.WriteLine(number);

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("**** Restoran Menü Fiyatı ****");
            Console.WriteLine();
            Console.WriteLine("---- Hamburger: " + hamburgerPrice + " TL");
            Console.WriteLine("---- Pizza: " + pizzaPrice + " TL");
            Console.WriteLine("---- Kola: " + cokePrice + " TL");
            Console.WriteLine("---- Limonata: " + lemonadePrice + " TL");
            Console.WriteLine("---- Kızartma: " + friesPrice + " TL");
            Console.WriteLine("---- Su: " + waterPrice + " TL");

            Console.WriteLine("**** Restoran Menü Fiyatı ****");
            Console.WriteLine();

            Console.WriteLine();
            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;

            int totalHamburgerPrice;
            int totalCokePrice;
            int totalWaterPrice;
            int totalFriesPrice;
            int totalPizzaPrice;
            int totalLemonadePrice;

            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 3;
            friesCount = 1;
            pizzaCount = 0;
            lemonadeCount = 0;

            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            totalCokePrice = cokeCount * cokePrice;
            totalWaterPrice = waterCount * waterPrice;
            totalLemonadePrice = lemonadeCount * lemonadePrice;
            totalFriesPrice = friesCount * friesPrice;
            totalPizzaPrice = pizzaCount * pizzaPrice;

            Console.WriteLine("---------------------------------");
            Console.WriteLine("Hamburher Tutarı: " + totalHamburgerPrice + " TL");
            Console.WriteLine("Pizza Tutarı: " + totalPizzaPrice + " TL");
            Console.WriteLine("Kızartma Tutarı: " + totalFriesPrice + " TL");
            Console.WriteLine("Kola Tutarı: " + totalCokePrice + " TL");
            Console.WriteLine("Limonata Tutarı: " + totalLemonadePrice + " TL");
            Console.WriteLine("Su Tutarı: " + totalWaterPrice + " TL");

            Console.WriteLine();
            int totalPrice = totalHamburgerPrice + totalCokePrice + totalWaterPrice + totalLemonadePrice + totalFriesPrice + totalPizzaPrice;

            Console.WriteLine("Toplam Ödenecek Tutar: " + totalPrice + " TL");

            #endregion

            #endregion
            Console.Read();
        }
    }
}

// Yazdırma Komutları
// Console.Write(""); = Aynı satır sonunda imleç devam eder, yazdırma komutudur.
// Console.WriteLine(""); = İmleç satır başından başlar bir alt satıra geçer, yazdırma komutudur.

// Değişkenler (Variable) = Veriler üzerinde işlemler yapabilmemizi sağlayan ve geçici olarak Ram'de tutulan programlama değerleridir.
// Değişken_türü değişeken_adı; şeklinde tanımlanır.
// Değişken adlandırma standartları vardır : Değişkenler arasında boşluk kullanılmaz.
// Camel Case = Birinci harf küçük, ikinci ve sonra gelen kelimelerin ilk harfi büyük olarak isimlendirilir.  

// string = Alfabetik değişken, metinsel ifadeleri barındırır. 
// int =  Sayısal değişken, tam sayı türündeki değişkenlerdir.
// Console.Read(); veya Console.ReadKey(); ile projeyi çalıştırdığımızda ekrandan hemen kaybolmasını engelleriz, entır tuşuna basana kadar proje ekranda görünmeye devam eder.
// #region ile kod başlıkları oluşturup, satırları açıp kapatabiliriz.
// ctrl + D ile satırın aynısını kopyalayıp yapıştırabiliriz
// ctrl + TAB ile kodu tamamlayabiliriz.