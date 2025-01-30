using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crud = 4 temel veri tabanı işlemi: Create-Read-Update-Delete
            // Bu derste veritabanına, veri eklemesi yapacağız..

            Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");
            Console.WriteLine();

            Console.WriteLine("--------------------------------------------");

            // C# üzerinde yeni kayıt oluşturma :
            #region Kategori Ekleme İşlemi
            //Console.Write("Eklemek İstediğiniz Kategori Adı: ");
            //string categoryName = Console.ReadLine();
            //SqlConnection connection = new SqlConnection("Data Source = DESKTOP-6D39R8B\\SQLEXPRESS; initial catalog= EgitimKampiDb; integrated security = true"); // Veritabanı bağlantısını oluşturduk.

            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TblCategory (CategoryName) values (@p1)", connection);
            //// insert into ile veriyi TblCategory tablosundaki CategoryName sütununa ekliyoruz.
            //// values ile değerleri @p1'den alacağız.
            //// connection ile veri ekleme işlemini veritabanı ile ilişkilendiriyoruz.

            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.Write("Kategori başarıyla eklendi!");

            #endregion

            #region Ürün Ekleme İşlemi

            // string productName;
            // decimal productPrice;
            //// bool productStatus;

            // Console.Write("Ürün Adı: ");
            // productName = Console.ReadLine();
            // Console.Write("Ürün Fiyatı: ");
            // productPrice = decimal.Parse(Console.ReadLine());

            // SqlConnection connection = new SqlConnection("Data Source = DESKTOP-6D39R8B\\SQLEXPRESS; initial catalog = EgitimKampiDb; integrated security =true");
            // connection.Open();
            // SqlCommand command = new SqlCommand("insert into TblProduct (ProductName, ProductPrice,Productstatus) values (@productName,@productPrice,@productStatus)",connection);

            // command.Parameters.AddWithValue("@productName", productName);
            // command.Parameters.AddWithValue("@productPrice", productPrice);
            // command.Parameters.AddWithValue("@productStatus",true);
            // command.ExecuteNonQuery();
            // connection.Close();
            // Console.Write("Ürün Ekleme Başarılı");

            #endregion

            #region Ürün Listeleme

            //SqlConnection connection = new SqlConnection("Data Source = DESKTOP-6D39R8B\\SQLEXPRESS; initial catalog= EgitimKampiDb; integrated security = true");

            //connection.Open();
            //SqlCommand command = new SqlCommand("Select * From TblProduct", connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);

            //foreach (DataRow row in dataTable.Rows)
            //{
            //    foreach (var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString() + " ");
            //    }
            //    Console.WriteLine();
            //}

            //connection.Close();

            #endregion

            #region Ürün Silme İşlemi

            //Console.Write("Silinecek Ürün Id: ");
            //int productId = int.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source = DESKTOP-6D39R8B\\SQLEXPRESS; initial catalog= EgitimKampiDb; integrated security = true");

            //connection.Open();
            //SqlCommand command = new SqlCommand("Delete From TblProduct Where ProductId = @productId", connection);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.WriteLine("Silme İşlemi Yapıldı");

            #endregion

            #region Ürün Güncelleme İşlemi

            //Console.Write("Güncellenecek Ürün Id: ");
            //int productId = int.Parse(Console.ReadLine());
            //Console.Write("Güncellenecek Ürün Adı: ");
            //string productName = Console.ReadLine();
            //Console.Write("Güncellenecek Ürün Fiyatı: ");
            //decimal productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source = DESKTOP-6D39R8B\\SQLEXPRESS; initial catalog= EgitimKampiDb; integrated security = true");

            //connection.Open();

            //SqlCommand command = new SqlCommand("Update TblProduct Set ProductName = @productName, ProductPrice = @productPrice Where ProductId = @productId" , connection);
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();

            //connection.Close();

            //Console.WriteLine("Güncelleme Başarılı!");

            #endregion

            Console.ReadKey();

        }
    }
}

// insert into = Sql'de veri ekleme işlemi için kullanılan sorgudur.
// AddWithValue = Kullanıcının girdiği değeri tablodaki yerine ekler.
// @ sembolü = SQL tarafında değişken tanımlamak için kullanılan özel bir karakterdir.
// Veriler tabladodaki yerine hiyerarşik bir şekilde atanır.
// Execute.NonQuery(); = Sorguyu koşulsuz bir şekilde çalıştırır. 
// Tekrar tekrar kullanılacak işlemleri bir sınıf içerisinde metotlar oluşturup çağırabiliriz.