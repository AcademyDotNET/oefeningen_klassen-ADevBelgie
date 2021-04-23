using System;

namespace Book
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Book\n");

            Book normaalBoek = new Book();
            normaalBoek.Author = "Jeff";
            normaalBoek.ISBN = 500;
            normaalBoek.Title = "De jeff avonturen";
            normaalBoek.Price = 50000;

            TextBook textBoek = new TextBook();
            textBoek.Author = "Mark";
            textBoek.ISBN = 550;
            textBoek.Title = "Fantasie van Mark";
            textBoek.Price = 50000;

            CoffeeTableBook koffieBoek = new CoffeeTableBook();
            koffieBoek.Author = "Doortje";
            koffieBoek.ISBN = 560;
            koffieBoek.Title = "Doortje en de kampioenen";
            koffieBoek.Price = 0;

            //Boeken van de drie typen
            Console.WriteLine(normaalBoek);
            Console.WriteLine(textBoek);
            Console.WriteLine(koffieBoek);

            //Omnibus van 2 Boeken
            Book kleineOmni = Book.TelOp(normaalBoek, textBoek);
            Console.WriteLine(kleineOmni);

            //Omnibus van 3 Boeken
            Book groteOmni = Book.TelOp(kleineOmni, koffieBoek);
            Console.WriteLine(groteOmni);
        }
    }
}
