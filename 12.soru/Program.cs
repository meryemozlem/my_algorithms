using System;

namespace _12.soru
{
    class Program
    {
        static void Main(string[] args)
        {
            // Girlen ürünün KDV'li fiyatını bulan uygulama
            double fiyat,hesap;
            Console.WriteLine("Ürün fiyatını gir: ");
            fiyat=Convert.ToDouble(Console.ReadLine());
            
            hesap=(fiyat*0.18)+fiyat;
            Console.WriteLine("Ürün KDV'li yeni fiyatı: " + hesap);
        }
    }
}