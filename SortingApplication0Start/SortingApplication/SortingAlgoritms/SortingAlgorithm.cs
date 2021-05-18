using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingApplication
{
    enum SortingAlgorithmType
    {
        Bubble,
        Shaker,
        Quick
    }
    abstract class SortingAlgorithm
    {
        public int Swapped { get; set; }
        public abstract void Sort(int[] array);
        protected void Swap(int index1, int index2, int[] array)
        {
            int temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;
            Swapped++;
        }
    }
}
