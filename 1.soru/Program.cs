using System;

namespace _1.soru
{
    class Program
    {
        static void Main(string[] args)
        {
            //Klavyeden girilen sayının + - veya 0 olduğunu bulan uygulama

            Console.Write("Bir sayı giriniz: ");
            int sayi=Convert.ToInt16(Console.ReadLine());
            if(sayi>0)
            {
                Console.WriteLine("Sayı pozitiftir.");
            }
            else if(sayi==0)
            {
                Console.WriteLine("Sayı 0 dır.");
            }
            else
            {
                Console.WriteLine("Sayı negatiftir.");
            }
        }
    }
}
