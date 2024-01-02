using static exceptionHandling.Program;

namespace exceptionHandling
{
    internal class Program
    {

        static void Main2(string[] args)
        {


            class1 obj = new class1();
            obj = null;
            int x = Convert.ToInt32(Console.ReadLine());// format exception is occurred here
            obj.P1 = 100 / x;
            Console.WriteLine(obj.P1);
            Console.WriteLine("no exception");


        }
        static void Main1(string[] args)
        {
            try
            {
                class1 obj = new class1();
                obj = null;
                int x = Convert.ToInt32(Console.ReadLine());// format exception is occurred here
                obj.P1 = 100 / x;
                Console.WriteLine(obj.P1);
                Console.WriteLine("no exception");
            }
            catch
            {
                Console.WriteLine("exception occured");
            }


        }
        static void Main4(string[] args)
        {
            try
            {
                class1 obj = new class1();
                obj = null;
                int x = Convert.ToInt32(Console.ReadLine());// format exception is occurred here
                obj.P1 = 100 / x;
                Console.WriteLine(obj.P1);
                Console.WriteLine("no exception");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("DBexception occured");
            }
            catch (FormatException)
            {
                Console.WriteLine("FRexception occured");
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("NRexception occured");
            }

            Console.WriteLine("after catch");
        }
        static void Main5(string[] args)
        {
            try
            {
                class1 obj = new class1();
                //obj = null;
                int x = Convert.ToInt32(Console.ReadLine());// format exception is occurred here
                obj.P1 = 100 / x;
                Console.WriteLine(obj.P1);
                Console.WriteLine("no exception");
            }

            catch (FormatException)
            {
                Console.WriteLine("FRexception occured");
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("NRexception occured");
            }
            catch (SystemException ex)
            {
                Console.WriteLine("DBexception occured");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("finally");
            }
            Console.WriteLine("after catch");

        }
        static void Main()// nested try block
        {
            class1 obj = new class1();
            try
            {
                //obj = null;
                int x = Convert.ToInt32(Console.ReadLine());
                obj.P1 = 100 / x;
                Console.WriteLine(obj.P1);
                Console.WriteLine("No Exceptions");
            }

            catch (FormatException ex)
            {
                try
                {
                    Console.WriteLine("FormatException occurred. Enter only numbers");
                    int x = Convert.ToInt32(Console.ReadLine());
                    obj.P1 = 100 / x;
                    Console.WriteLine(obj.P1);
                }
                catch
                {
                    Console.WriteLine("nested try catch example");
                }
                finally
                {
                    Console.WriteLine("nested try finally example");
                }
            }

            catch (NullReferenceException ex)
            {
                Console.WriteLine("NRException occurred");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("DBException occurred");
            }
            catch (Exception ex) //catches all unhandled exceptions
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("outer finally");

            }
            Console.ReadLine();
        }
        public class class1
        {
            private int p1;
            public int P1
            {
                get { return p1; }
                set { p1 = value; }
            }
        }
    }
}