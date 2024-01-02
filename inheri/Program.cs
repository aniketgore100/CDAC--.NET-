//namespace inheri
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Baseclass b = new Baseclass();
//            b.a = 1;
//
//            derived d = new derived();
//            d.b = 2;
//        }
//    }
//    public class Baseclass
//    {
//        public int a;
//
//    }
//    public class derived : Baseclass
//    {
//        public int b;
//    }
//}
//
//namespace inheritance2
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            textSccessSpecifier.Baseclass b2 = new textSccessSpecifier.Baseclass();
//           
//        }
//  
//    }
//    public class Baseclass
//    {
//        public int pub;
//        private int ptiv;
//        protected int pro;
//        internal int inte;
//        protected internal int pro_int;
//        private protected int priv_pro;
//
//    }
//    public class derived : Baseclass
//    {
//        void donothing()
 //       {
            //this.
 //       }
 //   }
//
//    public class derivedclass : textSccessSpecifier.Baseclass
//    {
//
//    }
//}


//namespace inheritance2
//{
//    internal class Program
//    {           
//        static void Main(string[] args)
//        {
//           // derived d1 = new derived();
//            derived d = new derived(244, 546);
//           
//
//        }
//
//    }
//    public class Baseclass
//    {
//        public int i;
//        public Baseclass()
//        {
//            Console.WriteLine("base class no para");
//            i=10;
//        }
//        public Baseclass(int i)
//        {
//            Console.WriteLine("base class with para ");
//            this.i = i;
//        }
//
//    }            
//    public class derived : Baseclass
//    {
//        public int j;
//        public derived()
//        {
//            Console.WriteLine("derived class no para ");
//            j = 20;
//        }
//        public derived (int i, int j) : base(i)
//        {
//            Console.WriteLine("derived class with para");
//            this.j = j;
//        }
//    }
//
//    
//}
//

namespace inheritance2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // derived d1 = new derived();
            // derived d = new derived();
            // d.display1();   
            // d.display1("aniket");

             Baseclass o = new Baseclass();
            // o.display2();
            // o.display3();
            //

            //o = new derived();
            // o.display2();
            //o.display3();
            // Baseclass o = new Baseclass();
            // derived d = new derived();
            // calldis(o);
            // calldis(d);

            o = new subderived();
            o.display3();

            o = new subsubderived();
            o.display3();

        }

        static void calldis(Baseclass o)
        {
            o.display3();
        }

    }
    public class Baseclass
    {
       
        public void display1()
        {
            Console.WriteLine("base display1");
        }
        public void display2()
        {
            Console.WriteLine("base display2");
        }
        public virtual  void display3()
        {
            Console.WriteLine("base display3");
        }

    }
    public class derived : Baseclass
    {
      public void display1(string s)
        {
            Console.WriteLine("derived display1");
        }
       public new void display2()
        {
            Console.WriteLine("derived display2");
        }
        public override void display3()
        {
            Console.WriteLine("derived display3");
        }

    }
    public class subderived : derived
    {
        public sealed override void display3()
        {
            Console.WriteLine("subderived class");
        }
    }
    
    public class subsubderived : subderived
    {
        public new void display3()
        {
            Console.WriteLine("subsubderived class");
        }
    }
   

}

