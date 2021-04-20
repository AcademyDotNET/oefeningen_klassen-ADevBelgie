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

            //get file from web and input into array
            string[,] CSVInArray = CSVReader.Read();

            //input user
            for (int j = 0; j < CSVInArray.GetLength(1); j++)
            {
                Console.Write($"{CSVInArray[0,j]} ({j}){(j < CSVInArray.GetLength(1)- 1?",": "")} ");
            }
            Console.WriteLine("\nGeef welke eigenschap je wilt:");
            int inputEigenschap = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Geef van welke record je hem wilt({1}-{CSVInArray.GetLength(0) - 2}):");
            int inputRecord = Convert.ToInt32(Console.ReadLine());

            //output console
            Console.WriteLine($"Het opgevgraagt gegeven is {CSVInArray[inputRecord, inputEigenschap]}");
            Console.WriteLine(DateTime.Now);

            //output 1 cell text file
            Console.WriteLine($"writing to text file... ");
            await WriteEenCel.WriteLines(CSVInArray, inputRecord, inputEigenschap);
            Console.ReadLine();

            //output 1 eigenschap text file
            string filePath = $@"C:\Users\Özge\Desktop\Arthur Programming tests";
            DateTime currentDate = DateTime.Now;
            string fileName = $@"\{CSVInArray[0, inputEigenschap]}_{currentDate.ToString("dd-MM-yyyy_HH-mm")}"; //example: locatie_20-04-2021_10-29
            TxtWriter.Write2DArrayToTXT(CSVInArray, inputEigenschap, filePath, fileName);
        }
    }
}
