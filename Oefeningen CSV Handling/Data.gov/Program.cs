using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.gov
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Data.gov\n");

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
                string[] currentRecord = splitCSVFile[countRecords].Split(delimiter);
                for (int i = 0; i < headerCSVFile.Length && i < currentRecord.Length; i++) //last line of csv file has record lenght of 1
                {
                    CSVInArray[countRecords, i] = currentRecord[i];
                }
                countRecords++;
            }

            //input user
            for (int j = 0; j < headerCSVFile.Length; j++)
            {
                Console.Write($"{CSVInArray[0,j]} ({j}){(j < headerCSVFile.Length-1?",": "")} ");
            }
            Console.WriteLine("\nGeef welke eigenschap je wilt:");
            int inputEigenschap = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Geef van welke record je hem wilt({1}-{countRecords-2}):");
            int inputRecord = Convert.ToInt32(Console.ReadLine());

            //output console
            Console.WriteLine($"Het opgevgraagt gegeven is {CSVInArray[inputRecord, inputEigenschap]}");
            Console.WriteLine(DateTime.Now);

            //output text file
            Console.WriteLine($"writing to text file... ");
            await WriteAllLines.WriteLines(CSVInArray, inputRecord, inputEigenschap);
            Console.ReadLine();
        }
    }
}
