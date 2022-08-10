using System;

namespace _8.ders
{
    class Program
    {
        static void Main(string[] args)
        {
            //faktöriyeli bulan uygulama
            int factorial=1;
            Console.Write("1 sayı dğeri gir, faktöriyelini bulayım: ");
            int sayi=Convert.ToInt16(Console.ReadLine());
            for(int i=1; i<=sayi; i++)
            {
                factorial*=i;
            }
            Console.WriteLine("Faktöriyel sonucu: " + factorial);
        }
    }
}
