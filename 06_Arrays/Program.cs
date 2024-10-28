using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace KAMPDERSI6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region DİZİ OLUŞTURMA VE DİZİ KULLANIMI 1

            //2.4.6.8 bu çift sayı dizisi
            //kırmızı, sarı, beyaz renk dizisi
            //diziler 0 dan başlar 4 eleman eklemek istersen bu elemanların numaraları 0,1,2,3 olur verilen eleman adetlerinin 
            //hepsini doldurmak zorunda değiliz.
            //tam sayı formatında indekse sayı ataması yapmazsak defult değer olarak 0 ı görürüz.
            // dizi tanımlama 1 : DeğişkenTürü [] DiziAdı =new DeğişkenTürü [Eleman sayısı]


            //string[] colors =new string[4]; //dizi ve  elman sayısı tanımlama
            //colors[0] = "Kırmızı"; //dizinin içine eleman tanımlama
            //colors[1] = "Beyaz";
            //colors[2] = "Mavi";
            //colors[3] = "Pembe";


            //Console.WriteLine(colors[3]);

            //------------------------------------------------------------------------------

            //string[] citys = new string[7];
            //citys[0] = "İstanbul";
            //citys[1] = "Bursa";
            //citys[2] = "İzmir";
            //citys[3] = "Adana";
            //citys[4] = "Ankara";
            //citys[5] = "Tokat";
            //citys[6] = "Van";

            //Console.WriteLine("yaşadığımız şehir : " + citys[6]);

            //------------------------------------------------------------------------------

            //int[]number=new int[4];
            //number[0] = 2;
            //number[1]= 4;
            //number[2]= 6;
            //number[3]= 8;

            //Console.WriteLine("Çift sayılar dizisi : "+number[0]+", " + number[1] + ", " + number[2] + ", " + number[3]);

            //------------------------------------------------------------------------------


            #endregion

            #region DİZİ OLUŞTURMA VE DİZİ KULLANIMI 2

            //string[] cities = { "İstanbul", "Adana", "Bursa", "Van" };

            //Console.WriteLine(cities[0]);




            #endregion

            #region DİZİDEKİ TÜM ELEMANLARI LİSTELEME

            // string[] colors = { "Sarı", "Kırmızı", "Mavi", "Pembe" };

            // for (int i = 0; i<colors.Length; i++)

            //{
            //     Console.WriteLine(colors[i]);
            // }
            //-------------------------------------------------------------------------------

            //int[] numbers = { 46, 522, 86, 120, 1130, 330 };

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] %3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}
            //-------------------------------------------------------------------------------
            //char[] symbols = { 'A', 'C', 'D', 'E', 'F' };

            //for (int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}

            //-------------------------------------------------------------------------------
            #endregion

            #region DİZİ İÇERİSİNDEKİ EN BÜYÜK SAYIYI BULMA

            //int[] myArray = { 47, 85, 120, 1090, 1300, 450 };

            //int maxNumber = myArray[0];

            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    if (myArray[i] > maxNumber)
            //    {
            //        maxNumber = myArray[i];
            //    }

            //}
            //Console.WriteLine(maxNumber);

            #endregion

            #region DİZİLERE AİT METOTLAE

            // LENGHT : Dizinin genişliğini yani elaman sayısını verir

            //string[] name = { "Ayşe", "Fatma", "Zehra", "Zeynep", "Ahmet" };

            //Console.WriteLine(name.Length);

            //-----------------------------------------------------------------------------------

            // SORT : Dizinin içindeki elmanları küçükten büyüğe doğru sıralar

            //int[] numbers = { 10, 40, 1000, 150, 350, 1350 };

            //Array.Sort(numbers);

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //-----------------------------------------------------------------------------------

            // REVERSE : Dizinin içindeki elmanları tersten sıralar

            //int[] numbers = { 300, 45, 1000, 20, 1390 };
            //Array.Reverse(numbers);

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //-----------------------------------------------------------------------------------

            //İNDEXOF : Dizinin içerisinde aradığımız elemanın eleman numarasını gösterir.

            //string[] strings = { "Ayşe", "Fatma", "Buse", "Polat", "Fatih", "Mihro" };
            //int index = Array.IndexOf(strings, "Polat");

            //Console.WriteLine(index);

            //-----------------------------------------------------------------------------------

            //MAX : Dizinin en büyük elemanını direkt getirir.
            //MİN : Dizinin en kçük elemanını direkt getirir.

            //int[] numbers = { 12, 67, 123, 435, 157, 8976 };
            //Console.WriteLine("Dizinin en büyük değeri : " +numbers.Max()+  "  Dizinin en küçük değeri : "+numbers.Min());
            #endregion

            #region KULLANICIDAN DİZİ GİRİŞİ İSTEME 

            //$ SEMBOLÜ ÇİFT TIRNAK İÇERİSİNDE PARAMETRESEL İFADELERİN KULLANILMASI İÇİN KULLANILIR

            //string[] cities = new string[5];

            //for (int i = 0; i < cities.Length; i++)

            //{
            //    Console.Write($" lütfen {i + 1}.  Şehri Giriniz : ");
            //    cities[i] = Console.ReadLine();

            //}
            //Console.WriteLine();
            //Console.WriteLine("----------------------");
            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}
            #endregion

            #region DİZİ İÇERİSİNDEKİ ELAMANLARI TOPLAMA 

            //int[] numbers = { 23, 10, 5, 1, 6, 9 };

            //int sum = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}
            //Console.WriteLine(sum);

            #endregion

            #region DİZİ İÇERİSİNDEKİ RAKAMLAR TEK VE ÇİFT OLARAK LİSTELEME

          //  int[] numbers = { 220, 212, 211, 3339, 434, 51, 611, 713, 825, 92 };
            
          //Console.WriteLine("Çift Sayılar : ");
          //  Console.WriteLine();
          //  for (int i = 0; i < numbers.Length; i++)

          //  {
          //      if (numbers[i]%2==0)
          //      {  Console.WriteLine(numbers[i]); }
             
          //  }

          //  Console.WriteLine("------------------------");
          //  Console.WriteLine("Tek Sayılar : ");
          //  Console.WriteLine();
          //  for (int i = 0; i < numbers.Length; i++)

          //  {
          //      if (numbers[i] % 2 == 1)
          //      { Console.WriteLine(numbers[i]); }

          //  }
            #endregion

            Console.ReadLine();
        }
    }
}
