namespace funcWithPara
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(new ParameterizedThreadStart(Func1));
            int x = 10;
            t1.Start(x);

            Thread t2 = new Thread(Func2);
            string s = "passed value";
            t2.Start(s);
            for(int i=0; i<10; i++)
            {
                Console.WriteLine("main : " + i);
            }
        }
            static void Func1 (object obj){
            int x = (int)obj;
                    for(int i=0; i<10; i++)
                    {
                        Console.WriteLine("first :" + i + x);
                    }
        }

        static void Func2(object obj)
        {
            string s = obj.ToString();
            for(int i=0; i<10; i++)
            {
                Console.WriteLine("second :" + i + s);
            }

        }
    }
}