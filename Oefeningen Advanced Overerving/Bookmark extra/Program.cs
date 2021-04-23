using System;
using System.Collections.Generic;

namespace Bookmark_extra
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bookmark Extra\n");

            List<BookMark> bookmarks = new List<BookMark>();
            bookmarks.Add(new BookMark { Naam = "Bookmark 1", URL = @"https://www.hln.be/" });
            bookmarks.Add(new BookMark { Naam = "Bookmark 2", URL = @"https://www.nieuwsblad.be/tag/het-laatste-nieuws" });
            bookmarks.Add(new BookMark { Naam = "Bookmark 3", URL = @"https://www.youtube.com/" });
            bookmarks.Add(new BookMark { Naam = "Bookmark 4", URL = @"https://www.youtube.com/watch?v=dQw4w9WgXcQ" });
            bookmarks.Add(new BookMark { Naam = "Bookmark 5", URL = @"https://www.google.com/" });

            List<HiddenBookmark> hiddenBookmarks = new List<HiddenBookmark>();
            hiddenBookmarks.Add(new HiddenBookmark { Naam = "Bookmark 1", URL = @"https://www.hln.be/" });
            hiddenBookmarks.Add(new HiddenBookmark { Naam = "Bookmark 2", URL = @"https://www.nieuwsblad.be/tag/het-laatste-nieuws" });
            hiddenBookmarks.Add(new HiddenBookmark { Naam = "Bookmark 3", URL = @"https://www.youtube.com/" });
            hiddenBookmarks.Add(new HiddenBookmark { Naam = "Bookmark 4", URL = @"https://www.youtube.com/watch?v=dQw4w9WgXcQ" });
            hiddenBookmarks.Add(new HiddenBookmark { Naam = "Bookmark 5", URL = @"https://www.google.com/" });

            foreach (BookMark bookmark in bookmarks)
            {
                Console.WriteLine(bookmark);
            }

            int index = -2;
            do
            {
                if (index == -1)
                {
                    Console.WriteLine($"That bookmark was not valid");
                }
                Console.WriteLine($"What bookmark do you want to open?");
                string userRequest = Console.ReadLine();

                index = bookmarks.FindIndex(b => b.Naam == userRequest);
            } while (index == -1);

            Console.WriteLine("Incognito (0) or normal (1)");
            int userChoice;
            do
            {
                userChoice = Convert.ToInt32(Console.ReadLine());
                switch (userChoice)
                {
                    case 0:
                        hiddenBookmarks[index].OpenSite();
                        break;
                    case 1:
                        bookmarks[index].OpenSite();
                        break;
                    default:
                        Console.WriteLine("Please give: Incognito (0) or normal (1)");
                        break;
                }
            } while (userChoice != 1 && userChoice != 0);
        }
    }
}
