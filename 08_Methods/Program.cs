using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Metotlar
            //metotlarda () kapanarak kullanılır
            //2 ye ayrılır geriye değer döndürmeyen metotlar (VoidMetotlar)
            // geriye değer döndüren metotlar

            //void customerlist () // metot taanımlama
            // {
            //    Console.WriteLine("Ali YILDIZ"); //metot içini belirleme
            //    Console.WriteLine("Sevgi ERİKOĞLU");
            //}
            //customerlist();// metot çağırma

            //void sun()
            //{ 
            //    int x = 8;
            //    int y = 0;

            //    Console.WriteLine(x + y);

            //}
            //sun();


            #endregion


            #region GERİYE DEĞER DÖNDÜRMEYEN STRİNG PARAMETRELİ METOTLAR

            //void WriteMetod(string customerName)
            //{
            //    WriteMetod("Mehmet YILDIRIM");

            //}

            //void CustomerCard(string name, string surNamr)
            //{
            //    Console.WriteLine("Müşterimiz", "Yıldız");
            //}

            //CustomerCard("Mehmet", "Yıldız");
            //CustomerCard("Ayşegül", "Kaya");

            #endregion

            #region GERİYE DEĞER DÖNDÜRMEYEN INT PARAMETRELİ METOTLAR

            //void Sum (int number1, int number2, int number3) 
            //{ 
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine(result);
            //}
            //Sum(4, 5, 6);


            #endregion

            #region GERIYE DEĞER DÖNDÜREN METOTLAR

            //string CustomerName()
            //{
            //    return "Buse Yıldız";
            //}

            //CustomerName();

            //string StudentCard()
            //{
            //    string name = "Sevgi";
            //    string surname = "ERİKOĞLU";

            //    return name + " " + surname;
            //}

            //Console.WriteLine(StudentCard());

            #endregion

            #region GERIYE DEĞER DÖNDÜREN STRİNG PARAMETRELI METOTLAR

            //string CountryCard(string countrynanme, string capital, string flagColor)
            //{
            //    string cardinfo = "Ülke : "+countrynanme + "-   Başkent: "+ capital + "-  Bayrak Rengi: "+ flagColor;
            //    return cardinfo;
            //}
            //string x,y,z;
            //Console.Write("Ülke adını giriniz : ");
            //x = Console.ReadLine();

            //Console.Write("Başkent Giriniz : ");
            //y = Console.ReadLine();


            //Console.Write("Bayrak rengi giriniz : ");
            //z = Console.ReadLine();

            //Console.WriteLine(CountryCard(x,y,z));

            //Console.WriteLine(CountryCard("Türkiye", "Ankara", "Kırmızı - Beyaz"));
            #endregion

            #region GERIYE DEĞER DÖNDÜREN İNT PARAMETRELI METOTLAR

            //int Sum(int number1, int number2)
            //{
            //    int result = number1 + number2;
            //    return result;
            //}
            //Console.WriteLine(Sum(45, 98));
            //Console.WriteLine(Sum(36, 25));
            //Console.WriteLine(Sum(44, 36));
            //Console.WriteLine(Sum(14, 20));

            #endregion

            #region ÖRNEK UYGULAMA


            //string ExamResult(string student, int exam, int exam2, int exam3)
            //{
            //    int result = (exam + exam2 + exam3) / 3;
            //    if (result >= 50)
            //    {
            //        return student + " Öğrenci sınavı geçti " + "Ortalama: " + result;
            //    } 
            //    else
            //    {
            //        return student + " Öğrenci sınavı geçemedi " + "Ortalama: " + result;
            //    }
            //}
            //Console.WriteLine(ExamResult("Ali", 25, 41, 50));
            //Console.WriteLine(ExamResult("Ayşe", 25, 41, 85));

            #endregion

            Console.Read();
        }



        
    }
}
