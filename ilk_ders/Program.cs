using System;

namespace ilk_ders
{
    class Program
    {
        static void Main(string[] args)
        {
            // number=please enter a number
            Console.Write("Bir sayı giriniz: ");
            int x=Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Girilen Sayı: " + x);

            /* 
            ilk girilen değer 5 ama onu 3 yaptık değişken değerini değiştirdik.
            int x=5;
            x=3;
            // yazacağımız değişkenin sbt olması için.
            Constant
            const int x=10;
            */

            /* Türü belli olmayan Değişkenler VAR her türlü değişknei sağlar.
            var x=5; bu andan itibaren var int e atandı.
            var x="Ela";
            BU KULLANIMDA (2 Sİ BİRLİKTE) HATA VERİR
            Tek 1 değere otomatik atandıktan sonra o değişkenin tipini alır.



            object de türü belli olmayan değişkendir. Tipi yoktur. Atama olduktan sonra tekrar yapılabilir.
            object x=5;
            object x="Ela"; HATA VERMEZ
            */
            // kullanıcıdan 2 sayı iste ve onları toplayıp ekrana yazdır.
            // Tüm işlemlere dönüşür.

            int ilk,ikinci,toplam; //double değişken tür de olurdu. Convert.ToDouble
            Console.Write("Lütfen 1. sayıyı gir: ");
            ilk=Convert.ToInt16(Console.ReadLine());
            Console.Write("2. sayıyı gir: ");
            ikinci=Convert.ToInt16(Console.ReadLine());
            toplam=(ilk+ikinci);
            Console.WriteLine("Sonuç: " + toplam);

            //Devamına dizileri ekle.
        }
    }
}
