using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü

            //string[] cities = {"milano", "roma", "budapeşte", "ankara", "istanbul", "varşova" };

            //// Dizinin tüm elemanlarını ekranda gösterelim: 

            //foreach (string x in cities)
            //{
            //    Console.WriteLine(x);
            //}

            // Foreach döngüsünü aritmetik ifadelerde de kullanabiliriz.

            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };

            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}

            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };

            //foreach (int i in numbers)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }

            //}

            // Foreach ile toplama işlemi de yapılabilir.

            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };

            //int total = 0;

            //foreach (int i in numbers)
            //{
            //    total += i;
            //}
            //Console.WriteLine(total);

            // Kelimenin harflerini ayırma örneği:

            //string word = "Merhaba";

            //foreach (char c in word)
            //{
            //    Console.WriteLine(c);
            //}

            #endregion

            #region Listeler ile Foreach Kullanımı
            //List<int> numbers = new List<int>()
            //{ 1, 2, 3, 4, 5, 8 };


            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion

            #region  Örnek Sınav Sistemi Uygulaması

            Console.Write("***** C# Eğitim Kampı Sınav Uygulaması *****");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


            // Sınıftaki öğrenci sayısını kullanıcıdan alma: 
            Console.WriteLine("------------------------------");
            Console.WriteLine("Sınıfınızda Kaç Öğrenci Var: ");
            int studentCount = int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------");

            // Öğrenci isimlerini ve not ortalamalarını saklayacak diziler:  

            string[] studentNames = new string[studentCount];
            double[] studentExamAvg = new double[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i + 1}. Öğrencinin İsmini Giriniz: ");
                studentNames[i] = Console.ReadLine();

                double totalExamResult = 0;

                // Her öğrenci için üç sınav notu girişi:

                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentNames[i]} Adlı Öğrencinin {j + 1}. Sınav Notunu Giriniz:  ");
                    double value = double.Parse(Console.ReadLine());
                    totalExamResult += value; // Notları topluyoruz.
                    Console.WriteLine();

                    studentExamAvg[i] = totalExamResult / 3; // Ortalama alıyoruz.
                }
            }

            // Sınav Ortalamaları:

            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine("------------------------------");

                Console.WriteLine($"{studentNames[i]}  Adlı Öğrencinin Ortalaması: {studentExamAvg[i]} ");

                // Öğrencilerin ortalaması ve geçip - kalma durumları:
                if (studentExamAvg[i] >= 50)
                {
                    Console.WriteLine($"{studentNames[i]} Adlı Öğrenci Dersi Geçti");
                }
                else
                {
                    Console.WriteLine($"{studentNames[i]} Adlı Öğrenci Dersten Kaldı");

                }
                Console.WriteLine("------------------------------");

            }

            #endregion

            Console.ReadKey();

        }
    }
}


// Foreach Döngüsü 4 tane alan bir döngüdür. Foreach(1;2;3;4)
// 1 = Değişken Türü
// 2 = Değişken Adı
// 3 = In (İçinden anlamına gelir.)
// 4 = Liste, koleksiyon veya Dizi Adı

// Mantığı for döngüsü gibidir ama daha efektif kullanılır.
// For döngüsüyle yaptığımız tüm işlemleri foreach döngüsüyle de yapabiliriz.

// Programlamada Liste olarak bilinen yapılar vardır.
// Listeleri özellikle veritabanı ile birlikte kullanacağız.
// Listeler bir koleksiyon üyesidir.
// List<DeğişkenTürü> DeğişkenAdi = new List <DeğişkenTürü>(); Şeklinde yeni liste oluşturulur.
//  List<int> numbers = new List<int>() {} = Direk süslü parantez açarak listemizi oluşturabiliriz.
// new = örnek alma anlamına gelir, OOP' de detaylı öğreneceğiz.
// Foreach döngüsü sadece dizilerle çalışan bir yapı değildir, aynı zamanda listelerle de çalışılabilir.
// Listeler ve diziler birer koleksiyon üyeleridir.
// 
// 