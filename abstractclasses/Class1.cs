using System.Security.Cryptography.X509Certificates;
//using System.Threading.Channels;
//
//namespace abstractclasses
//{
//    public class Class1
//    {
//        static void Main()
//        {
//            
//        }
//    }
//    public abstract class absClass
//    {
//        public void disp()
//        {
//            Console.WriteLine("display called");
//        }
//    }
//    public class derived : absClass
//    {
//        public void disp2()
//        {
//            Console.WriteLine("derived class");
//        }
//    }
//}

namespace abstractclasses2
{
    public class Class1
    {
        static void Main()
        {

        }
    }
    public abstract class absClass2
    {
        public abstract void display();
        public abstract void show();
    }
    public class derived : absClass2
    {
        public override void display()
        {
            throw new NotImplementedException();
        }
        public override void show()
        {
            throw new NotImplementedException();
        }
    }
}