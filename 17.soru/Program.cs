using System;

namespace _17.soru
{
    class Program
    {
        static void Main(string[] args)
        {
            //online bankacılık uygulamasından para gönderilecek. önce limit kontrol et, limit 0 dan büyükse para gönderielecek. 
            //gönderilecek para 100 den az ise 1 tl,100-1000 arasında 3tl, 1000 ve üzerindeyse 5tl işlem ücreti alınır.
            //limit ve gönderilecek para miktarı girildiğinde toplam tutarı ekrana yazdıran uyg.
            double limit,para,islem_ucreti,kalan_limit;
            Console.WriteLine("Limitinizi giriniz: ");
            limit=Convert.ToDouble(Console.ReadLine());
            if(limit>0)
            {
                Console.WriteLine("Para gönderilebilir.");
                Console.WriteLine("Kaç TL göndermek istiyorsunuz ?");
                para=Convert.ToDouble(Console.ReadLine());
                if(para<=limit)
                {
                    if(para>0 && para<100)
                    {
                        islem_ucreti=para+1;
                        kalan_limit=(limit-islem_ucreti);
                        Console.WriteLine("Genel Tutar: " + islem_ucreti);
                        Console.WriteLine("Kalan Tutar: " + kalan_limit);
                    }
                    else if(para>=100 && para<1000)
                    {   
                        islem_ucreti=para+3;
                        kalan_limit=(limit-islem_ucreti);
                        Console.WriteLine("Genel Tutar: " + islem_ucreti);
                        Console.WriteLine("Kalan Tutar: " + kalan_limit);
                    }
                    else if(para>=1000)
                    {
                        islem_ucreti=para+5;
                        kalan_limit=(limit-islem_ucreti);
                        Console.WriteLine("Genel Tutar: " + islem_ucreti);
                        Console.WriteLine("Kalan Tutar: " + kalan_limit);
                    }
                }
                else
                {
                    Console.WriteLine("Limitinizden fazla para gönderemezsiniz.");
                }
            }
            else
            {
                Console.WriteLine("işlem gerçekleştirilemez.");
            }
            

        }
    }
}