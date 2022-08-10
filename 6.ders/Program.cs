using System;

namespace _6.ders
{
    class Program
    {
        static void Main(string[] args)
        {
            //kare alan ve cevre hesabı
            int kenar,alan,cevre;
            Console.WriteLine("Karenin bir kenar uzunluğunu gir: ");
            kenar=Convert.ToInt16(Console.ReadLine());
            alan=(kenar*kenar);
            cevre=(4*kenar);
            Console.WriteLine("Alan: " + alan + "            " + "Çevre: " + cevre);
        }
    }
}