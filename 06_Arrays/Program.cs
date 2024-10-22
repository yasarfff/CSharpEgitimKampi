using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri
            //string[] colors = new string[4];
            //colors[0] = "Kırmızı";
            //colors[1] = "Sarı";
            //colors[2] = "Beyaz";
            //colors[3] = "Mavi";

            //Console.WriteLine(colors[2]);

            //string[] cities = new string[5];
            //cities[0] = "Milano";
            //cities[1] = "Budapeşte";
            //cities[2] = "Lyon";
            //cities[3] = "Kahire";
            //cities[4] = "Üsküp";

            //Console.WriteLine(cities[4]);

            // Çift Sayılar Dizisi:

            //int[] numbers = new int[10];
            //numbers[0] = 50;
            //numbers[1] = 48;
            //numbers[2] = 648;
            //numbers[3] = 24;
            //numbers[7] = 748;

            //Console.WriteLine(numbers[7]);

            // Farklı bir dizi oluşturma yöntemi (Dizi boyutu oluşturmadan):

            //string[] cities = { "Prag", "Roma", "Atina", "Ankara", "Bursa" };

            //Console.WriteLine(cities[2]);

            #endregion

            #region Dizideki Tüm Elemanları Listeleme

            //string[] colors = {"Sarı", "Kırmızı", "Beyaz", "Mavi", "Yeşil", "Turuncu", "Pembe"};

            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}


            //int[] numbers = { 4, 96, 75, 125, 635, 488, 522, 7456, 2365, 1120 };

            //for (int i =0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}


            // Char Türünde Dizi Örneği

            //char[] symbols = { 'a', 'b', 'c', '*', '/', '-' };
            //for (int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}

            // Dizideki en büyük elemanı bulan prog:

            //int[] myArrays = {47, 85, 95, 41, 25, 635, 789, 86, 100 };
            //int maxNumber = myArrays[0];

            //for (int i = 0; i < myArrays.Length; i++)
            //{
            //    if (myArrays[i] > maxNumber)
            //    {
            //        maxNumber = myArrays[i];
            //    }
            //}
            //Console.WriteLine(maxNumber);

            #endregion

            #region Dizi Metotları

            // Dizi Metotları:

            // Uzunluk: 

            //string[] persons = {"ali", "ahmet", "ayşe", "buse", "cem", "deniz" };
            //Console.WriteLine(persons.Length);

            // Küçükten büyüğe sıralama:

            //int[] numbers = { 45, 85, 52, 41, 86, 10, 22, 35 };
            //Array.Sort(numbers);

            //for (int i= 0;  i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);  
            //}

            // Diziyi tersten sıralama:

            //int[] numbers = { 45, 85, 52, 41, 86, 10, 22, 35 };
            //Array.Reverse(numbers);

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            // Dizi içinde aranan metodun indeks numarasını bulma:

            //string[] customers = { "ali", "buse", "ayşegül", "merve", "çınar", "kaya" };
            //int index = Array.IndexOf(customers, "merve");
            //Console.WriteLine(index);


            // Max ve Min Metotları:

            //int[] numbers = { 45, 85, 96, 63, 74, 10, 25, 22, 36 };
            //Console.WriteLine("Dizinin En Büyük Elemanı: " + numbers.Max());
            //Console.WriteLine("Dizinin En Küçük Elemanı: " + numbers.Min());

            #endregion

            #region Kullanıcıdan Değer Alma

            //string[] cties = new string[5];

            //for (int i = 0; i < cties.Length; i++)
            //{
            //    Console.Write($"Lütfen {i +1}. Şehri Giriniz:  ");
            //    cties[i]=Console.ReadLine();
            //}
            //Console.WriteLine();
            //Console.WriteLine("--------------------");

            //for (int i = 0; i < cties.Length;i++)
            //{
            //    Console.WriteLine(cties[i]);
            //}

            // Dizideki Tüm Elemanların Toplamını Alma:

            //int[] numbers = {10, 20, 30, 40, 50};
            //int sum = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}
            //Console.WriteLine(sum);


            // Dizi İçindeki Sayıları Tek ve  Çift Olarak Ayrı Listeleme:

            int[] numbers = { 21, 42, 33, 54, 55, 66, 897, 768, 39, 10, 11 };
            
            Console.WriteLine("Çift Sayılar: ");
            Console.WriteLine();
            for(int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    Console.WriteLine(numbers[i]);
                } 
            }
            Console.WriteLine("-------------------------------");

            Console.WriteLine("Tek Sayılar: ");
            Console.WriteLine();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 1)
                {
                    Console.WriteLine(numbers[i]);
                }
            }
      
            #endregion

            Console.ReadKey();
        }
    }
}

// Array (Dizi) : Aynı veri tipindeki çok sayıda veriyi bir arada tutmak için kullanılan yapılardır.
// Ör: Çift sayılar, renkler, şehirler vs..
// Aslında bir sınıf gibi hareket ederler.
// Array Syntax : DeğişkenTürü [] DiziAdı = new DeğişkenTürü[ElemanSayısı]
// Tanımlanmış dizi boyutundaki indis numarasına değer atanmamışsa default değer olarak 0 atanır.
// Diziler farklı olarak DeğişkenTürü [] DeğişkenAdı = {}; şeklinde de tanımlanabilir. Bu yöntemle dizi boyutu belirtmeden dizi oluşturulabilir.
// Verileri, dizi içinden çekerken karar yapıları da kullanabiliriz.
// Dizi tanımlarken char gibi değişkenlerde de kullanılabilir, char tanımlarken değerler '' tek tırnak içine yazılmalıdır.

// Dizilerde kullanılan metotlar vardır.
// .Length = dizinin uzunluğunu verir.
// Array.Sort(DeğişkenAdi); = Diziyi küçükten büyüğe doğru sıralar.
// Array.Reverse(DeğişkenAdi); = Diziyi tersten sıralar.
// Array.IndexOf(DeğişkenAdi, "DizideİndexiArananDeğer"); = Dizideki değerin index numarasını sorgular.
// .Max() = Dizinin en büyük elemanını verir.
// .Min() = Dizinin en küçük elemanını verir.
// C# da format yöntemiyle yazdırma işlemi = Console.WriteLine($"çift tırnak içinde çıktı yazılır, parametresel ifadeler de {} süslü parantez içine yazılır.")