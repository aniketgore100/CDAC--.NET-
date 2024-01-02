namespace deligates2
{
    internal class Program
    {
        public delegate int MAthdel(int a, int b);





        static void Main(string[] args)
        {
            Console.WriteLine(MathOp(add, 10,10));
            Action a = Display;
            a();

            Func<int, int,int> a2 = Add2;
            Console.WriteLine(a2(100, 10));

            Func<string, int, string> o4 = Str;
            Console.WriteLine(o4("aniket", 10));

            Employee e = new Employee();
            Func<Employee, bool> o6 = isGreaterThan;
            o6(e);
        }



        static int MathOp(MAthdel omath, int a, int b)
        {
            return omath(a, b);
        }
        static int add(int a, int b)
        {
            return a+b;
        }
        static void Display()
        {
            Console.WriteLine("hello aniket");
        }


        static int Add2(int a , int b)
        {
            return a+b;
        }



        static string Str(string s , int a )
        {
            return s + a;
        }
        static bool isGreaterThan(Employee obj)
        {
            if(obj.Basic > 110000)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    public class Employee
    {
        public int EmpNo { get; set; }
        public string Name{ get; set; }
        public decimal Basic { get; set; }
        public int DeptNo { get; set; }

    }
}