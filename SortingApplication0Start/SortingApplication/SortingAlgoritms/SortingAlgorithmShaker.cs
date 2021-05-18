using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingApplication
{
    class SortingAlgorithmShaker : SortingAlgorithm
    {
        public override void Sort(int[] array)
        {
            Swapped = 0;
            bool swapped = true;
            while (swapped)
            {
                swapped = false;
                for (int i = 0; i < array.Length - 1; ++i)
                {
                    if (array[i] > array[i + 1])
                    {
                        swapped = true;
                        Swap(i, i + 1, array);
                    }
                }

                if (!swapped) break;

                for (int i = array.Length - 2; i >= 0; --i)
                {
                    if (array[i] > array[i + 1])
                    {
                        swapped = true;
                        Swap(i, i + 1, array);
                    }
                }
            }
        }
    }
}
