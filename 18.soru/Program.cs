using System;

namespace _18.soru
{
    class Program
    {
        static void Main(string[] args)
        {
            //girilen sayılardan en büyüğünü ve en küçüğünü bulan uygulama

            int max=0;
            int min=9999999;            //0 yazsaydık, hiç 0 girmesem bile bana min değeri 0 yollardı.Bu istenmeyen bir olay.
            for(int i=1;i<=10;i++)
            {
                Console.Write("Sayı gir: ");
                int number=Convert.ToInt16(Console.ReadLine());

                if(number>max)
                {
                    max=number;
                }
                if(number<min)
                {
                    min=number;
                }

            }

            Console.WriteLine("En büyük değer: " + max+"\n"+"En küçük değer: " + min);
            
            /*
            Kod:
            int [] sayilar=new int [10] {8,-3,5,0,9,10,18,6,32,27};
            int max=0;
            int min=0;
            for(int i=0; i<10; i++)
            {
                if(sayilar[i] >max )
                {
                    max=sayilar[i];
                }
                else if(sayilar[i]<min)
                {
                    min=sayilar[i];
                }
            }
            Console.WriteLine("Max değer: "+ max);
            Console.WriteLine("Min değer: "+ min);
            */
        }
    }
}