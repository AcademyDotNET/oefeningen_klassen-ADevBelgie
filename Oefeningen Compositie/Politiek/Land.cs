using System;
using System.Collections.Generic;
using System.Text;

namespace Politiek
{
    class Land
    {
        private President huidigePresident;
        private Minister huidigeEersteMinister;
        private List<Minister> Ministers;

        public void MaakRegering(President verkozenPresident, List<Minister> verkozenMinisters)
        {
            if (huidigePresident == null)
            {
                huidigePresident = verkozenPresident;
                huidigeEersteMinister = verkozenMinisters[0];
                Ministers = verkozenMinisters;
                Ministers.RemoveAt(0);
            }
            else
            {
                Console.WriteLine("Er is al een regering");
            }
        }
        public void JaarVerder()
        {
            if (huidigePresident != null)
            {
                huidigePresident.JaarVerder();
            }
            if(huidigePresident.Teller == 0)
            {
                huidigePresident = null;
                huidigeEersteMinister = null;
                Ministers = null;
            }
        }
        public override string ToString()
        {
            string returnString = $"Huidige President: {(huidigePresident != null ? huidigePresident.Naam : "niet verkozen")}\n";
            returnString += $"Er is {(huidigeEersteMinister==null?"g":"")}een eerste minister.\n";
            returnString += $"Er zijn {(Ministers != null ? Ministers.Count : "geen")} ministers.\n";

            return returnString;
        }
    }
}
