using System;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            LetsTry();

            Console.ReadLine();
        }
        static void LetsTry()
        {
            try
            {
                Console.WriteLine("Try");
                return;
                Console.WriteLine("Try after return");
            }
            catch (Exception e)
            {
                Console.WriteLine("Catch");
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Finally");
            }
            Console.WriteLine("End of letsTry");
        }
    }
}
