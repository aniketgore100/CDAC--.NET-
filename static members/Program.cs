using System.Threading.Channels;

namespace static_members
{
    internal class Program
    {
        static void Main()
        {
            Class1 c = new Class1();
            c.display();

            Class1.s_display();
            Class1.Aniket = 09876;
            Console.WriteLine(Class1.Aniket);
        }
    }

    public class Class1
    {
        public int i;
        public static int s_i = 12345;
        public void display()
        {
            Console.WriteLine(s_i);
        }

        public static void s_display()
        {
            Console.WriteLine("static method is called");
        }


        private static int aniket;
        public static int Aniket
        {
            set
            {
                aniket = value;
                aniket++;
            }
            get
            {
                return aniket;
               
            }
           
        }

        static Class1()
        {
            Console.WriteLine("static constructor called");
            
        }
    }

}