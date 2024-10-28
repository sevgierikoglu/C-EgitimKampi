    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KAMPDERSI5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ALT ALTA YILDIZ OLUŞTURMA

            //for (int i=1; i<=10; i++)
            //{
            //    Console.WriteLine("*");
            //}

            #endregion

            #region YAN YANA YILDIZ OLUŞTURMA

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.Write("*");
            //}
            //----------------------------------------------------------------------------

            #endregion

            #region YAN YANA YILDIZ OLUŞTURMA HER SATIRDA 10 TANE OLSUN

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("**********");
            //}

            #endregion

            #region DİK ÜÇGEN OLUŞTURMA


            //for (int i = 1; i <= 10; i++)
            //{
            //   for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region TERS DİK ÜÇGEN OLUŞTURMA


            //for (int i = 5; i >= 1; i--)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region DİK VE TERS DİK ÜÇGEN BERABER


            //for (int i = 1; i <= 10; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //for (int i = 10; i >= 1; i--)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region BAKLAVA DİLİMİ

            //int n = 5; //baklava diliminin kaç satırdam oluşaccağını belirledik

            //// üst kısım
            //for (int i = 1; i <= n; i++) 

            //{
            //    for (int j = n - 1; j > 0; j--)
            //    {
            //        Console.Write(" "); // bu kısıma kadar olan kısım sağ taraftan boşluk bırakmak için kodlandı
            //    }
            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();

            //}
            //// alt kıısm 
            //for (int i=n-1; i>=1; i--) 
            //{
            //    for (int j=n-1; j>0; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k=1; k<=2*i-1; k++)
            //    {
            //       Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region PİRAMİT DESENİ OLUŞTURMA

            //int n = 5;
            //for (int i=1; i<=n; i++)
            //{
            //    // boşluk için 
            //    for (int j=n-i; j>0; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    // yıldızlar için 
            //    for (int k=1; k<=2*i-1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region TERS PİRAMİT OLUŞTURMA

            //int n = 5;

            //for(int i=n; i>=1; i--)
            //{
            //    //boşluklar
            //    for (int j=n-i; j>0; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    //yıldızlar
            //    for (int k=1; k<=2*i-1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}


            #endregion
            Console.ReadLine();
        }
    }
}
