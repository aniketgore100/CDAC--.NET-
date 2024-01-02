using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Data;

namespace aniket
{
    
    internal class Program
    {
        static void Main()
        {

            //Employee obj = new Employee(7, "manya", 756737390, 30);
            //insert(obj);
            //ExecuteScalar(obj);
            //InsertWithProcedure(obj);
            //reader();

            Employee emp = getSingleEmp(7);
            Console.WriteLine(emp.EmpNo);
            Console.WriteLine(emp.Name);
            Console.WriteLine(emp.Basic);
            Console.WriteLine(emp.DeptNo);

        }
        //static void Connect(Employee obj)
        //{
        //    SqlConnection cn = new SqlConnection();
        //    cn.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=YcpOct23;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
        //    try
        //    {
        //        cn.Open();
        //        Console.WriteLine("connection established");
        //        SqlCommand cmd = new SqlCommand();
        //        cmd.Connection = cn;
        //        cmd.CommandType = System.Data.CommandType.Text;
        //        cmd.CommandText = $"INSERT INTO [dbo].[Table] ([Empno], [Name], [Basic], [DeptNo]) VALUES ({obj.EmpNo}, '{obj.Name}', {obj.Basic}, {obj.DeptNo})";
        //        cmd.ExecuteNonQuery();
        //        Console.WriteLine("inserted");
        //    }
        //    catch(Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
        //    finally
        //    {
        //        cn.Close();
        //    }
        //}



        static void insert(Employee obj)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=YcpOct23;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
            try
            {
                cn.Open();
                Console.WriteLine("connection established");
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "INSERT INTO [dbo].[Table] ([Empno], [Name], [Basic], [DeptNo]) VALUES (@EmpNo, @Name, @Basic, @DeptNo)";
                cmd.Parameters.AddWithValue("@EmpNo", obj.EmpNo);
                cmd.Parameters.AddWithValue("@Name", obj.Name);
                cmd.Parameters.AddWithValue("@Basic", obj.Basic);
                cmd.Parameters.AddWithValue("@DeptNo", obj.DeptNo);
                cmd.ExecuteNonQuery();
                Console.WriteLine("inserted");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }


        static void Update(Employee obj)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=YcpOct23;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

            try
            {
                cn.Open();
                Console.WriteLine("Connection established");

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "UPDATE [dbo].[Table] SET [Name] = @Name, [Basic] = @Basic, [DeptNo] = @DeptNo WHERE [Empno] = @EmpNo";

                cmd.Parameters.AddWithValue("@EmpNo", obj.EmpNo);
                cmd.Parameters.AddWithValue("@Name", obj.Name);
                cmd.Parameters.AddWithValue("@Basic", obj.Basic);
                cmd.Parameters.AddWithValue("@DeptNo", obj.DeptNo);

                cmd.ExecuteNonQuery();
                Console.WriteLine("Updated");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }




        //static void InsertWithProcedure(Employee obj)
        //{
        //    SqlConnection cn = new SqlConnection();
        //    cn.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=YcpOct23;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
        //    try
        //    {
        //        cn.Open();
        //        Console.WriteLine("connection established");
        //        SqlCommand cmd = new SqlCommand();
        //        cmd.Connection = cn;
        //        cmd.CommandType = System.Data.CommandType.StoredProcedure;
        //        cmd.CommandText = "InsertEmployee";
        //        cmd.Parameters.AddWithValue("@EmpNo", obj.EmpNo);
        //        cmd.Parameters.AddWithValue("@Name", obj.Name);
        //        cmd.Parameters.AddWithValue("@Basic", obj.Basic);
        //        cmd.Parameters.AddWithValue("@DeptNo", obj.DeptNo);
        //        cmd.ExecuteNonQuery();
        //        Console.WriteLine("inserted");
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
        //    finally
        //    {
        //        cn.Close();
        //    }
        //}


        //static void ExecuteScalar(Employee obj)
        //{
        //    SqlConnection cn = new SqlConnection();
        //    cn.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=YcpOct23;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
        //    try
        //    {
        //        cn.Open();
        //        Console.WriteLine("connection established");
        //        SqlCommand cmd = new SqlCommand();
        //        cmd.Connection = cn;
        //        cmd.CommandType = System.Data.CommandType.Text;
        //        cmd.CommandText = "select Name from [dbo].[Table] where EmpNo = 7";
        //        object ratval = cmd.ExecuteScalar();
        //        Console.WriteLine(ratval);
        //        Console.WriteLine("success");
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
        //    finally
        //    {
        //        cn.Close();
        //    }
        //}


        //static void reader(Employee obj)
        //{
        //    SqlConnection cn = new SqlConnection();
        //    cn.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=YcpOct23;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
        //    try
        //    {
        //        cn.Open();
        //        Console.WriteLine("connection established");
        //        SqlCommand cmd = new SqlCommand();
        //        cmd.Connection = cn;
        //        cmd.CommandType = System.Data.CommandType.Text;
        //        cmd.CommandText = "select * from [dbo].[Table]";

        //        SqlDataReader dr = cmd.ExecuteReader();
        //        while 
        //            (dr.Read())
        //        {
        //            Console.WriteLine(dr[0]);
        //            Console.WriteLine(dr["EmpNo"]);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
        //    finally
        //    {
        //        cn.Close();
        //    }
        //}


