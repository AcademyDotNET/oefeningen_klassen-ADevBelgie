using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace HiddenBookmark
{
    class HiddenBookmark: BookMark
    {
        override public void OpenSite()
        {
            Process.Start(@"C:\Program Files\Google\Chrome\Application\chrome.exe", "-incognito " + URL);  //Voeg bovenaan using System.Diagnostics; toe
        }
    }
}
