using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingApplication
{
    static class SortingFactory
    {
        static public SortingAlgorithm Create(SortingAlgorithmType sortStyle)
        {
            //make use of Activator.CreateInstance
            try
            {
                SortingAlgorithm sortingAlgorithm = (SortingAlgorithm)Activator.CreateInstance(Type.GetType($"SortingApplication.SortingAlgorithm{sortStyle}"));

                return sortingAlgorithm;
            }
            catch (Exception)
            {
                SortingAlgorithm sortingAlgorithm = new SortingAlgorithmNull();

                return sortingAlgorithm;
            }
        }
    }
}
