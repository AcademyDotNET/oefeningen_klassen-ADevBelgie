using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Bookmark_extra
{
    class HiddenBookmark: BookMark
    {
        override public void OpenSite()
        {
            Process.Start(@"C:\Program Files\Google\Chrome\Application\chrome.exe", "-incognito " + URL);  //Voeg bovenaan using System.Diagnostics; toe
        }

        override public string ToString()
        {
            string _ToString = $"{base.ToString()}  -- HIDDEN --";
            return _ToString; ;
        }
    }
}
