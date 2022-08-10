using System;

namespace _7.ders
{
    class Program
    {
        static void Main(string[] args)
        {
            //dikdörtgen aln ve çevre hesabı

            int k_kenar,u_kenar,alan,cevre;
            Console.WriteLine("Kısa kenarı gir: ");
            k_kenar=Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Uzun kenarı gir: ");
            u_kenar=Convert.ToInt16(Console.ReadLine());
            alan=(k_kenar*u_kenar);
            cevre=2*(k_kenar+u_kenar);
            //cevre=(k_kenar*2)+(u_kenar*2);
            Console.WriteLine("Alan: " + alan+ "      "+ "Çevre: " +cevre );
        }
    }
}
