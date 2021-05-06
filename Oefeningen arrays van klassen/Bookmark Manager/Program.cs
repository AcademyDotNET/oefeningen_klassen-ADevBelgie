using System;
using System.Collections.Generic;
using System.Linq;

namespace Bookmark_Manager
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bookmark Manager\n");

            List<BookMark> bookmarks = new List<BookMark>();
            bookmarks.Add(new BookMark { Naam = "Bookmark 1", URL = @"https://www.hln.be/" });
            bookmarks.Add(new BookMark { Naam = "Bookmark 2", URL = @"https://www.nieuwsblad.be/tag/het-laatste-nieuws" });
            bookmarks.Add(new BookMark { Naam = "Bookmark 3", URL = @"https://www.youtube.com/" });
            bookmarks.Add(new BookMark { Naam = "Bookmark 4", URL = @"https://www.youtube.com/watch?v=dQw4w9WgXcQ" });
            bookmarks.Add(new BookMark { Naam = "Bookmark 5", URL = @"https://www.google.com/" });

            foreach (BookMark bookmark in bookmarks)
            {
                Console.WriteLine($"{bookmark.Naam}: {bookmark.URL}");
            }

            int index = -2;
            do
            {
                string userRequest;
                if (index == -1)
                {
                    Console.WriteLine($"That bookmark was not valid");
                }
                Console.WriteLine($"What bookmark do you want to open?");
                try
                {
                    userRequest = Console.ReadLine();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    userRequest = null;
                }

                index = bookmarks.FindIndex(b => b.Naam == userRequest);
            } while (index == -1);
            
            bookmarks[index].OpenSite();
            //bookmarks[0].OpenSite();
            //string[,] favBookmarks = new string[5, 2]
            //{
            //    {"Bookmark 1",@"https://www.hln.be/"},
            //    {"Bookmark 2",@"https://www.nieuwsblad.be/tag/het-laatste-nieuws"},
            //    {"Bookmark 3",@"https://www.youtube.com/"},
            //    {"Bookmark 4",@"https://www.youtube.com/watch?v=dQw4w9WgXcQ"},
            //    {"Bookmark 5",@"https://www.google.com/"}
            //};

        }
    }
}
