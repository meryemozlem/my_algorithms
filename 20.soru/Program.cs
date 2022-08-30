using System;

namespace _20.soru
{
    class Program
    {
        static void Main(string[] args)
        {
            // Döviz kuru hesaplayan uygulama.Kullanıcı tl girsin ben de kaç yabancı birim olduğunu hesaplayayım. , sonrası 3 rakam olsun.
            double tl,dolar,euro,sterlin,yen,ruble;
            Console.WriteLine("TL miktarını gir: ");
            tl=Convert.ToDouble(Console.ReadLine());

            dolar=Math.Round((tl/18.19),3);
            euro=Math.Round((tl/18.18),3);
            sterlin=Math.Round((tl/21.31),3);
            yen=Math.Round((tl/0.13),3);
            ruble=Math.Round((tl/0.30),3);
            

        Console.WriteLine($"Girdiğin TL miktarı {dolar} dolar ediyor.");
        Console.WriteLine($"Girdiğin TL miktarı {euro} euro ediyor.");
        Console.WriteLine($"Girdiğin TL miktarı {sterlin} sterlin ediyor.");
        Console.WriteLine($"Girdiğin TL miktarı {yen} yen ediyor.");
        Console.WriteLine($"Girdiğin TL miktarı {ruble} ruble ediyor.");

        //Console.WriteLine("{0} TL {1} dolar,{2} euro, {3} sterlin, {4} yen, {5} ruble eder." , tl, dolar, euro, sterlin, yen, ruble);
        }
    }
}