using System;

namespace _16.soru
{
    class Program
    {
        static void Main(string[] args)
        {
            //Günlük hayat problemi. işçinin alacağı maaş uygulaması.
            int saat_ucreti;         //1 saat çalıştığında alacağı ücret
            int toplam_calisma_saati;
            double calistigi_saat;
            double maas;

            Console.Write("Saat başı ücret ne kadar?");
            saat_ucreti=Convert.ToInt16(Console.ReadLine());

            Console.Write("işçi kaç saat çalıştı:");
            calistigi_saat=Convert.ToDouble(Console.ReadLine());

            if(calistigi_saat<40)
            {
                maas=(calistigi_saat*saat_ucreti);
                Console.WriteLine("Alacağı maaş: " + maas);
            }
            else if(calistigi_saat>=40)
            {
                maas=calistigi_saat*(2*saat_ucreti);
                Console.WriteLine("Alacağı maaş: " + maas);
            }
        }
    }
}