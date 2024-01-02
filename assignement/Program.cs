using System;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using System.Threading.Channels;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Todo
{
    internal class Emp
    {
        static void Main()
        {
            Manager m = new Manager("aniket", 20000, 45, "Manager");
            m.display();
            GeneralManager gm = new GeneralManager("kishore", 40000, 56, "GeneralManager", "car");
            gm.display();
            CEO c = new CEO("sanket", 30000, 23, "devloper", "laptop");
            c.display();
        }
    }

    public interface IDbFunctions
    {
       public void manager();
       public void generalmanager();
       public void ceo();
    }

    public abstract class Employee : IDbFunctions
    {
        public static int emp = 1;
        private string name;
        private int empno;
        public decimal basic;
        private short deptno;

        public string Name
        {
            get { return name; }
            set
            {
                if (value != null)
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
                if (value > 0)
                {
                    deptno = value;
                }
            }
        }

        public abstract decimal Basic { get; set; }

        public abstract decimal CalNetSalary();

        public Employee(string name = "name", decimal basic = 10000, short deptno = 1)
        {
            this.name = name;
            this.empno = emp++;
            this.deptno = deptno;
            this.basic = basic;
        }

        public virtual void display()
        {
            Console.WriteLine("name: " + name);
            Console.WriteLine("id: " + empno);
            Console.WriteLine("Dept No.: " + deptno);
        }

        public void ceo()
        {
            Console.WriteLine("ceo is called");
        }

        public void manager()
        {
            Console.WriteLine("manager is called");
        }

        public void generalmanager()
        {
            Console.WriteLine("general manager is called");
        }
    }

    public class Manager : Employee, IDbFunctions
    {
        public string designation;
        public Manager(string name, decimal basic, short deptno, string designation) : base(name, basic, deptno)
        {
            this.designation = designation;
        }
        public string Designation
        {
            set
            {
                if (value.Length > 18000) designation = value;
            }
            get
            {
                return designation;
            }
        }

       
        public override decimal Basic
        {
            get { return basic; }
            set
            {
                if (value > 2000)
                {
                    basic = value;
                }
            }
        }

        public override decimal CalNetSalary()
        {
            return basic + 20000;
        }

        public override void display()
        {
            base.display();
            Console.WriteLine("Designation: " + Designation);
            Console.WriteLine("salary: " + CalNetSalary());
        }
    }

    public class GeneralManager : Manager
    {

        public string Perks { get; set; }

        public GeneralManager(string name, decimal basic, short deptno, string Designation, string perks) : base(name, basic, deptno, Designation)
        {
            this.Perks = perks;
        }

        public override decimal Basic
        {
            set
            {
                if (value > 20000)
                {
                    basic = value;
                }
            }
            get { return basic; }
        }
        public override decimal CalNetSalary()
        {
            return basic + 8000;
        }

        public override void display()
        {
            Console.WriteLine("=====================================");
            base.display();
            Console.WriteLine("perks: " + Perks);
            Console.WriteLine("=====================================");
        }
    }

    public sealed class CEO : Employee, IDbFunctions
    {
        public string designation;
        public CEO(string name, decimal basic, short deptno, string designation, string perks) : base(name, basic, deptno)
        {
            this.designation = designation;
        }
        public string Designation
        {
            set
            {
                if (value.Length > 18000) designation = value;
            }
            get
            {
                return designation;
            }
        }
        public override decimal Basic
        {
            get { return basic; }
            set
            {
                if (value > 5000)
                {
                    basic =  value;
                }
            }
        }

        public sealed override decimal CalNetSalary()
        {
            return basic + 10000;
        }

        public override void display()
        {
            base.display();
            Console.WriteLine("Designation: " + designation);
            Console.WriteLine("salary: " + CalNetSalary());
        }
    }
}
