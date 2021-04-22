using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace HiddenBookmark
{
    class BookMark
    {
        public string Naam { get; set; }
        public string URL { get; set; }
        virtual public void OpenSite()
        {
            Process.Start(@"C:\Program Files\Google\Chrome\Application\chrome.exe", URL);  //Voeg bovenaan using System.Diagnostics; toe
        }
    }
}
