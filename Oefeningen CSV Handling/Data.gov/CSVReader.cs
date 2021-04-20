using System;
using System.Collections.Generic;
using System.Text;

namespace Data.gov
{
    class CSVReader
    {
        public static string[,] Read()
        {
            //init file
            System.Net.WebClient wc = new System.Net.WebClient();
            string urlCSVFile = @"https://app.leefmilieubrussel.be/lijsten/Docs/LISTS_OPEN_DATA_CSV/lijst_EPB_adviseurs_rechtspersonen.csv";
            string CSVFile = wc.DownloadString(urlCSVFile);

            //init vars
            char delimiter = ',';
            int countRecords = 0;
            //DateTime currentTime = new DateTime();

            //manipulate file data and input into 2D Array "CSVInArray"
            string trimmedCSVFile = CSVFile.Replace("\"", "").Replace("\r", "");
            string[] splitCSVFile = trimmedCSVFile.Split('\n');
            string[] headerCSVFile = splitCSVFile[0].Split(delimiter);
            string[,] CSVInArray = new string[splitCSVFile.Length, headerCSVFile.Length];

            foreach (string record in splitCSVFile)
            {
                string[] currentRecord = record.Split(delimiter);
                for (int i = 0; i < headerCSVFile.Length && i < currentRecord.Length; i++) //last line of csv file has record lenght of 1
                {
                    CSVInArray[countRecords, i] = currentRecord[i];
                }
                countRecords++;
            }
            return CSVInArray;
        }
    }
}
