namespace anonymousMethods
{
    internal class Program
    {
        static void Main()
        {
            //int i = 100;
            //Action a = delegate(){
            //    Console.WriteLine(i);
            //};
            //a();



            //Func<int, int, int> a2 = delegate (int a, int b)
            //{
            //    return a + b;
            //};
            //Console.WriteLine(a2(10, 20));


            //Func<string> o3 = delegate
            //{
            //    return DateTime.Now.ToLongTimeString();
            //};
            //Console.WriteLine(o3());

            //Func<int, int> o4 = delegate (int a)
            //{
            //    return a * 2;
            //};
            //o4(10);


            //Func<int , bool> o6 = delegate (int a)
            // {
            //     if (a % 2 == 0)
            //         return true;
            //     else
            //         return false;
            // };

            //Console.WriteLine(o6(10));


            //Employee e = new Employee() { EmpNo = 1, Name = "a", Basic = 1200 }; ;
            //Predicate<Employee> o7 = delegate (Employee a)
            //{  
            //    if (e.Basic  > 10000)
            //        return true;
            //    else
            //        return false;
            //};
            //Console.WriteLine(o7(e));




            //Func<int, int> o8 = a => a * 2;
            //Console.WriteLine(o8(9));

            Func<int, int, int> o9 = (a, b) => a+b;
            Console.WriteLine(o9(10, 200));

            Func<string> f1 = () => DateTime.Now.ToLongTimeString();
            Console.WriteLine(f1());


            Func<int, bool> f2 = a => a % 2 == 0;
            Console.WriteLine(f2(23));


            Employee e2 = new Employee() { EmpNo = 1, Name = "a", Basic = 1200 }; ;
            Predicate<Employee> p1 = (e) => e.Basic  > 10000;
            Console.WriteLine(p1(e2));


            Action a4 = () =>
            {
                Console.WriteLine("hello aniket ");
            };
            Action a5 = () =>
            
                Console.WriteLine("How are you ");
            

            a4();
            a5();
        }
    }

    public class Employee
    {
        public int EmpNo { get; set; }
        public string Name { get; set; }
        public decimal Basic { get; set; }
        public int DeptNo { get; set; }

    }
}