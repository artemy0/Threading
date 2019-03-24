using System;
using System.Threading;

namespace Threading
{
    class Stopwatch
    {
        private bool Stopped;
        private int AccuracyInMilliseconds;
        private Thread t;

        public TimeSpan Result { get; private set; } = TimeSpan.Zero;

        public Stopwatch(int accuracyInMilliseconds = 10)
        {
            AccuracyInMilliseconds = accuracyInMilliseconds;
        }

        public void Start()
        {
            Stopped = false;

            //increase time in a separate thread.
            t = new Thread(new ThreadStart(() =>
            {
                Console.WriteLine("Press any button to stop the stopwatch.");
                //the time when we started counting.
                DateTime start = DateTime.Now;

                while (!Stopped)
                {
                    //disable cursor visibility to remove unwanted blinking
                    Console.CursorVisible = false;

                    Console.CursorLeft = 0;
                    Result = DateTime.Now - start; //the time that has passed since we started.
                    Console.Write(Result);

                    Thread.Sleep(AccuracyInMilliseconds);
                }

                //return cursor visibility
                Console.CursorVisible = true;
            }));

            t.Start();
        }

        public void Stop()
        {
            Stopped = true;
            t.Join();
        }
    }
}
