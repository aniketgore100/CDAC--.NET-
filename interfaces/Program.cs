namespace interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            class1 c = new class1();
            class2 c2 = new class2();
            //c.insert();
            //c.delete();
            //c.update();


            //IDbFunctions idb;
            //idb  = c;
            //idb.insert();

            //((IDbFunctions)c).insert();

            //(c as IDbFunctions).insert();

            //IFilefunctions f;
            //f = c;
            //f.open();
            IDbFunctions oidb;
            oidb = c;
            c.insert();

            oidb = c2;
            c2.insert();


        }
    }
    public interface IDbFunctions
    {
        void insert();
        void update();
        void delete();
    }
    public interface IFilefunctions
    {
        void open();
        void close();
        void delete();
    }
    public class class1 : IDbFunctions, IFilefunctions
    {
        public void delete()
        {

            throw new NotImplementedException();
        }

        public void insert()
        {
            throw new NotImplementedException();
        }

        public void update()
        {
            throw new NotImplementedException();
        }

        void IFilefunctions.close()
        {
            throw new NotImplementedException();
        }

        void IFilefunctions.open()
        {
            throw new NotImplementedException();
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


    }
}
    