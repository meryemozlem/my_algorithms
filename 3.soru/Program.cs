using System;

namespace _3.soru
{
    class Program
    {
        static void Main(string[] args)
        {
            // Klavyeden Sayılar girilecek ve ay tespit edilecek
            //if else ile ya da switch case ile yap.

            Console.WriteLine("Bir sayı gir: ");
            int deger=Convert.ToInt16(Console.ReadLine());
            switch(deger)
            {
                case 1 :
                    Console.WriteLine("Ocak");
                    break;
                case 2 :
                    Console.WriteLine("Şubat");
                    break;
                case 3 :
                    Console.WriteLine("Mart");
                    break;
                case 4 :
                    Console.WriteLine("Nisan");
                    break;
                case 5 :
                    Console.WriteLine("Mayıs");
                    break;
                case 6 :
                    Console.WriteLine("Haziran");
                    break;
                case 7 :
                    Console.WriteLine("Temmuz");
                    break;
                case 8 :
                    Console.WriteLine("Ağustos");
                    break;
                case 9 :
                    Console.WriteLine("Eylül");
                    break;
                case 10 :
                    Console.WriteLine("Ekim");
                    break;
                case 11 :
                    Console.WriteLine("Kasım");
                    break;
                case 12 :
                    Console.WriteLine("Aralık");
                    break;
                default:
                    Console.WriteLine("Hatalı değer girişi");
                    break;
                
            }
            


/*if(deger==1)
{
    Console.WriteLine("Ocak");
}
... böyle gidecek
*/

        }
    }
}
