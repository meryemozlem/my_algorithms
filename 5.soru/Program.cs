using System;

namespace _5.soru
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 100 arası sayıları toplayan uygulama
            //int sayi=0;
            int toplam=0;
            for(int i=1; i<=100 ;i++ )
            {
                toplam+=i; //toplam=toplam+sayi;
            }
             Console.WriteLine("Toplam: " +toplam );
        }
    }
}