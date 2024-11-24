using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DatabaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ado.net 

            Console.WriteLine("---C# veri tabanlı ürün katagori bilgi sistemi---");
            Console.WriteLine();
           
            string TableNumber;

            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("1 - Kategoriler ");
            Console.WriteLine("2 - Ürünler");
            Console.WriteLine("3 - Siparişler");
            Console.WriteLine("4 - Çıkış Yap");
            Console.Write("Lütfen getirmek istediğiniz ürün numarasını giriniz : ");
            TableNumber = Console.ReadLine();
            Console.WriteLine("---------------------------------------------------");

            SqlConnection connection = new SqlConnection("Data Source = SEVGI;initial Catalog = EgitimKampiDB;integrated security=true");
            connection.Open();

            SqlCommand command = new SqlCommand("select * From TblCategory", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);  
            DataTable dataTable = new DataTable(); // verileri gecici belleğe almayı sağlar
            adapter.Fill(dataTable);
            connection.Close();

             foreach(DataRow row in dataTable.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    Console.Write(item.ToString());
                } 
                Console.WriteLine();
            }


            Console.Read();
        }
    }
}
