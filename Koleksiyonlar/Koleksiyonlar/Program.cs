using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Dizeler Örnekleri
            #region Örnek 1
            // int[] sayilar = new int[5];
            //string[] isimler = new string[5];
            //bool[] durumlar = new bool[5];
            //double[] kesirler = new double[5];
            //sayilar[0] = 5;
            //sayilar[1] = 3;
            //sayilar[2] = 59;
            //sayilar[3] = 55;
            //sayilar[4] = 17;
            //isimler[0] = "Utku";
            //isimler[1] = "Arda";
            //isimler[2] = "Furkan";
            //isimler[3] = "Emir";
            //isimler[4] = "Celal";
            //durumlar[0] = true;
            //durumlar[1] = true;
            //durumlar[2] = true;
            //durumlar[3] = false;
            //durumlar[4] = false;
            //kesirler[0] = 1.15;
            //kesirler[1] = 1.16;
            //kesirler[2] = 1.17;
            //kesirler[3] = 1.18;
            //kesirler[4] = 1.19;
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("Sayılar :  " + sayilar[i]);
            //    Console.WriteLine("İsimler :  " + isimler[i]);
            //    Console.WriteLine("Durumlar :  " + durumlar[i]);
            //    Console.WriteLine("Kesirler :  " + kesirler[i]);
            //}
            //Console.ReadKey();
            #endregion
            #region Örnek 2
            // Farklı Değer Atamaları
            //int[] sayilar = new int[] { 5, 6, 7, 8, 9 };
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(sayilar[i]);
            //}


            //string[] isimler = { "UTKU", "FURKAN", "ARDA", "EMİR", "CELAL" };
            //foreach (var item in isimler)
            //{
            //    Console.WriteLine(item);
            //}


            //int[] sayilar2 = new int[10]; //Tek satırda tanımlama


            //int[] sayilar3;         // 2 satırda dizi tanımlama
            //sayilar = new int[10];


            //int[] sayilar4 = { 5, 7, 12, 36 };
            //// tanımlama sırasında int tipi diziye değer girişi  
            //string[] isimler2 = { "Ahmet", "Mehmet", "Burak", "Hasan" };
            //// tanımlama sırasında string tipinde diziye değer girişi  
            //char[] harfler = { 'k', 'l', 'h', 'Y' };
            //// tanımlama sırasında char tipindeki diziye değer atama
            //#endregion
            //#region Örnek 3
            //int mevcut=0;
            //Console.Write("Sınıf mevcudunu Girin : ");
            //mevcut = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine();
            //string[] ogrenci = new string[mevcut];

            //for(int i=0;i<mevcut;i++)
            //{
            //    Console.Write("Öğrenci Adını Girin : ");
            //    ogrenci[i]=Console.ReadLine();
            //}
            #endregion
            #region Örnek 3
            //int mevcut=0;
            //Console.Write("Sınıf mevcudunu Girin : ");
            //mevcut = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine();
            //string[] ogrenci = new string[mevcut];

            //for(int i=0;i<mevcut;i++)
            //{
            //    Console.Write("Öğrenci Adını Girin : ");
            //    ogrenci[i]=Console.ReadLine();
            //}

            //Console.ReadKey();
            #endregion
            #region Örnek 4

            //int pozitif = 0;
            //int negatif = 0;
            //int notr = 0;
            //Random rnd = new Random();

            //int[] sayilar = new int[20];

            //for (int i = 0; i < 20;i++ )
            //{
            //    sayilar[i] = rnd.Next(-100, 100);
            //}

            //foreach(int sayi in sayilar)
            //{
            //    Console.WriteLine(sayi);
            //    if(sayi>0)
            //    {
            //        pozitif++;
            //    }
            //    else if(sayi<0)
            //    {
            //        negatif++;
            //    }
            //    else
            //    {
            //        notr++;
            //    }
            //}
            //Console.WriteLine("Pozitif Sayı Adeti>>> " + pozitif);
            //Console.WriteLine("Negatif Sayı Adeti>>> " + negatif);
            //Console.WriteLine("İşaretsiz Sayı Adeti>>> " + notr);
            #endregion
            #region Örnek 5
            int sayac = 0;
            Random rnd = new Random();
            int rast;
            int[] sayilar2 =  new int[20];
            for (int i = 0; i < 20; i++)
            {
                rast = rnd.Next(1, 100);
                Console.WriteLine("Rastgele Sayı : " + rast);
                sayilar2[i] = rast;
            }
            Console.WriteLine("=====================");
            foreach (int sayi in sayilar2)
            {

                if (sayi % 2 == 1)
                {
                    sayac++;
                    
                    Console.WriteLine(sayi + 1);
                }

            }
            Console.WriteLine("Tek sayı adeti= " + sayac);

            Console.ReadKey();
            #endregion
            #endregion
            Console.ReadKey();
        }
    }
}
