using System;
using System.Collections.Generic;

namespace oef_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    public abstract class Shape
    {
        public abstract double Opp();
    }
    class Circle : Shape
    {
        public int straal;
        public Circle(int s)
        {
            straal = s;
        }
        public override double Opp()
        {
            return straal * straal * Math.PI;
        }
    }
    class Square : Shape
    {
        public int lengte;
        public Square(int l)
        {
            lengte = l;
        }
        public override double Opp()
        {
            return lengte * lengte;
        }
    }
    class OppBerekenaar
    {
        List<Shape> lijst;
        public OppBerekenaar()
        {
            lijst = new List<Shape>();
        }
        public void VoegToe(Shape s)
        {
            lijst.Add(s);
        }
        private double Sum()
        {
            double total = 0;
            foreach (Shape s in lijst)
            {
                total += s.Opp();
            }
            return total;
        }
        public string Output()
        {
            return "<h1> Totale som = " + Sum() + " </h1> ";
        }
    }
}
