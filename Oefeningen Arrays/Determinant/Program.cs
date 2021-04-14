using System;

namespace Determinant
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Determinant\n");

            int[,] aMatrix = {
                                    {2, 4},
                                    {3, 5}
                                };

            BerekenDeterminant(aMatrix);

            Console.WriteLine($"Determinant van matrix is {BerekenDeterminant(aMatrix)}");
        }

        private static object BerekenDeterminant(int[,] aMatrix)
        {
            throw new NotImplementedException();
        }
    }
}


