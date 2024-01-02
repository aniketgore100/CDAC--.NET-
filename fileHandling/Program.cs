namespace fileHandling
{
    internal class Program
    {
        static void Main()
        {
            // button_click();
            //click();
           
            
            Console.WriteLine("dir created");
            Emp e = new Emp("aniket", 50000, 56);
           // e.display();
            writeToFile(e);
            ReadFrom();
        }
        //private static void button_click()
        //{
        //    Directory.CreateDirectory(@"d:\aniket");
        //}

        //private static void click()
        //{
        //    File.Create("d:\\aniket\\ani.txt");
        //}

        

        private static void writeToFile(Emp e)
        {
            StreamWriter writer = File.CreateText("d:\\aniket\\ani.txt");
            writer.WriteLine(e.name);

            writer.WriteLine(e.basic);
            writer.WriteLine(e.deptno);
            writer.Close();
        }

        private static void ReadFrom()
        {
            string s;
            StreamReader read = File.OpenText("d:\\aniket\\ani.txt");
            while((s = read.ReadLine()) != null)
            {
                Console.WriteLine(s);
            }
            read.Close();
        }
    }

    public class Emp {

        public static int emp = 1;
        public string name;
        private int empno;
        public decimal basic;
        public short deptno;
    
        public string Name
        {
            get { return name; }
            set
            {
                if(value != null)
                {
                    name = value;
                }

            }
        }

       public int Empno
        {
            get { return empno; }
        }
        public short Deptno
        {
            set
            {
                if(value > 0)
                {
                    deptno = value;
                }
            }
        }
        public decimal Basic { get; set; }


        public Emp(string name = "name", decimal basic = 10000, short deptno = 1)
        {
            this.name = name;
            this.empno = emp++;
            this.deptno = deptno;
            this.basic = basic;
        }
        public  void display()
        {
            Console.WriteLine("name: " + name);
            Console.WriteLine("id: " + empno);
            Console.WriteLine("Dept No.: " + deptno);
        }
    }

}