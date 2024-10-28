using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace KAMPDERSI4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region FOR DÖNGÜSÜ

            //For 3 tane parametresi vardır.
            //for(x,y,z)
            //x : Başlangıç
            //z : Bitiş 
            //y : atış - azalış 

            //int i;

            //for (i = 1; i <= 5; i++) 
            //{
            //    Console.WriteLine("C# EĞİTİM KAMPI");
            //}
            //---------------------------------------------------------------------------------------------  
            // for (int i = 0; i <=20; i++) 

            //{
            //     Console.WriteLine(i);
            //}
            //---------------------------------------------------------------------------------------------  

            //for(int i=3; i<=50; i +=3)
            //   {
            //       Console.WriteLine(i);
            //   }

            //---------------------------------------------------------------------------------------------  

            //kullanıcıya değer girdirerek kullanılan for döngüsü

            //Console.Write("Lütfen yazdırılma adetini giriniz : ");
            //int finish = int.Parse(Console.ReadLine());

            //for (int i=1; i<=finish; i++)
            //{
            //    Console.WriteLine("Türkiye Cumhuriyeti");
            //}


            #endregion

            #region DÖNGÜLER VE KARAR YAPILARI

            //for (int i = 0; i<=100; i++) //fot döngüsü ve if ile 100 e kadar olan sayıların 5 e bolunenlerı yazdırma
            //{

            //    if(i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }

            //}
            //--------------------------------------------------------------------------------------------------------
            //int totalvalue = 0;
            //for(int i=1; i<10; i++)
            //{
            //    totalvalue += i;
            //    Console.WriteLine(i);
            //}
            //c
            //Console.WriteLine(totalvalue);
            //--------------------------------------------------------------------------------------------------------

            //int totalvalue = 0;

            //for (int i = 1; i<20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        totalvalue+=i;
            //        Console.WriteLine(i);   
            //    }

            //}
            //Console.WriteLine("------------------");
            //Console.WriteLine(totalvalue);
            //--------------------------------------------------------------------------------------------------------

            //int count = 0; //1 - 50 arasında 7 ye tam bölünen sayıların adetini gösterir

            //for(int i=1; i<=50; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        count++;
            //    }

            //}
            //Console.WriteLine(count);
            //--------------------------------------------------------------------------------------------------------
            //soru : 1 bakterı turu her saatın sonunda kendını ıkıye bolerek cogaltmaktadır. 24 saatin sonunda kaç tane bakteri oluştur
            //olusan her bakterı de 2 ye bolunerek cogalır
            //int bacterium = 1; 
            //for(int i=1; i<=24; i++)
            //{
            //    bacterium *= 2;
            //    Console.WriteLine(i+" . saat sonunda : "+bacterium+ " olmuştur.");
            //}
            #endregion

            #region While Döngüsü

            //while şart yazılır
            //{ açılır işlemler içine yazılır }

            //int i = 1;
            //while (i <= 10)
            //{
            //    Console.WriteLine("merhaba");
            //    i++;
            //}
            //----------------------------------------------------------------------------------
            //int i = 1;
            //while (i <=20)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}
            //----------------------------------------------------------------------------------

            //int i = 1;
            //int total = 0;

            //while (i <=35)
            //{
            //    total += i;
            //    i++;
            //}

            //Console.WriteLine(total);
            //----------------------------------------------------------------------------------


            #endregion

            #region ÖRNEK SINAV SORUSU

            //klavyeden girilen 3 basamaklı sayının basamaklarını toplayan kodu yazınız..

            //Console.Write("Lütfen sayıyı giriniz: ");
            //int number = int.Parse(Console.ReadLine());
            //int ones, tens, hundreds; //birler, onlar ve yüzler basamaklarını bulmak için tanımlanan değişkenler
            //int sum; //basamakların toplamnını göstermek için tanımlanan değer

            //ones = number % 10;
            //tens = (number % 100)/10;
            //hundreds = number / 100;

            //Console.WriteLine("Girmiş olduğunuz sayının basamakları : " + ones +"-"+ tens +"-"+ hundreds);

            //sum=ones+tens+hundreds;

            //Console.WriteLine("Basamakların toplamı : " + sum);

            #endregion

            Console.ReadLine();
        }
    }
}
