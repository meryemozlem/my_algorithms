using System;

namespace _16.soru
{
    class Program
    {
        static void Main(string[] args)
        {
            //Günlük hayat problemi. işçinin alacağı maaş uygulaması.

            int toplam_calisma_saati,saatbasi_ucret,vardiya_saati;
            double maas;

            Console.Write("Toplam çalışma saati: ");
            toplam_calisma_saati=Convert.ToInt16(Console.ReadLine());
            Console.Write("Saat başı ücret ne kadar?");
            saatbasi_ucret=Convert.ToInt16(Console.ReadLine());
            Console.Write("Vardiyadaki çalışma saatiniz: ");
            vardiya_saati=Convert.ToInt16(Console.ReadLine());

            if(toplam_calisma_saati<40)
            {
                Console.WriteLine(vardiya_saati);
                Console.WriteLine("Vardiyada kazanılan para: " + (saatbasi_ucret*vardiya_saati));
                maas=(toplam_calisma_saati*saatbasi_ucret)+(saatbasi_ucret*vardiya_saati);
                Console.Write("Maaş: " +maas );
            }
            else if(toplam_calisma_saati>=40)
            {
                Console.WriteLine(vardiya_saati);
                Console.WriteLine("Vardiyada kazanılan para: " + (saatbasi_ucret*vardiya_saati*2));
                maas=(toplam_calisma_saati*saatbasi_ucret)+(saatbasi_ucret*vardiya_saati*2);
                Console.Write("Maaş: " +maas );
            }

            /*
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


            */
        }
    }
}