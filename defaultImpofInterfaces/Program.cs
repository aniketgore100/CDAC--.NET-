namespace defaultImpofInterfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {

            class2 c = new class2();
            c.insert();
            IDbFunctions idb;
            idb = c;
            idb.select();
        }
    }
    public interface IDbFunctions
    {
        void insert();
        void update();
        void delete();
        void select()
        {
            Console.WriteLine("defualt implementation");
        }
    }
    public class class2 : IDbFunctions
    {
        public void delete()
        {

            Console.WriteLine("show from class 1");
        }

        public void insert()
        {
            Console.WriteLine("show from class 2");
        }

        public void update()
        {
            Console.WriteLine("show from class 2");
        }
        public void select()
        {
            Console.WriteLine("select from class method");
        }

        void IDbFunctions.select()
        {
            Console.WriteLine("from explicit ");
        }
    }
}