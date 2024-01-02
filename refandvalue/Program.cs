
//namespace refandvalue
//{
//    internal class Program
//    {
//        static void Main1(string[] args)
//        {
//            class1 o = new class1();
//            class1 p = new class1();
//            o.i = 100;
//            p.i = 200;
//            o = p;
//            p.i = 300;
//            Console.WriteLine(o.i);
//            Console.WriteLine(p.i);
//        }
//        static void Main2()
//        {
//            int a, b;
//            a = 100;
//            b = 200;
//            a = b;
//            b = 300;
//            Console.WriteLine(a);
//            Console.WriteLine(b);
//        }
//        static void Main()
//        {
//            string s1, s2;
//            s1 = "100";
//            s2 = "200";
//            s1 = s2;
//            s2 = "300";
//            Console.WriteLine(s1);
//            Console.WriteLine(s2);
//        }
//        static void DataTypes()
//        {
//            byte by; //Byte 
//            sbyte by2; //SByte 

//            short sh; //Int16 - 2
//            ushort ush; //UInt16

//            int i; //Int32  - 4
//            uint ui;  //UInt32 - 4

//            long l; //Int64 - 8
//            ulong ul; //UInt64 - 8

//            float f;   //Single
//            double d;  //Double
//            decimal c; //Decimal

//            char ch; //Char
//            bool b; //Boolean

//            object o; //Object
//            string s; //String
//        }
//        static void Boxing()
//        {
//            int i = 100;

//            object o;
//            o = i;  //boxing
//            int j;
//            j = (int)o; //unboxing

//        }

//    }
//    public class class1
//    {
//        public int i;
//    }
//}





using System.Diagnostics;
using System.Net.NetworkInformation;

namespace refndval
{
    internal class Program {
        static void Main()
        {
            //int i, j;
            //Init(out i, out j);
            //Swap(ref i, ref j);
            //Print(in i);
            //Print(j);

            //Print( i);
            //Console.WriteLine(j);
            class1 c = new class1();
            c.i = 100;
           // Dosome1(ref c);
           
            Dosome2(c);
            //Console.WriteLine(c.i);
            //Dosome3(c);
            //Console.WriteLine(c.i);
            Dosome4(out c);
            Console.WriteLine(c.i);
        }
       
        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        static void Init(out int a, out int b)
        {
            a = 1000;
            b = 2000;
        }
        static void Print(in int x)
        {
            
            Console.WriteLine(x);

        }
        static void Dosome1(ref class1 obj)
        {
            obj = new class1();
            obj.i = 200;
        }

        static void Dosome2(class1 obj)
        {
            obj = new class1();
            obj.i = 200;
        }
        static void Dosome3(class1 obj)
        {
            
            obj.i = 200;
        }
        static void Dosome4(out class1 obj)
        {
            

            obj = new class1();
            obj.i = 200;
        }
    }

    public class class1 {
        public int i;
    }


}