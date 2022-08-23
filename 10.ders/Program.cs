using System;

namespace _10.ders
{
    class Program
    {
        static void Main(string[] args)
        {
            // Girilen sayının asal sayı old. bulan uygulama.
            int sayac=0;
            Console.WriteLine("Sayı giriniz: ");
            int sayi=Convert.ToInt16(Console.ReadLine());

            if(sayi==2)
            {
                Console.WriteLine("Sayı asaldır.");
            }
            else
            {
                for(int i=2; i<sayi;i++)
                {
                    if(sayi%i==0)
                    {
                        sayac++;
                    }
                }
                
                if(sayac>0)
                {
                    Console.WriteLine("Sayı asal değildir.");
                }

                else    //sayaç hala 0.
                {
                    Console.WriteLine("Sayı asaldır.");
                }                
            }
        }
    }
}