        //static void reader()
        //{
        //    SqlConnection cn = new SqlConnection();
        //    cn.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=YcpOct23;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
        //    try
        //    {
        //        cn.Open();
        //        Console.WriteLine("connection established");
        //        SqlCommand cmd = new SqlCommand();
        //        cmd.Connection = cn;
        //        cmd.CommandType = System.Data.CommandType.Text;
        //        cmd.CommandText = "select * from [dbo].[Table]";

        //        SqlDataReader dr = cmd.ExecuteReader();
        //        while
        //            (dr.Read())
        //        {
        //            Console.WriteLine(dr[0]);
        //            Console.WriteLine(dr["EmpNo"]);

        //            Employee obj2 = new Employee();
        //            obj2.EmpNo = (int)dr[0];
        //            obj2.EmpNo = (int)dr["EmpNo"];

        //            obj2.EmpNo = dr.GetInt32(0);
        //            obj2.EmpNo = dr.GetInt32("EmpNo");

        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
        //    finally
        //    {
        //        cn.Close();
        //    }
        //}

        //static void reader()
        //{
        //    SqlConnection cn = new SqlConnection();
        //    cn.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=YcpOct23;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
        //    try
        //    {
        //        cn.Open();
        //        Console.WriteLine("connection established");
        //        SqlCommand cmd = new SqlCommand();
        //        cmd.Connection = cn;
        //        cmd.CommandType = System.Data.CommandType.Text;
        //        cmd.CommandText = "select * from [dbo].[Table]";
        //        SqlDataReader dr = cmd.ExecuteReader();
        //        while (dr.Read())
        //        {
        //            Console.WriteLine(dr[0]);
        //            //Console.WriteLine(dr["EmpNo"]);
        //        }


        //dr.NextResult();
        //while (dr.Read())
        //{
        //    Console.WriteLine(dr[0]);
        //    Console.WriteLine(dr["EmpNo"]);
        //    Console.WriteLine(dr.GetInt32(0));
        //    Console.WriteLine(dr.GetInt32("EmpNo4")); 
        //        //}
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
        //    finally
        //    {
        //        cn.Close();
        //    }
        //}

        static void MARS()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=YcpOct23;Integrated Security=True;MultipleActiveResultSets=true";
            cn.Open();
            SqlCommand cmdDepts = new SqlCommand();
            cmdDepts.Connection = cn;
            cmdDepts.CommandType = CommandType.Text;
            cmdDepts.CommandText = "Select * from Departments";

            SqlCommand cmdEmps = new SqlCommand();
            cmdEmps.Connection = cn;
            cmdEmps.CommandType = CommandType.Text;

            SqlDataReader drDepts = cmdDepts.ExecuteReader();
            while (drDepts.Read())
            {
                Console.WriteLine((drDepts["DeptName"]));
                cmdEmps.CommandText = "Select * from [dbo].[Table]  where DeptNo = " + drDepts["DeptNo"];
                SqlDataReader drEmps = cmdEmps.ExecuteReader();
                while (drEmps.Read())
                {
                    Console.WriteLine(("    " + drEmps["Name"]));
                }
                drEmps.Close();
            }
            drDepts.Close();
            cn.Close();

        }


        static void Transactions()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=YcpOct23;Integrated Security=True";
            cn.Open();
            SqlTransaction t = cn.BeginTransaction();

            SqlCommand cmdInsert = new SqlCommand();
            cmdInsert.Connection = cn;
            cmdInsert.Transaction = t;

            cmdInsert.CommandType = System.Data.CommandType.Text;
            cmdInsert.CommandText = "insert into Employees values(10, 'Shweta', 12345, 30)";

            SqlCommand cmdInsert2 = new SqlCommand();
            cmdInsert2.Connection = cn;
            cmdInsert2.Transaction = t;

            cmdInsert2.CommandType = System.Data.CommandType.Text;
            cmdInsert2.CommandText = "insert into Employees values(20, 'Shweta', 12345, 10)";
            try
            {
                cmdInsert.ExecuteNonQuery();
                cmdInsert2.ExecuteNonQuery();
                t.Commit();
                Console.WriteLine("no errors- commit");
            }
            catch (Exception ex)
            {
                t.Rollback();
                Console.WriteLine("Rollback");
                Console.WriteLine(ex.Message);
            }
            cn.Close();

        }

        static Employee getSingleEmp(int n)
        {
            Employee obj = new Employee();

            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=YcpOct23;Integrated Security=True;MultipleActiveResultSets=true";
            cn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM [dbo].[Table] WHERE EmpNo = " + n;

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                obj.EmpNo = Convert.ToInt32(dr["EmpNo"]);
                obj.Name = dr["Name"].ToString();
                obj.Basic = Convert.ToDecimal(dr["Basic"]);
                obj.DeptNo = Convert.ToInt32(dr["DeptNo"]);
            }

            dr.Close();
            cn.Close();

            return obj;
        }


        static Employee getAllEmp()
        {
            Employee obj = new Employee();

            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=YcpOct23;Integrated Security=True;MultipleActiveResultSets=true";
            cn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM [dbo].[Table]";

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                obj.EmpNo = Convert.ToInt32(dr["EmpNo"]);
                obj.Name = dr["Name"].ToString();
                obj.Basic = Convert.ToDecimal(dr["Basic"]);
                obj.DeptNo = Convert.ToInt32(dr["DeptNo"]);
            }

            dr.Close();
            cn.Close();

            return obj;
        }
       


    }

}
    public class Employee
    {
        public int EmpNo { get; set; }  // Employee Number
        public string Name { get; set; } // Employee Name
        public decimal Basic { get; set; } // Basic Salary
        public int DeptNo { get; set; }   // Department Number

        // Constructor (optional)
       
    }


