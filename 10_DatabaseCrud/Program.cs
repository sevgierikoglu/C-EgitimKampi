using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region DATABASE KATAGORİ EKLEME İŞLEMİ

            //Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");
            //Console.WriteLine();
            //Console.WriteLine("---------------------------------------");
            //Console.WriteLine("Eklemek istediğiniz Katagori Adı : ");
            //string CategoryName = Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data Source=SEVGI;initial catalog=EgitimKampiDB;integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TblCategory (CategoryName) values (@p1)", connection); //sorgu içinn insert ekle demek 
            //command.Parameters.AddWithValue("@p1", CategoryName); //
            //command.ExecuteNonQuery(); //koşulsuz sorguyu çalıştır demek yani veri tabanına yansıt
            //connection.Close();

            //Console.WriteLine("Kategori başarılı eklendi. ");
            #endregion

            #region DATABASE URUN EKLEME ISLEMI

            //string productName;
            //decimal productPrice;
            ////bool productStatus;

            //Console.Write("Ürün Adını Giriniz : ");
            //productName = Console.ReadLine();
            //Console.Write("Ürün Fİyatını giriniz : ");
            //productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data source = SEVGI;initial catalog=EgitimKampiDB;integrated security=true;");
            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TblProduct (ProductName,ProductPrice,ProductStatus) values (@productName,@productPrice,@productStatus)", connection);
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productStatus", true);
            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.Write("Ürün ekleme başarılı");



            #endregion

            #region ÜRÜN EKLEME İŞLEMİ


            //SqlConnection connection = new SqlConnection("Data Source=SEVGI;initial catalog=EgitimKampiDB;integrated security=true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("Select * From TblProduct", connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable dataTable = new DataTable();//veritabanı verilerini bellek içindeki tablo formatında tutar
            //adapter.Fill(dataTable); //veri tabanı verilerini datatableye aktarır

            //foreach (DataRow row in dataTable.Rows) //datarow verileri satır halinde tutmak için kullanılır
            //{
            //    foreach (var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString() + " ");
            //    }
            //        Console.WriteLine();
            //}

            //connection.Close();






            #endregion

            
            #region ÜRÜN GÜNCELLEME İŞLEMİ

            Console.Write("Güncellenecek ID giriniz : ");
            int productId = int.Parse(Console.ReadLine());

            Console.Write("Güncellenecek ürün adını giriniz : ");
            string productName = Console.ReadLine();

            Console.Write("Güncellenecek ürün fiyatı giriniz : ");
            decimal productPrice = decimal.Parse(Console.ReadLine());


            SqlConnection connection = new SqlConnection("Data Source=SEVGI;initial catalog=EgitimKampiDB;integrated security=true");
            connection.Open();

            SqlCommand command = new SqlCommand("Update Tblproduct Set ProductName=@productName, ProductPrice=@productPrice where ProductId=@productId", connection);

            command.Parameters.AddWithValue("@productName", productName);
            command.Parameters.AddWithValue("@productPrice", productPrice);
            command.Parameters.AddWithValue("@productId", productId);
            command.ExecuteNonQuery();

            connection.Close();

            Console.WriteLine("Güncelleme işlemi başarılı...");
            
            #endregion
            Console.ReadLine();
        }


    }
}
