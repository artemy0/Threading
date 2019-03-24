using System;

namespace Threading
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Press any key to start the stopwatch.\n");
            Console.ReadKey();
            //Console.Clear();


            Stopwatch sw = new Stopwatch();

            sw.Start();

            Console.ReadKey();

            sw.Stop();

            //Console.Clear();
            Console.WriteLine("\n\nResult: " + sw.Result); //repeated output of results.


            Console.WriteLine("Press any key to close the program.");
            Console.ReadKey();
        }
    }
}




