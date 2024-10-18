using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Veriables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler

            //double number;
            //number = 4.85;
            //Console.WriteLine(number);

            //Console.WriteLine("**** Fiyat Listesi ****");
            //double applePrice, orangePrice, strawberryPrice, patatoPrice, tomatoPrice;
            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //patatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //// Konsol kodlamasını UTF-8 olarak ayarladık ( tl sembolü konsolda çalışmadığı için )
            //Console.OutputEncoding = System.Text.Encoding.UTF8;

            //Console.WriteLine("---- Elma Birim Fiyatı: " + applePrice + "₺");
            //Console.WriteLine("---- Portakal Birim Fiyatı: " + orangePrice + "₺");
            //Console.WriteLine("---- Çilek Birim Fiyatı: " + strawberryPrice + "₺");
            //Console.WriteLine("---- Patates Birim Fiyatı: " + patatoPrice + "₺");
            //Console.WriteLine("---- Domates Birim Fiyatı: " + tomatoPrice + "₺");

            //Console.WriteLine();
            //Console.WriteLine();

            //double appleGram, orangeGram, strawberryGram, patatoGram, tomatoGram;

            //appleGram = 1.245;
            //orangeGram = 2.65;
            //strawberryGram = 0.75;
            //patatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice = orangeGram * orangePrice; 
            //double strawberryTotalPrice = strawberryGram * strawberryPrice;
            //double patatoTotalPrice = patatoGram * patatoPrice;
            //double tomatoTotalPrice = tomatoGram * tomatoPrice;

            //Console.WriteLine("Alınan Ürün: Elma " + " - Birim Fiyat: " + applePrice + "₺" + " - Garamaj: " + appleGram + " - Toplam Tutar: " + appleTotalPrice + "₺" );
            //Console.WriteLine("Alınan Ürün: Portakal " + " - Birim Fiyat: " + orangePrice + "₺" + " - Garamaj: " + orangeGram + " - Toplam Tutar: " + orangeTotalPrice + "₺" );
            //Console.WriteLine("Alınan Ürün: Çilek " + " - Birim Fiyat: " + strawberryPrice + "₺" + " - Garamaj: " + strawberryGram + " - Toplam Tutar: " + strawberryTotalPrice + "₺" );
            //Console.WriteLine("Alınan Ürün: Patates " + " - Birim Fiyat: " + patatoPrice + "₺" + " - Garamaj: " + patatoGram + " - Toplam Tutar: " + patatoTotalPrice + "₺" );
            //Console.WriteLine("Alınan Ürün: Domates " + " - Birim Fiyat: " + tomatoPrice + "₺" + " - Garamaj: " + tomatoGram + " - Toplam Tutar: " + tomatoTotalPrice + "₺" );

            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + patatoTotalPrice + tomatoTotalPrice;
            //Console.WriteLine();
            //Console.WriteLine("Alışveriş Toplam Tutarı: " + shoppingTotalPrice + "₺");

            #endregion

            #region Char Değişkenler

            //char symbol;
            //symbol = 'a';
            //Console.WriteLine(symbol);

            #endregion

            #region Klavyeden Veri Girişleri String Değişkenler

            //Console.WriteLine("**** Vargas Hava Yolları Yolcu Bilgisi ****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

            //// Kullanıcıdan klavye ile bilgi alma:
            //Console.Write("Yolcu Adı: ");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("İlçe Bilgisi: ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Şehir Bilgisi: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yolcu Yaş: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("Yolcu TC Kimlik No: ");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.WriteLine();

            //Console.WriteLine("-----------------------------------------------");
            //Console.WriteLine("Yolcu TC Kimlik Numarası: " + passengerIdentityNumber + " " + "Yolcu Ad Soyad: " + passengerName + " " + passengerSurname + " " + passengerDistrict + " / " + passengerCity + " " + passengerAge);

            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler

            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;
            //Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz: ");
            //shoesCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız sandalye sayısını giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız televizyon sayısını giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoesCount * shoesPrice + computerCount * computerPrice + chairCount * chairPrice + tvCount * tvPrice;

            //Console.WriteLine();
            //Console.WriteLine("Toplam Ödemeniz Gereken Tutar : " + totalPrice + "TL");

            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            //double exam1, exam2, exam3, result;

            //Console.Write("Lütfen 1. Sınav Notunuzu Giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. Sınav Notunuzu Giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3. Sınav Notunuzu Giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();
            //Console.WriteLine("Sınav Ortalamanız: " + result);

            #endregion

            #region Klavyeden Karakter Girişleri

            char gender;
            Console.Write("Lütfen Cinsiyet Seçiniz: ");
            gender = char.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Seçtiğiniz Cinsiyet: " + gender);

            #endregion

            Console.Read();
        }
    }
}

// *** Veriables (Değişkenler) ***
// double = Ondalıklı değişkenler için kullanılır. Ayırma, basamak belirtme gibi durumlar konsol ekranında karşımıza virgül ile gelir.
// Char = Karakter türündeki değişkenlerdir. Tek karakaterli değişkenler için kullanılır. ('Tek tırnak arasına yazılır.') 

// scope = Kapsam demektir (süslü parantezin içinde kapsamında bulunma anlamı taşır.)
// Klavyeden Veri Girişleri = Console.ReadLine();
// Dönüşümler = int.Pars(Console.ReadLine()); Klavyeden girilen ifadeyi int değere dönüştürür.
// double.Pars(Console.ReadLine()); Klavyeden girilen ifadeyi double değere dönüştürür.
// char.Pars(Console.ReadLine()); Klavyeden girilen ifadeyi char değere dönüştürür.