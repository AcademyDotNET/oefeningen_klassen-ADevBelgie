using System;
using System.Collections.Generic;
using System.Text;
using static System.Math;

namespace PizzaTime
{
    class Pizza
    {
        string _toppings = "tomatensaus, kaas";
        int _diameter;
        double _price;

        public string Toppings
        {
            get { return _toppings; }
            set { _toppings += $", {value}"; }
        }
        public int Diameter
        {
            get { return _diameter; }
            set { _diameter = Math.Max(value, 10); }
        }
        public double Price
        {
            get { return _price; }
            set { _price = Math.Max(value, 0); }
        }

        public void printPizza()
        {
            Console.WriteLine("toppings: "+_toppings);
            Console.WriteLine("diameter: " + _diameter);
            Console.WriteLine($"Prijs: {+ _price}");
            return;
        }
    }
}
