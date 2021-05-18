using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingApplication
{
    class SortingAlgorithmTester
    {
        public void Test()
        {
            var values = (SortingAlgorithmType[])Enum.GetValues(typeof(SortingAlgorithmType));
            foreach (var algorithm in values)
            {
                int[] array = { 88, 12, 55, 105, 48, 84, 66, 35, 57, 89, 74, 106, 200, 541, 1, 9, 7, 55, 405, 13 };
                var sortAlgorithm = SortingFactory.Create(algorithm);
                sortAlgorithm.Sort(array);
                //logging the test results
                Logger.WriteLine($"sorting done using {algorithm}, needed {sortAlgorithm.Swapped} swaps to sort the array");
            }
        }
    }
}
