using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Döngüsü
            // Ekrana 5 defa yazı yazdıralım: 
            //int i;
            //for (i = 1; i<=5; i++)
            //{
            //    Console.WriteLine("C# Eğitim Kampı");
            //}

            //for (int i = 1; i <= 20; i++)
            //{
            //    Console.WriteLine(i);
            //}

            // i += 3 : i'nin üzerine 3 ekleyerek ilerle.
            //for (int i= 3; i<=50; i += 3)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.Write("Lütfen ekrana yazdırmak istediğiniz adedi giriniz: ");
            //int finishValue = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= finishValue; i++)
            //{
            //    Console.WriteLine("YAŞASIN CUMHURİYET");
            //}

            #endregion

            #region For Döngüsü ile Karar Yapıları

            //for (int i = 0; i <= 100; i++)
            //{
            //    if (i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            // 1 - 10 arasındaki ardışık sayıları toplama: 

            //int totalValue = 0;
            //for (int i = 1; i<=10; i++)
            //{
            //    totalValue += i;

            //}
            //Console.WriteLine("1 ile 10 arasındaki sayıların toplamı: " + totalValue);

            // 1 ile 20 arasındaki çift sayıların toplamı:

            //int totalValue = 0;

            //for (int i = 1; i < 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        totalValue += i;
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine("-------");
            //Console.WriteLine("1 ile 20 arasındaki çift sayıların toplamı: " + totalValue);

            // 1 ile 50 arasında 7 ' ye tam bölünen kaç tane sayı vardır ? 

            //int count = 0;
            //for (int i = 1; i <= 50; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine("1 ile 50 arasında 7 'ye tam bölünen " + count + " adet sayı vardır.");

            // Bakteri Örneği: Her saatin sonunda 2'ye bölünen bakterinin 24 saat sonra ulaştığı bakteri sayısı kaçtır ?

            //int bakterium = 1;


            //for (int i = 1; i <= 24; i++)
            //{
            //    bakterium *= 2;
            //    Console.WriteLine(i + ". Saat Sonunda: " + bakterium);
            //}
            //Console.WriteLine("24 saat sonunda oluşan bakteri sayısı: " + bakterium);


            #endregion

            #region While Döngüsü

            //int i = 1;
            //while (i <= 10)
            //{
            //    Console.WriteLine("Merhaba Döngüler");
            //    i++;
            //}

            // 1 ile 10 arasında 3'e tam bölünen sayılar: 

            //int i = 1;
            //while (i <=10)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++; // Döngüden çıkma koşulu
            //}

            // 1 ile 10 arasındaki sayıların toplamı:

            //int i = 1;
            //int sum = 0;

            //while(i <= 10)
            //{
            //    sum += i;
            //    i++;
            //}
            //Console.WriteLine("1 ile 10 arasındaki sayıların toplamı: " + sum);

            #endregion

            #region Örnek Sınav Sorusu

            // Klavyeden girilen 3 basamaklı sayının basamakları toplamını hesaplayan kodu yazınız: 

            //Console.Write("Lütfen 3 Basamaklı Bir Sayı Giriniz: ");
            //int number = int.Parse(Console.ReadLine());

            // birler, onlar ve yüzler basamağını; basamak değerlerine ayıracağız.

            //int ones, tens, hundred;
            //int sum;

            //ones = number % 10;
            //tens = (number % 100) / 10 ;
            //hundred = number / 100;

            //sum = ones + tens + hundred;

            //Console.WriteLine(number + " Sayısının basamak değerlerinin toplamı: " +  hundred + "+" + tens + "+" + ones + "= " + sum);

            // While döngüsü ile basamak toplamı bulma: 

            Console.Write("Basamaklarını toplamak istediğiniz Sayıyı Giriniz: ");
            int number = int.Parse(Console.ReadLine());

            int sum = 0;

            while (number > 0)
            {
                int basamak = number % 10;
                Console.Write(basamak + "  ");
                sum += basamak;
                number /= 10;

            }
            Console.WriteLine();
            Console.WriteLine("Basamak Değerlerinin Toplamı: " + sum);



            #endregion

            Console.ReadKey();
        }
    }
}

// Döngüler : Programlamada bazı işlemlerin tekrar ederek gerçekleşmesidir.
// Aynı işlemi birden fazla çalıştırmamız gerektiği zamanlarda kullanırız.
// Sonuca ulaşırken clean code (temiz kod) yazarak ilerlememize olanak sağlar.
// For Döngüsü = 3 adet parametresi vardır;
// for (x Döngünün başlangıç değeri; y bitiş değeri; z artış - azalış miktarı) 
// for diyip tab tuşuna 2 kere bastıktan sonra döngü otomatik gelir.
// i += ifadesini artış miktarını 1 den fazla seçtiğimizde kullanırız. (i-= azalış miktarı)
// Döngünün başlangıç ve bitiş değerleri kullanıcıdan alınabilir.
// Döngüler, karar yapıları ile de kullanılabilir.
// *= : çarp ekle, -= : çıkar ekle, += : topla ekle vs..

// While Döngüsü : Şart sağlandığı müddetçe anlamını taşır. Şart sağlandığı sürece döngü döner.
// Döngüden çıkmak için döngüyü sonlandırma şartı verilmelidir, aksi halde döngü sonsuza dek çalışmaya devam eder.
// While (şart yazılır) { Süslü parantez içine işlemler yapılır.}