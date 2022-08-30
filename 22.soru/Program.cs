using System;

namespace _22.soru
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 aracın belirli hızla, belli bir yolu ne kadar sürede alacağını bulan uygulama. X= V * t ;

            double hiz,yol,zaman;
            Console.Write("Araç hızını m/s cinsinden giriniz: ");
            hiz=Convert.ToDouble(Console.ReadLine());
            Console.Write("Yol uzunluğunu metre cinsinden giriniz: ");
            yol=Convert.ToDouble(Console.ReadLine());

            zaman=(yol/hiz);
            Console.WriteLine("Bu araç {0} m/s hızla {1} metre yolu {2} saatte alır.", hiz,yol,zaman);
        }
    }
}