using System;
using System.Collections.Generic;

namespace Oef_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public enum Kleuren
    {
        geel,
        groen,
        blauw,
        all
    }
    public class Product
    {
        public string Naam { get; set; }
        public Kleuren Kleur { get; set; }
        public int Grootte { get; set; }
    }
    public class Filter
    {
        public List<Product> FilterMethod(List<Product> lijst, Kleuren kleur = Kleuren.all, int grootte = -1)
        {
            var tmp = new List<Product>(); //new is glue

            if (grootte != -1 && kleur != Kleuren.all)//sort based on size && color
            {
                foreach (var p in lijst)
                {
                    if (p.Kleur == kleur && p.Grootte == grootte)
                        tmp.Add(p);
                }
            }
            else if (kleur != Kleuren.all)//sort based on color
            {
                foreach (var p in lijst)
                {
                    if (p.Kleur == kleur)
                        tmp.Add(p);
                }
            }
            else if (grootte != -1)//sort based on size
            {
                foreach (var p in lijst)
                {
                    if (p.Grootte == grootte)
                        tmp.Add(p);
                }
            }
            

            return tmp;
        }
    }
}
