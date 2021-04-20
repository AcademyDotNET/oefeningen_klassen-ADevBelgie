using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Data.gov
{
    class TxtWriter
    {
        public static void Write2DArrayToTXT(string[,] CSVInArray, int column, string path, string name)
        {
            string filePath = $@"{path}{name}.txt";

            using (StreamWriter sw = new StreamWriter(filePath))
            {
                sw.WriteLine($"Record\tEigenschap");
                for (int i = 0; i < CSVInArray.GetLength(0) - 1; i++)
                {
                    sw.WriteLine($"{i}\t{CSVInArray[i, column]}");
                }
            }
        }
    }
}
