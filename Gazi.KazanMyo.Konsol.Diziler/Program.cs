using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gazi.KazanMyo.Konsol.Diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            //int toplam = 0;
            //int sayac = 0;
            //Console.WriteLine("Kaç Sayı Girilecek ?");
            //int isimsayi = byte.Parse(Console.ReadLine());
            //int[] sayilar = new int[isimsayi];
            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    Console.WriteLine((i + 1) + ". Sayıyı Giriniz ? :");
            //    sayilar[i] = byte.Parse(Console.ReadLine());
            //    toplam += sayilar[i];
            //}
            //Array.Sort(sayilar);
            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    Console.WriteLine((i + 1) + ". sayı =" + sayilar[i]);
            //}
            //Console.WriteLine("Ortalamanız =" + (toplam / isimsayi));
            //Console.ReadKey();

            //Console.WriteLine("Kaç Sayı Olacak ?");
            //int isimsayi = byte.Parse(Console.ReadLine());
            //int[] sayilar = new int[isimsayi];
            //Console.WriteLine("Başlangıç Sayısını Belirleyin");
            //int sayi1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Bitiş Sayısını Belirleyin");
            //int sayi2 = int.Parse(Console.ReadLine());
            //Random rnd = new Random();

            //if (sayi1>sayi2)
            //{
            //    int temp = sayi1;
            //    sayi1 = sayi2;
            //    sayi2 = temp;
            //}
            //for (int i = 0; i < sayilar.Length; i++)
            //{

            //    int random = rnd.Next(sayi1, sayi2);
            //    sayilar[i] = random;


            //}
            //Array.Sort(sayilar);
            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    Console.WriteLine(sayilar[i]);
            //}


            //Console.WriteLine("Satırı Giriniz");
            //int satir = int.Parse(Console.ReadLine());
            //Console.WriteLine("Sütunu Giriniz");
            //int sutun = int.Parse(Console.ReadLine());
            //string[,] dizi = new string[satir, sutun];
            //for (int i = 0; i < dizi.GetLength(0); i++)
            //{
            //    for (int j = 0; j < dizi.GetLength(1); j++)
            //    {
            //        dizi[i, j] = (i + j) % 2 == 0 ? "*" : " ";
            //    }
            //}
            //for (int i = 0; i < dizi.GetLength(0); i++)
            //{
            //    for (int j = 0; j < dizi.GetLength(1); j++)
            //    {
            //        Console.Write(dizi[i, j]);
            //    }
            //    Console.WriteLine();
            //}


            Console.WriteLine("Satırı Giriniz");
            int satir = int.Parse(Console.ReadLine());
            Console.WriteLine("Sütunu Giriniz");
            int sutun = int.Parse(Console.ReadLine());
            string[,] dizi = new string[satir, sutun];

            for (int i = 0; i < dizi.GetLength(0); i++)
            {
                for (int j = 0; j < dizi.GetLength(1); j++)
                {
                    Console.WriteLine("*");
                    

                }
            }



            Console.ReadKey();

        }
    }
}
