using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KAMPDERSI7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region FOREACH DÖNGÜSÜ

            //string[] cities = { "Bursa", "İzmir", "İstanbul", "Roma", "Ankara" };

            //foreach (string city in cities)
            //{
            //    Console.WriteLine(city);

            //}
            //--------------------------------------------------------------------------------- 


            //int[] numbers = { 12, 34, 56, 43, 97 };
            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}
            //--------------------------------------------------------------------------------- 

            //int[] numbers = { 12, 34, 56, 43, 97 };

            //foreach (int number in numbers)
            //{
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}

            //--------------------------------------------------------------------------------- 

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17 };

            //int total = 0;

            //foreach (int i in numbers)
            //{
            //    total += i;
            //}
            //Console.WriteLine(total);

            //--------------------------------------------------------------------------------- 



            #endregion

            #region LİSTE OLUŞTURMA VE FOREACH DÖNGÜSÜ İLE EKRANA YAZDIRMA

            //List<int> list = new List<int>()
            //{
            //    1,2,3,4,5,8
            //};

            //foreach (int i in list)
            //{
            //    Console.WriteLine(i);
            //}

            //------------------------------------------------------


            #endregion

            #region STRİNG OLAN KELİMEYI CHAR OLARAK PARÇALAMA

            //string word = "merhaba";

            //foreach (char c in word)
            //{
            //    Console.WriteLine(c);
            //}

            #endregion

            #region ÖRNEK SINAV SİSTEMİ UYGULAMASI

            Console.WriteLine("C# EĞİTİM KAMPI SINAV UUYGULAMASI");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Lütfen sınıfınızda bulunan öğrenci sayıısını giriniz : ");
            int studentCount = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine();

            string[] studentName = new string[studentCount];
            double[] studentExam = new double[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i + 1}. Öğrencinin adını giriniz : ");
                studentName[i] = Console.ReadLine();

                double totalExamResult = 0;


                //ÖĞRENCİYE AİT 3 SINAV NOTU GİRME
                for (int j = 0; j < 3; j++)
                {

                    Console.Write($"{studentName[i]} isimli öğrencinin {j + 1} sınav notunu giriniz : ");
                    double value = double.Parse(Console.ReadLine());
                    totalExamResult += value;
                }

                studentExam[i] = totalExamResult / 3;// NOT ORT HESAPLAMA

                //SINAV ORT 

                for (i = 0; i < studentCount; i++)

                {
                    Console.WriteLine($"{studentName[i]} adlı öğrencinin ortalaması : {studentExam[i]}");

                    if (studentExam[i] >= 50)
                    {
                        Console.WriteLine($"{studentName[i]} adlı öğrenci dersi geçti.");
                    }
                    else
                    {
                        Console.WriteLine($"{studentName[i]} adlı öğrenci dersten kaldı.");
                    }

                    Console.WriteLine("-----------------------------------------------");
                }


                #endregion

                Console.ReadLine();
            }
        }
    }
}

