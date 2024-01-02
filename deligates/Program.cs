namespace deligates
{
    internal class Program
    {
        public delegate int  Dell(int a, int b);
        static void Main()
        {
            //Dell d = new Dell(display);
            //Dell d = display;
            //d();

            //Console.WriteLine();
            //d += show;
            //d();

            //Console.WriteLine();
            //d += display;
            //d();

            //d -= display;
            //d();

            Dell d = add;
            int a = 100, b = 20;
            Console.WriteLine(d(a, b));

            d+=substract;
            Console.WriteLine(d(a,b));

        }
      
       //static void display()
       // {
       //     Console.WriteLine("display");
       // }
       // static void show()
       // {
       //     Console.WriteLine("show");
       // }
        static int add(int a, int b)
        {
            return a+b;
        }
        static int substract(int a, int b)
        {
            return a-b;
        }
    }
}