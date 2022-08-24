using System;

namespace _13.soru
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fahrenheit türünden girilen sıcaklığı celciusa ve kelvine çeviren uygulama
            double f_deger,c_deger,k_deger;
            Console.Write("Fahrenheit türünden sıcaklık değerini giriniz:");
            f_deger= Convert.ToDouble(Console.ReadLine());
            c_deger=(f_deger-32)*5/9;
            k_deger=(f_deger+459.67)*5/9;
            Console.WriteLine("Fahrenheit değeri {0} olan sıcaklığın Celcius değeri {1}, Kelvin cinsinden ise {2}'dir." ,f_deger,c_deger,k_deger);
        }
    }
}