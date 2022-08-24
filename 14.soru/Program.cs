using System;

namespace _14.soru
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aritemtik ortalama bulan uygulama

             double ogrenci_sayi;
             double ort;
             int toplam=0;
            Console.Write("Sınfta kaç öğrenci olduğunu giriniz: ");
            ogrenci_sayi= Convert.ToInt16(Console.ReadLine());
            if(ogrenci_sayi<0 || ogrenci_sayi>1000)
            {
                Console.WriteLine("HATALI GİRİŞ, TEKRAR DENE!");
            }

            for(int i=1; i<=ogrenci_sayi; i++)
            {
                Console.WriteLine(i+". öğrencinin Notunu giriniz:");
                int not=Convert.ToInt16(Console.ReadLine());
                if(not<0 || not>100)
                {
                    Console.WriteLine("Hatalı değer girişi yaptın.");
                }
                toplam+=not;
            }
            
            ort=(toplam/ogrenci_sayi);
            Console.WriteLine("Sınıfın ortalaması: " + ort);

        }
    }
}