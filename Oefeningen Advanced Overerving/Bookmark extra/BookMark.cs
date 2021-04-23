using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Bookmark_extra
{
    class BookMark
    {
        public string Naam { get; set; }
        public string URL { get; set; }
        virtual public void OpenSite()
        {
            Process.Start(@"C:\Program Files\Google\Chrome\Application\chrome.exe", URL);  //Voeg bovenaan using System.Diagnostics; toe
        }

        override public string ToString()
        {
            string _ToString = $"{Naam} ( {URL} )";
            return _ToString;
        }
    }
}
