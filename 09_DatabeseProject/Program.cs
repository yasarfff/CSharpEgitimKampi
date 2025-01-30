using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DatabeseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ado.net 

            Console.WriteLine("***** C# Veri Tabanlı Ürün-Kategori Bilgi Sistemi *****");
            Console.WriteLine();
            Console.WriteLine();

            string tableNumber; // Kullanıcıdan işlem numarası almak için değişken tanımladık.

            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("1- Kategoriler");
            Console.WriteLine("2- Ürünler");
            Console.WriteLine("3- Siparişler");
            Console.WriteLine("4- Çıkış Yap");
            Console.Write("Lütfen Getirmek İstediğiniz Tablo Numarasını Giriniz: ");
            tableNumber = Console.ReadLine();
            Console.WriteLine("-------------------------------------------------------------");

            // SQL Bağlantısı: 
            SqlConnection connection = new SqlConnection("Data Source= DESKTOP-6D39R8B\\SQLEXPRESS;initial Catalog=EgitimKampiDb;integrated security=true");
            // connection isimli yeni bir nesne oluşturduk.
            // Veritabanı sunucu adresimizi ekledik.
            // Veritabanımızın kendi ismini ekledik.
            // Veritabanının güvenilirliğini ekledik.

            connection.Open(); // Bağlantımızı açtık.
            SqlCommand command = new SqlCommand("Select * From TblCategory", connection); // Sorgu nesnesi oluşturduk (query), tablonun hangi veritabanına ait olduğunu bildirmek için de connection'u ekledik.
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();  // DataTable Sınıfında dataTable isimli nesne örneği oluşturduk.
            adapter.Fill(dataTable); // Bellek aracılığıyla sorguyu kullanıcıya gösterir.
            connection.Close(); // Bağlantıyı kapattık.

            // Bu verileri ekranda gösterebilmek için döngü oluşturuyoruz.

            foreach (DataRow row in dataTable.Rows) // dataTable satırları içinden gelen verileri row'a atadık.
            {
                foreach (var item in row.ItemArray) // ItemArray dizisindeki row'ları item'e atadık.
                {
                    Console.Write(item.ToString());
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}

// Select, Insert, Update, Delete 4 temel sorgu ifadeleridir.
// Select = Bir tabloda istenen sütunları getirmemizi sağlayan sql sorgusudur. Select * From Tabloİsmi şeklinde  kullanılır.
// SQL ' de Yeni sorgu oluşturmak için New Query seçilir.// 
// * ifadesi tümünü seç anlamına gelir.
// * yerine sadece çağırmak istediğimiz sütunların isimleriyle de çağırma işlemi yapabiliriz Select Sütunİsmi1, Sütunİsmi2 From Tabloİsmi şeklinde de kullanabiliriz.
// SQL' de Şartlı ifadeleri çağırmak için Where kullanılır. 
// Select * From Tabloİsmi Where Sütunİsmi = 'İstenilen Koşullu İfade' şeklinde kullanılabilir.
// SQL'de açıklama satırı oluşturmak için -- iki tire kullanılır.

// Ado.net = C# Programlama dilinde SQL yapılarını kullanabilmemize olanak sağlayan bir çerçevedir.
// SqlConnection = SQL bağlantısı için kullanılan komut.
// initial Catalog= Veri tabanı ismi 
// Data Source= Connect Server Name 
// integrated security=true : Bağlantının güvenilir olduğunu gösterir

// SqlDataAdapter = C# tarafında oluşturduğumuz sorguyla SQL veritabanı arasında bir köprü görevi görecek olan sınıftır.
// DataTable = Verileri belleğe almamızı sağlar.(Ram Geçici Bellek)

// Sınıf = Nitelikleri içinde barındıran yapılardır.
// Nesne = Sınıflara erişim sağlamak için önce o sınıftan nesne örneği türetmemiz gerekir: 
// SqlConnection("Sınıfın İsmi") connection("Sınıfın Nesnesi") = new SqlConnection(""); 
// Property-Nitelik = Nesneye ait olan özellikler


// varchar = Veri uzunluğa sabit olmayan türler için kullanılır. (isim, soyisim vs.)
// Değişken türlerinde n ifadesi = Uluslar arası alfabeler kullanılacaksa tercih edilir. Latin alfabesinin dışındaki alfabelerde kullanılır.
// nvarchar varcahara göre bellekte 2 katı yer kaplar.

// var değişkeni = Bütün değişken türlerini üzerine alan bir değişkendir. (Kullanacağımız birden fazla değişken türü varsa var kullanırız.)

// Primary Key = Birincil anahtar olarak seçilen sütun diğer sütunlardan ayrılır. Bir Id değeri başka bir Id'ye verilmez.
// Identity Specification = Id değerinini otomatik olarak arttırmak için Is Identity yes olarak seçilir.