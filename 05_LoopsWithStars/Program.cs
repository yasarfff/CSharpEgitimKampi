using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LoopsWithStars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Alt Alta 10 Tane Yıldız Oluşturma

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("*");
            //}

            #endregion

            #region Yan Yana 10 Tane Yıldız Oluşturma

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.Write("*");
            //}

            #endregion

            #region Alt Alta 10 Tane Yıldız Oluşturma (Her Satırda 10 Yıldız)

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("***********");
            //}

            #endregion

            #region Yıldızlarla Dik Üçgen

            //for (int i = 1; i<=5; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();     
            //}

            #endregion

            #region Yıldızlarla Ters Dik Üçgen

            //for (int i = 5; i >= 1; i--)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Yıldızlarla Yarım Baklava Deseni (Dikve Ters Dik Üçgen Beraber)

            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //for (int k = 4; k >= 1; k--)
            //{
            //    for (int m = 1; m <= k; m++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Baklava Dilimi

            //int n = 5;
            //Üst Kısım
            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = n - 1; j > 0; j--)
            //    {
            //        Console.Write(' ');
            //    }

            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write('*');
            //    }
            //    Console.WriteLine();
            //}

            //Alt Kısım
            //for (int i = n - 1; i >= 1; i--)
            //{
            //    for (int j = n - 1; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Baklava Dilimi Düzenlenmiş

            //int n = 5; // Baklava diliminin yüksekliği

            //// Üst üçgen kısmı
            //for (int i = 1; i <= n; i++)
            //{
            //    // Boşlukları yazdırma
            //    for (int j = i; j < n; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    // Yıldızları yazdırma
            //    for (int k = 1; k <= (2 * i - 1); k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //// Alt üçgen kısmı
            //for (int i = n - 1; i >= 1; i--)
            //{
            //    // Boşlukları yazdırma
            //    for (int j = n; j > i; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    // Yıldızları yazdırma
            //    for (int k = 1; k <= (2 * i - 1); k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Piramit Deseni

            //int n = 5;
            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = n - 1; j >= 0; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Ters Piramit Deseni

            //int n = 5;
            //for (int i = n; i >= 1; i--)
            //{
            //    // Boşluklar
            //    for (int j = n - i; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    // Yıldızlar
            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            Console.ReadKey();
        }
    }
}
