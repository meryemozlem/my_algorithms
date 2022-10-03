using System;

namespace _25.soru
{
    class Program
    {
        static void Main(string[] args)
        {
            // Örüntüyü bulan uygulama (n.adım)

            // 1. adımda 1 ~~ 2. adımda 5 ~~ 3. adımda 13 kare boyalıdır.
            int boyali(int n)
            {
                int start=1;
                int dif=0;
                for(int i=1; i<=n; i++)
                {
                    start+=dif;
                    dif+=4;
                }

                return start;
            }

        }
    }
}