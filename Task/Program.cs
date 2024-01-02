using System.Collections;

namespace ThreadingArrayToDo
{
    internal class program
    {
        static void Main()
        {
            //Arrays
            Thread t1 = new Thread(Func1);
            int[] arr = { 10, 20, 30, 40, 50 };
            t1.Start(arr);


            //Collection
            ArrayList a = new ArrayList();
            a.Add(10);
            a.Add(20);
            a.Add(30);
            Thread t2 = new Thread(new ParameterizedThreadStart(Func2));
            t2.Start(a);


            //Anonymous method
            Thread t3 = new Thread(delegate (object obj)
            {
                ArrayList a = new ArrayList();
                a.Add(10);
                a.Add(20);
                a.Add(30);
                Thread t3 = new Thread(new ParameterizedThreadStart(Func2));
                t3.Start(a);

            });

            //Class or struct 
            class1 c = new class1 { EmpNo = 1, Name = "Vaishnavi", Basic = 1200 };
            Console.WriteLine("EmpNo is :" +c.EmpNo);
            Console.WriteLine("Name is :" +c.Name);
            Console.WriteLine("Basic is :" +c.Basic);


            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Main : " + i);
            }

        }
        static void Func1(object obj)
        {
            int[] arr = (int[])obj; //Boxing
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Function1:" + i + arr[i]);
            }
        }

        static void Func2(object obj)
        {
            ArrayList a = new ArrayList();
            a=(ArrayList)obj;
            foreach (var t2 in a)
            {
                Console.WriteLine("Function2:" +t2);
            }
        }

        static void Func3(object obj)
        {

        }
    }

    public struct class1
    {
        public int EmpNo { get; set; }
        public string Name { get; set; }
        public int Basic { get; set; }
    }
}