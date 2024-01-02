namespace threading
{
    internal class Program
    {
        static void Main0(string[] args)
        {
            Thread t1 = new Thread(Func1);
            t1.Start();

            Thread t2 = new Thread(Func2);
            t2.Start();

        }

        static void Main1()
        {
            Thread t1 = new Thread(Func1);
            t1.IsBackground = true;
            t1.Start();

            Thread t2 = new Thread(Func2);
            t2.IsBackground = true;
            t2.Start();


            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine("Main : " + i);
            }

        }

        static void Main3()
        {
            Thread t1 = new Thread(new ThreadStart(Func1));
            t1.Start();

            Thread t2 = new Thread(Func2);
            t2.Start();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Main :" + i);
            }
            t1.Join();
        }

        static void Main()
        {
            Thread t1 = new Thread(new ThreadStart(Func1));
            t1.Priority = ThreadPriority.Highest;
            t1.Start();

            Thread t2 = new Thread(Func2);
            t2.Priority = ThreadPriority.Lowest;
            t2.Start();

            for(int i = 0; i < 1000; i++)
            {
                Console.WriteLine("Main : " + i);
            }
        }


        static void Func1()
        {
            for (int i = 0; i<10; i++)
            {
                Console.WriteLine("First : " + i);
            }
        }

        static void Func2()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("second : " + i);
            }
        }
    }
}