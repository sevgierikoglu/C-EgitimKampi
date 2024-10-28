using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace KAMPDERSI3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region KARAR YAPILARI IF ELSE

            // Console.Write("Lütfen Şifre giriniz : ");
            // string password;
            // password = Console.ReadLine();  

            // if (password == "ABDC")
            // {
            //     Console.WriteLine("Şifre doğru.");

            // }
            // else
            // {
            //     Console.WriteLine("Şifre yanlış tekrar deneyiniz");
            // }

            // Console.Write("Şifre giriniz");

            // string passwordtryagain;
            // passwordtryagain = Console.ReadLine();

            // Console.WriteLine();

            // if ( passwordtryagain == "ABCD")
            // {
            //     Console.WriteLine("Şifre doğru : ");
            // }
            //else
            // {
            //     Console.WriteLine("Şifre yanlış 5 dakika sonraa tekrar deneyiniz.");

            ////--------------------------------------------------------------------------------------------

            //string capital, contry;

            //Console.Write("Yaşamış olduğunuz Ülkeyi giriniz : ");
            //contry = Console.ReadLine();

            //Console.Write("Lütfen başkenti giriniz : ");
            //capital = Console.ReadLine();



            //if (contry == "türkiye" & capital== "ankara")
            //{
            //    Console.Write("Ülke ve Başkent girişleri doğru...");
            //}
            //else
            //{
            //    Console.Write("Hatalı giriş tekrar deneyiniz...");
            //}

            ////--------------------------------------------------------------------------------------------
            //int number;
            //Console.Write("Sayi girişi yapınız : ");
            //number = int.Parse(Console.ReadLine());


            //if (number == 7)
            //{
            //    Console.Write("Doğru giriş yaptınız : ");

            //}
            //else
            //{
            //    Console.Write("Yanlış giriş yaptınız...");

            //}

            ////-------------------------------------------------------------------------------------------- ve kullanımı
            //int exam1, exam2, exam3, average;
            //string resualt="Hatalı giriş tekrar deneyin...";

            //    Console.Write("1. Sınav notunuzu giriniz : ");
            //    exam1=int.Parse(Console.ReadLine());
            //    Console.Write("2. Sınav notunuzu giriniz : ");
            //    exam2 =int.Parse(Console.ReadLine());
            //    Console.Write("3. Sınav notunuzu giriniz : ");
            //    exam3 =int.Parse(Console.ReadLine());

            //    average=(exam1+exam2+exam3)/ 3;
            //    Console.WriteLine("Sınavların toplam ortalaması : " + average);

            //    if (average>=0 & average <= 49.99)
            //    {
            //        resualt="Sınıfta kaldınız...";
            //    }
            //    if (average>=49.99 & average <= 70)
            //    {
            //        resualt="Sınıf geçme durumunuz orta...";
            //    }
            //    if (average>=70 & average <= 100)
            //    {
            //        resualt="Sınıf geçme durumunuz çok iyi...";
            //    }

            //    Console.WriteLine(resualt);
            ////-------------------------------------------------------------------------------------------- veya kullanımı

            // string city;
            // Console.Write("Lütfen yaşamakta olduğunuz şehiri giriniz : ");
            // city = Console.ReadLine();

            //if (city=="Bursa" | city=="İstanbul" | city == "Ankara")
            // {
            //     Console.WriteLine("Girmiş olduğunuz şehir listemizde bulunmaktadır...");

            // }

            //else
            // {
            //     Console.WriteLine("Girmiş olduğunuz şehir listemizde bulunmamaktadır...");
            // }

            ////-------------------------------------------------------------------------------------------- eşit değilse 
            ///
            // Console.Write("Kullanıcı adını giriniz : ");
            //string username=Console.ReadLine();

            // if (username != "admin")
            // {
            //     Console.WriteLine("Hatalı kullanıcı adı");
            // }
            // else
            // {
            //     Console.Write("Şifre giriniz...");
            // }
            // int password = 1245;
            // password = int.Parse(Console.ReadLine());
            // Console.WriteLine("Hoşgeldiniz....");


            #endregion


            #region     MOD İSLEMLERİ

            // herhangi bir sayının modunu bulmak için ;

            //int number;
            //number = 79;
            //int resualt = number % 10;
            //Console.Write(resualt);

            ////--------------------------------------------------------------------------------------------

            //Console.Write("1. sayıyı giriniz : ");
            //int number1 = int.Parse(Console.ReadLine());
            //Console.Write("2. sayıyı giriniz : ");
            //int number2 = int.Parse(Console.ReadLine());

            //int resualt = number1 % number2;

            //Console.WriteLine("1. sayının 2. sayıya bölümünden kalan = " + resualt);


            ////-----------------------------------------------------------------------------------------sayının tek yada çift olduğunu bulma
            ///

            //Console.Write("Lütfen sayı girişi yapınız : ");
            //int number=int.Parse(Console.ReadLine());
            //if (number %2== 0)
            //{
            //    Console.Write("Çift sayı girdiniz...");
            //}
            //else
            //{
            //    Console.Write("Tek sayı girdiniz...");
            //}

            #endregion


            #region CHAR İLE KARAR YAPILARI

            //Char team;
            //Console.Write("Karakter girişi yapınız : ");
            //team=char.Parse(Console.ReadLine());
            //string value =  "Geçersiz değer";

            //if (team == 'g' | team == 'G')
            //{
            //    Console.Write("Galatasaray");
            //} 
            
            //if (team == 'f' | team == 'F')
            //{
            //    Console.Write("Fenerbahçe");
            //}
            
            //if (team == 'b' | team == 'B')
            //{
            //    Console.Write("Beşiktaş");
            //}
            //else
            //{
            //    Console.Write(value);
            //}


            #endregion


            #region ORNEK PROJE

            Console.WriteLine("----------- C# Restoranları ----------");
            Console.WriteLine();
            Console.WriteLine("1. Ana Yemekler");
            Console.WriteLine("2. Çorbalar");
            Console.WriteLine("3. Pizzalar");
            Console.WriteLine("4. Tatlılar");
            Console.WriteLine("5. İçecekler");

            string menuItem;

            Console.Write("Görmek istediğinzi menüyü seçiniz : ");
            menuItem = Console.ReadLine();

            if (menuItem =="1" )
            {
                Console.WriteLine();
                Console.WriteLine("--------Ana Yemekler ----------");
                Console.WriteLine("1. Sarma");
                Console.WriteLine("2. Patlıcan Musakka");
                Console.WriteLine("3. Köri soslu tavuk");
            }
            if (menuItem == "2")
            {
                Console.WriteLine();
                Console.WriteLine("--------Çorbalar----------");
                Console.WriteLine("1. Mercimek Çorbası");
                Console.WriteLine("2. Yoğurt Çorbası");
                Console.WriteLine("3. Ezogelin Çorbası");
            }
            if (menuItem == "3")
            {
                Console.WriteLine();
                Console.WriteLine("--------Pizzalar----------");
                Console.WriteLine("1. Mantarlı Pizza");
                Console.WriteLine("2. Tavuklu Pizza");
                Console.WriteLine("3. Sebzeli Pizza");
            }
            if (menuItem == "4")
            {
                Console.WriteLine();
                Console.WriteLine("--------Tatlılar----------");
                Console.WriteLine("1. Triliçe");
                Console.WriteLine("2. Kazandibi");
                Console.WriteLine("3. Profiterol");
            }
            if (menuItem == "5")
            {
                Console.WriteLine();
                Console.WriteLine("--------İçecekler----------");
                Console.WriteLine("1. Su");
                Console.WriteLine("2. Soda");
                Console.WriteLine("3. Kola");
            }

            #endregion


            #region SWITCH CASE

            //Console.WriteLine("Lütfen ay girişi yapınız ");
            //int monthnumber=int.Parse(Console.ReadLine());

            //switch (monthnumber)
            //{
            //    case 1: Console.Write("Ocak"); break;
            //    case 2: Console.Write("Şubat");break;
            //    case 3: Console.Write("Mart"); break;
            //    case 4: Console.Write("Nisan"); break;
            //    case 5: Console.Write("Mayıs"); break;
            //    case 6: Console.Write("Haziran"); break;
            //    case 7: Console.Write("Temmuz"); break;
            //    case 8: Console.Write("Ağustos"); break;
            //    case 9: Console.Write("Eylül"); break;
            //    case 10: Console.Write("Ekim"); break;
            //    case 11: Console.Write("Kasım"); break;
            //    case 12: Console.Write("Aralık"); break;
            //    default: Console.Write("Hatalı veri girişi");break;

            //}


        #endregion

            #region SWITCH CASE HESAP MAKINESI

        //int number1, number2, result;

        //char symbol;

        //Console.Write("1. Sayıyı giriniz : ");
        //number1=int.Parse(Console.ReadLine());
        //Console.Write("2. Sayıyı giriniz : ");
        //number2 =int.Parse(Console.ReadLine());

        //    Console.Write("Lütfen yapmak istediğiniz işlemi giriniz : ");
        //symbol=char.Parse(Console.ReadLine());


        //    switch (symbol)
        //    {
        //        case '+':
        //            result=number1 + number2;
        //            Console.WriteLine("Toplam : "+ result); 
        //            break;

        //        case '-':

        //            result=number1 - number2;
        //            Console.WriteLine("Fark : "+ result);
        //            break;

        //        case '*':

        //            result = number1 * number2;
        //            Console.WriteLine("Çarpım : " + result);
        //            break;

        //        case '/':

        //            result = number1 /- number2;
        //            Console.WriteLine("Bölüm : " + result);
        //            break;
        //    }

            #endregion


            Console.Read();
        }
            

          } 

    }

