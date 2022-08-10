using System;

namespace _4.soru
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tek sayı girilene kadar çalışan (değer isteyen) uygulama
            int sayi=1; //çift old. için 0 dan başladı. herhangi bir çift sayıdan başlasın.
            while(sayi % 2 == 1)
            {
                Console.WriteLine("Sayı gir: ");
                sayi=Convert.ToInt16(Console.ReadLine());
            }
        }
    }
}
