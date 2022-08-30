using System;

namespace extralar
{
    class Program
    {
        static void Main(string[] args)
        { //OLMADI AMA NEDEN?
            double tl,dolar,euro,sterlin,rupi,ruble,donusum;
            Console.WriteLine("Kaç TL paranız var?");
            tl=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(tl+"TL'yi hangi yabancı para birimine çevireyim?"+"\n"+"dolar-->d        euro-->e        sterlin-->s     rupi-->r        ruble-->rb");
            string deger=Console.ReadLine();
            switch(deger)
            {
                case "d":
                    dolar=(18.17);
                    donusum=(tl/dolar);
                    Console.Write("{0} TL {1} Dolar eder.",tl,donusum);
                    break;
                case "e":
                    euro=(18.10);
                    donusum=(tl/euro);
                    Console.Write("{0} TL {1} Euro eder.",tl,donusum);
                    break;
                case "s":
                    sterlin=(21.43);
                    donusum=(tl/sterlin);
                    Console.Write("{0} TL {1} Sterlin eder.",tl,donusum);
                    break;
                case "r":
                    rupi=(0.23);
                    donusum=(tl/rupi);
                    Console.Write("{0} TL {1} Rupi eder.",tl,donusum);
                    break;
                case "rb":
                    ruble=(0.30);
                    donusum=(tl/ruble);
                    Console.Write("{0} TL {1} Ruble eder.",tl,donusum);
                    break;
            }
            //tl=Convert.ToDouble(Console.ReadLine());
        }
    }
}
