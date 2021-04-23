using System;
using System.Collections.Generic;
using System.Text;

namespace Book
{
    class Book
    {
        public int ISBN { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }

        protected double _Price;
        public virtual double Price
        {
            get { return _Price; }
            set { _Price = value; }
        }

        public static Book TelOp(Book book1, Book book2)
        {
            Book omnibus = new Book();
            //title "Omnibus van [X]" where x is the authors
            omnibus.Title = $"Omnibus van {book1.Author}, {book2.Author}";
            omnibus.Author = book1.Author + book2.Author;

            return omnibus;
        }

        public override string ToString()
        {
            //Ze tonen deze info als volgt: "Title - Auteur (ISBN) Price" (bv The Shining - Stephen King (05848152) 50)
            string _ToString = $"{Title} - {Author} ({ISBN}) {Price}";

            return _ToString;
        }
    }
}
