using System;

namespace _23.soru
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcının gireceği m^3 cinsinden tarlaya, yükseklik ve yarıçap değerleri yine kullanıcının gireceği silindir varillerlerden kaç tane sığar?

            double thacim,h,r,shacim;
            //,pi
            Console.Write("Tarla kaç m^3: ");
            thacim=Convert.ToDouble(Console.ReadLine());
            Console.Write("Silindirin yüksekliğinin gir: ");
            h=Convert.ToDouble(Console.ReadLine());
            Console.Write("Silindirin yarıçapını gir: ");
            r=Convert.ToDouble(Console.ReadLine());

            //pi=(3.1415);
            shacim=(Math.Pow(r,2)*Math.PI*h);
            // Peki bu tarlaya kaç tane silindir sığar?
            int x=Convert.ToInt32(thacim/shacim);
            Console.WriteLine($"Bu tarlaya m^3 cinsinden {x} silinidir yerleşir.");
        }
    }
}