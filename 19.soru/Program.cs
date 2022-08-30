using System;

namespace _19.soru
{
    class Program
    {
        static void Main(string[] args)
        {
            //Elektronik aletlerin harcadığı güç miktarını bulan ve fatura miktarının yazan uygulama
            //P=I*V V=I*R kw.h=p.h kw.h.fiyat=p.h.fiyat

            double akim,direnc,calistigi_saat,power,kwh,tutar;
            double fiyat=0.7102;

            Console.Write("Elektrikli aletten geçen akım kaç amper? ");
            akim=Convert.ToDouble(Console.ReadLine());
            Console.Write("Elektrikli aletin direnci kaç ohm? ");
            direnc=Convert.ToDouble(Console.ReadLine());
            Console.Write("Elektrikli alet kaç saat çalıştı? ");
            calistigi_saat=Convert.ToDouble(Console.ReadLine());

            power=(Math.Pow(akim,2)*direnc);            //P=I^2*R
            kwh=(power*calistigi_saat);                   
            tutar=(kwh*fiyat);
            Console.WriteLine("Ödenecek Tutar: " + tutar);
        }
    }
}