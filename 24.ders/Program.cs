using System;

namespace _24.ders
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 dizinin tüm elemanlarını ekrana yazdırmak
            int [] dizi = {5,7,9,11,17,20};
            for(int i=0; i<dizi.Length; i++)
            {
                int a=dizi[i];
                Console.WriteLine(a);
            }

            // 1 diziye istenilen sayı kadar eleman eklemek
            
            Console.Write("Diziye kaç eleman ekleyeceksin?");
            int x=Convert.ToInt16(Console.ReadLine());

            int [] sayilar= new int [x];
            for(int i=0; i<x; i++)
            {
                Console.Write("Bir sayı giriniz: ");
                sayilar[i]=Convert.ToInt16(Console.ReadLine()); 
            }
            for(int k=0; k<sayilar.Length; k++)
            {
                int b=sayilar[k];
                Console.WriteLine(b);
            }
            
        }
    }
}