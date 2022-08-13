using System;

namespace _10.ders
{
    class Program
    {
        static void Main(string[] args)
        {
            // Girilen sayının asal sayı old. bulan uygulama
            int sayac=0;
            Console.WriteLine("Bir sayı giriniz: ");
            int sayi=Convert.ToInt16(Console.ReadLine());   
            for(int i=2; i<sayi; i++)
            {
                if(sayi%i==0)
                {
                    sayac++;
                }
            }

            if (sayac == 0)
            {
                Console.WriteLine("Girilen Sayı Asal");
            }
            else
            {
                Console.WriteLine("Girilen Sayı Asal Değil");
            }
        }
    }
}