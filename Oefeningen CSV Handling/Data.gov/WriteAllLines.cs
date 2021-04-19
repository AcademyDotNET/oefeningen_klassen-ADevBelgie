using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Data.gov
{
    class WriteAllLines
    {
        public static async Task WriteLines(string[,] CSVInArray, int inputRecord, int inputEigenschap)
        {
            string[] lines =
            {
                $"Het opgevgraagt gegeven is: ",
                $"Eigenschap:\t{CSVInArray[0, inputEigenschap]}({inputEigenschap})",
                $"Record:\t {inputRecord}\t{CSVInArray[inputRecord, inputEigenschap]}",
                $"got this data on {DateTime.Now}"
            };

            await File.WriteAllLinesAsync("UserData.txt", lines);
        }
    }
}
