using assigModelBinding.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Data;

namespace assigModelBinding.Controllers
{
    public class EmployeesController : Controller
    {

        public ActionResult Index()
        {
            List<Employee>list = new List<Employee>();
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=YcpOct23;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = System.Data.CommandType.Text;

            }
        }



        public ActionResult Details(int id, Employee obj)
        {
         

            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=YcpOct23;Integrated Security=True;MultipleActiveResultSets=true";
            cn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM [dbo].[Table] WHERE EmpNo = " + id;

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

            return View(obj);


        }


    public ActionResult Create()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Employee obj)
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
                return RedirectToAction("Index");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {

                cn.Close();

                
            }
           
            return View();
          
        }


        public ActionResult Edit( int id)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=YcpOct23;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

            Employee employee = null; // Initialize to null by default

            try
            {
                cn.Open();
                Console.WriteLine("Connection established");

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = System.Data.CommandType.Text;

                // Assuming 'id' is the EmpNo of the employee you want to delete
                cmd.CommandText = "SELECT EmpNo, Name, DeptNo, Basic FROM [dbo].[Table] WHERE Empno = @EmpNo";
                cmd.Parameters.AddWithValue("@EmpNo", id);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    employee = new Employee
                    {
                        EmpNo = (int)reader["EmpNo"],
                        Name = (string)reader["Name"],
                        DeptNo = (int)reader["DeptNo"],
                        Basic = (decimal)reader["Basic"]
                    };
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                cn.Close();
            }

            if (employee == null)
            {
                // Employee not found with the specified ID; you can handle this case accordingly.
                return RedirectToAction("Index");
            }

            return View(employee);
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
       
        public ActionResult Edit(int id, Employee obj)
        {
            obj.EmpNo = id;
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=YcpOct23;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

            try
            {
                cn.Open();
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "UPDATE [dbo].[Table] SET [Name] = @Name, [Basic] = @Basic, [DeptNo] = @DeptNo WHERE [Empno] = @EmpNo";
                cmd.Parameters.AddWithValue("@EmpNo", obj.EmpNo);
                cmd.Parameters.AddWithValue("@Name", obj.Name);
                cmd.Parameters.AddWithValue("@Basic", obj.Basic);
                cmd.Parameters.AddWithValue("@DeptNo", obj.DeptNo);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                cn.Close();
            }

            // Retrieve the updated data from the database
            SqlConnection cn2 = new SqlConnection();
            cn2.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=YcpOct23;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

            try
            {
                cn2.Open();
                SqlCommand cmd2 = cn2.CreateCommand();
                cmd2.CommandType = System.Data.CommandType.Text;
                cmd2.CommandText = "SELECT EmpNo, Name, DeptNo, Basic FROM [dbo].[Table] WHERE Empno = @EmpNo";
                cmd2.Parameters.AddWithValue("@EmpNo", obj.EmpNo);

                SqlDataReader reader = cmd2.ExecuteReader();

                if (reader.Read())
                {
                    obj.EmpNo = (int)reader["EmpNo"];
                    obj.Name = (string)reader["Name"];
                    obj.DeptNo = (int)reader["DeptNo"];
                    obj.Basic = (decimal)reader["Basic"];
                }

                reader.Close();
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                cn2.Close();
            }

            return View(obj);

        }



        public ActionResult Delete(int id)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=YcpOct23;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

            Employee employee = null; // Initialize to null by default

            try
            {
                cn.Open();
                Console.WriteLine("Connection established");

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = System.Data.CommandType.Text;

                // Assuming 'id' is the EmpNo of the employee you want to delete
                cmd.CommandText = "SELECT EmpNo, Name, DeptNo, Basic FROM [dbo].[Table] WHERE Empno = @EmpNo";
                cmd.Parameters.AddWithValue("@EmpNo", id);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    employee = new Employee
                    {
                        EmpNo = (int)reader["EmpNo"],
                        Name = (string)reader["Name"],
                        DeptNo = (int)reader["DeptNo"],
                        Basic = (decimal)reader["Basic"]
                    };
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                cn.Close();
            }

            if (employee == null)
            {
                // Employee not found with the specified ID; you can handle this case accordingly.
                return RedirectToAction("Index");
            }

            return View(employee);
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Employee obj)
        {
            obj.EmpNo = id;
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=YcpOct23;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

            try
            {
                cn.Open();
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "DELETE FROM [dbo].[Table] WHERE EmpNo = @EmpNo";
                cmd.Parameters.AddWithValue("@EmpNo", obj.EmpNo);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                cn.Close();
            }

            return RedirectToAction(nameof(Index));
        }

    }
}
