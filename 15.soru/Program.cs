using System;

namespace _15.soru
{
    class Program
    {
        static void Main(string[] args)
        {
            //Günlük hayat problemi. Maaş ve çocuk sayısı orantısı

            double maas,y_maas;
            int cocuk_sayisi;
            Console.Write("Maaşınızı giriniz: ");
            maas=Convert.ToDouble(Console.ReadLine());

            Console.Write("Çocuk sayısını giriniz: ");
            cocuk_sayisi=Convert.ToInt16(Console.ReadLine());

            if(cocuk_sayisi==0)
            {
                Console.Write("Destekli yeni maaş: " + maas);
            }
            else if(cocuk_sayisi==1)
            {
                y_maas=(maas*0.05)+maas;
                Console.WriteLine("Destekli yeni maaş: " + y_maas);
            }
            //if (cocuk_sayisi>0 && cocuk_sayisi==1)
            else if(cocuk_sayisi==2)
            {
                y_maas=(maas*0.10)+maas;
                Console.WriteLine("Destekli yeni maaş: " + y_maas);
            }
            else if (cocuk_sayisi>=3)
            {
                y_maas=(maas*0.15)+maas;
                Console.WriteLine("Destekli yeni maaş: " + y_maas);
            }


        }
    }
}