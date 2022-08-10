using System;

namespace _2.soru
{
    class Program
    {
        static void Main(string[] args)
        {
            //Girilen sayının tek/çift olduğunu tespit eden uygulama

            Console.Write("Bir sayı giriniz: ");
            int deger=Convert.ToInt16(Console.ReadLine());
            if(deger%2==0)
            {
                Console.WriteLine("Sayı çifttir.");
            }
            else//deger%2==1
            {
                Console.WriteLine("Girilen sayı tektir");
            }
        }
    }
}