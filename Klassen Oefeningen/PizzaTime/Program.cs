using System;

namespace PizzaTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PizzaTime\n");

            Pizza pizzaPeperoni = new Pizza();
            pizzaPeperoni.Toppings = "Salami";
            pizzaPeperoni.Diameter = -5;
            pizzaPeperoni.Price = 30;
            pizzaPeperoni.printPizza();

            Pizza pizzaHawai = new Pizza();
            pizzaHawai.Diameter = 12;
            pizzaHawai.Price = -20;
            pizzaHawai.printPizza();
        }
    }
}
