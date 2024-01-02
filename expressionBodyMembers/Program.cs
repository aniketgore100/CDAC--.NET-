using System.Threading.Channels;

namespace expressionBodyMembers
{
    internal class Program
    {     
        static void Main(string[] args)
        {
            class1 c = new class1("aniket");
            Console.WriteLine(c.sum(10, 29));

            c.Name = "aniket";
            c.dis();
;        }
    }

    public class class1
    {
        public void display() => Console.WriteLine("hello aniket");
        public int sum(int a, int b) => a + b;



        private string name;
        public string Name
        {
            get => name;
            set => name=value;
        }
        public void dis()
        {
            Console.WriteLine(name);
        }

        private string prop1;
        public string Prop1 => prop1;


        public class1(string Name) => this.name = Name;

    }
}