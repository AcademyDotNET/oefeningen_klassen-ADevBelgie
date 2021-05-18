using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingApplication
{
    class SortingAlgorithmQuick: SortingAlgorithm 
    {
        public override void Sort(int[] array)
        {
            Swapped = 0;
            Sort(array, 0, array.Length - 1);
        }
        public void Sort(int[] array, int Left, int Right)
        {
            int L = Left;
            int R = Right;
            int pivotValue = array[(Left + Right) / 2];

            do
            {
                while (array[L] < pivotValue)
                {
                    L++;
                }
                while (pivotValue < array[R])
                {
                    R--;
                }

                if (L <= R)
                {
                    Swap(L, R, array);
                    L++;
                    R--;
                }
            } while (L < R);

            if (Left < R)
            {
                Sort(array, Left, R);
            }
            if (L < Right)
            {
                Sort(array, L, Right);
            }
        }
    }
}
