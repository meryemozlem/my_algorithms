using System;

namespace _11.soru
{
    class Program
    {
        static void Main(string[] args)
        {
            // Vize ve Final notlarının ortalamasını bulan uygulama. Vize*%40+Final*%60=ortlama. Bne buna if else ekleyip dersten geçme kalam drumuna bakacağım.
            int vize,final;
            double ortalama;

            Console.Write("Vize notunu gir: ");
            vize=Convert.ToInt16(Console.ReadLine());
            if(vize<0|| vize>100)
            {
                Console.WriteLine("Hatalı giriş,tekrar dene!");
            }
            Console.Write("Final notunu gir: ");
            final=Convert.ToInt16(Console.ReadLine());
            if(final<0 || final>100)
            {
                Console.WriteLine("Hatalı değer girişi, tekrar dene.");
            }

            ortalama=(vize*0.4+final*0.6);
            Console.WriteLine("Ortalama: " + ortalama);

            if(ortalama>=50)
            {
                Console.WriteLine("Tebrikler dersten {0} ile geçtin!",ortalama);
            }
            else
            {
                Console.WriteLine("Maalesef dersten kadın!");
            }
        }
    }
}