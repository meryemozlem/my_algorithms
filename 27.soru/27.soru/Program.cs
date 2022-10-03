using System;

namespace _27.soru
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizzza vegeterianPizza = new Pizzza();
            vegeterianPizza.PizzaType ="Vegeterian Pizza";
            vegeterianPizza.Price = 25;

            Pizzza meatPizza = new Pizzza();
            meatPizza.PizzaType ="Meat Pizza";
            meatPizza.Price = 30;

            Console.Write("Enter 1 for vegeterian pizza, enter 2 for meat pizza  ");
            int selectedPizza =Convert.ToInt32(Console.ReadLine());
            int number = 0;
            double price = 0;

            if (selectedPizza == 1)
            {
                Console.Write("Enter number of selected pizza  ");
                number =Convert.ToInt32(Console.ReadLine());
                price = number * vegeterianPizza.Price;
            }

            else if (selectedPizza == 2)
            {
                Console.Write("Enter number of selected pizza  ");
                number = Convert.ToInt32(Console.ReadLine());
                price = number * meatPizza.Price;
            }

            Console.WriteLine("Total Price: " + price);
        }
    }
}