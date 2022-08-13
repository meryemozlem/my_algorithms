using System;

namespace _9.ders
{
    class Program
    {
        static void Main(string[] args)
        {
            //çarpma operatörünü kullanmadan çarpma işlemi yapan uygulama
            int sonuc=0;

            Console.WriteLine("1. sayıyı gir: ");
            int sayi_1=Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("2. sayıyı gir: ");
            int sayi_2=Convert.ToInt16(Console.ReadLine());

            for(int i=1;i<=sayi_1;i++)      // Tur sayısı
            {
                sonuc+=sayi_2;              //döngü kadar toplama eklenir.
            }

            Console.WriteLine("Sonuç: " + sonuc);


        }
    }
}

