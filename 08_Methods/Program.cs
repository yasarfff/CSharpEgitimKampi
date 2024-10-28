using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Metotlar

            //void CustomerList()
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Ayşe Yıldız");
            //    Console.WriteLine("Hakan Öztürk");
            //    Console.WriteLine("Merve Çınar");
            //}

            //CustomerList();
            //CustomerList();
            //CustomerList();
            //CustomerList();

            //void Sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}
            //Sum(); 

            #endregion

            #region Geriye Değer Döndürmeyen String Parametreli Metotlar

            //void writeMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}
            //writeMethod("Mehmet Yıldırım");

            // Müşteri Kartı Örneği:
            //void CustomerCard(string name, string surName)
            //{
            //    Console.WriteLine("Müşteri: " + name + " " + surName);
            //}
            //CustomerCard("Mehmet", "Yıldız");
            //CustomerCard("Ayşe", "Yıldırım");


            #endregion


            #region Geriye Değer Döndürmeyen İnt Parametreli Metotlar

            // Dışarıdan alınan 3 tane sayıyı toplayan metot:

            //void Sum(int number1, int number2, int number3)
            //{
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine(result);
            //}

            //Sum(1,3,45);

            #endregion

            #region Geriye Değer Döndüren Metotlar

            //string CustomerName()
            //{
            //    return "Buse Yıldız";
            //}

            //CustomerName();

            // Ekrana yazdırma: 
            //string StudentCard()
            //{
            //    string name = "Ali";
            //    string surName = "Kaya";
            //    return name + " " + surName;
            //}
            //Console.WriteLine(StudentCard());

            #endregion

            #region Geriye Değer Döndüren String Parametreli Metotlar

            //string CountryCard(string countryName, string capital, string flagColor)
            //{
            //    string cardInfo = "Ülke: " + countryName + " - Başkent: " + capital + " - Bayrak Rengi: " + flagColor;
            //    return cardInfo;
            //}
            //string x, y, z;
            //Console.Write("Ülke Adı Girin: ");
            //x = Console.ReadLine();
            //Console.Write("Başkenti Girin: ");
            //y = Console.ReadLine();
            //Console.Write("Bayrak Rengini Girin: ");
            //z = Console.ReadLine();

            //Console.WriteLine(CountryCard(x, y, z));
            //Console.WriteLine(CountryCard("Türkiye", "Ankara", "Kırmızı - Beyaz"));

            #endregion

            #region Geriye Değer Döndüren İnt Parametreli Metotlar

            //int Sum(int number1, int number2)
            //{
            //    int result = number1 + number2;
            //    return result;
            //}
            //Console.WriteLine(Sum(1,5));
            //Console.WriteLine(Sum(551,58));
            //Console.WriteLine(Sum(561,65));
            //Console.WriteLine(Sum(16,5));
            //Console.WriteLine(Sum(1485, 679));

            #endregion

            #region Örnek Uygulama


            string ExamResult(string student, int exam1, int exam2, int exam3)
            {
                int result = (exam1 + exam2 + exam3) / 3;
                if (result >= 50)
                {
                    return student + " İsimli Öğrenci  Sınavı Geçti.. " + "  Ortalama: " + result;
                }
                else
                {
                    return student + " İsimli Öğrenci  Sınavı Geçemedi.. " + "  Ortalama: " + result;
                }
            }

            Console.WriteLine(ExamResult("Ali", 90, 78, 87));
            Console.WriteLine(ExamResult("Ayşe", 30, 15, 17));

            #endregion


            Console.ReadKey();
        }
    }
}
// Metot = Fonksiyon
// C# 'da kullandığımız birçok hazır metot vardır. (Console.Write vs.)
// Bazı kurallar ve sözdizimleriyle kendi metotlarımızı da oluşturabiliriz.
// Bir yapının metot olabilmesi için sonunun mutlaka () parantezle açılıp kapanması gerekir.
// Metot oluşturduktan sonra {} süslü parantez açılır ve metota ait tüm işlemler süslü parantez içine yazılır.
// C#'da metotun üzerine gidildiğinde açıklama kutucuğunda mor renkli bir küp işareti yer alır.

// Metotlar, geriye değer döndürmeyen ve geriye değer döndüren metotlar olarak ikiye ayrılır.
// Geriye Değer Döndürülmeyen Metotlar: Customer (listele, ekle, sil, güncelle) gibi işlemlerden sonra tekrar çağırmamız gereken durumlarda kullabiliriz.
// Void : Geriye değer döndürmeyen metotları tanımlarken kullanılır.
// Yazdığımız metotu çağırmamız gerekir. Çeğırmazsak metot içinde yazdığımız işlemleri ekrana yazdıramayız.
// Metotu çağırmak için; Metotİsmi();
// Metotu bir kez yazarak birden fazla kullanabiliriz. Böylelikle kalabalık kod satırları oluşmaz.
// Metotlar (özellikle geriye döndürülmeyen metotlar) belli işlemleri tekrardan kurtarmak için programlamada önemli bir yere sahiptir. 
// Metot içinde sadece yazdırma işlemi değil istediğimiz tüm işlemleri tanımlayabiliriz. (Ör: toplama, hesap vs.)
// Metotlar özellikle veritabı işlemlerimizde bize kolaylık sağlayacak.

// Geriye Değer Döndüren Metotlar: Bu metotlar void yerine değişken türü, sınıf türyle tanımlanıyor.
// Geriye değer döndürme işlemi return ile yapılıyor.
// Ekrana yazdırma işlemi için metodu Console.Write ile çağırmamız gerekir.
// Metot parametreleri aynı anda birden fazla değişken türü alabilir.