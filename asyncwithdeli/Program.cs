namespace asyncwithdeli
{
    internal class Program
    {
        static void Main()
        {
            Action oDel = Display;
            Console.WriteLine("before");
            oDel.BeginInvoke(null, null);
            Console.WriteLine("after");
            Console.ReadLine();
        }
        static void Display()
        {
           
                Thread.Sleep(5000);
                Console.WriteLine("display called");
            
        }
    }
}