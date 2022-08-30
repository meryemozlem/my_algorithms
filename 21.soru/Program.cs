using System;

namespace _21.soru
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2.dereceden denklemin köklerini bulan uygulama
            double a,b,c,delta;

            Console.Write("2.dereceden denklemi için şu değerleri giriniz." + "\n" + "x^2 nin katsayısını (a) giriniz: ");
            a=Convert.ToDouble(Console.ReadLine());
            Console.Write("x'in katsayısını (b) giriniz: ");
            b=Convert.ToDouble(Console.ReadLine());
            Console.Write("c sabitini giriniz: ");
            c=Convert.ToDouble(Console.ReadLine());
            
            delta= (Math.Pow(b,2)-4*a*c);

            if(delta>0)
            {
                Console.WriteLine("Reel kök vardır ve 2 tanedir.");
                double kok1=(-b+Math.Sqrt(delta))/2*a;
                double kok2=(-b-Math.Sqrt(delta))/2*a;
                Console.WriteLine($"Kök1: {kok1}");
                Console.WriteLine($"Kök2: {kok2}");
                //Console.WriteLine("Kök1: " + kok1);
            }
            
            else if (delta==0)
            {   //double kok1 = double kok2;
                Console.WriteLine("Reel kök çakışıktır. 2 kök birbirine eşittir.");
                double kok1=(-b)/2*a;
                Console.WriteLine($"Kök1= Kök2 {kok1}");
            }

            //else if (delta<0)
            else
            {
                Console.WriteLine("Reel kök yoktur. Çözüm kümesi boş kümedir.");
            }
        }
    }
}