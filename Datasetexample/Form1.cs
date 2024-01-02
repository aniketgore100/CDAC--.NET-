using Microsoft.Data.SqlClient;
using System.Data;

namespace Datasetexample
{
    public partial class Form1 : Form
    {
        DataSet ds = new DataSet();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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
                cmd.CommandText = "select * from [dbo].[Table]";
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;

                da.Fill(ds, "Emps");
                dataGridView1.DataSource = ds.Tables["Emps"];


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

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog = YcpOct23;Integrated Security = True";
            try
            {
                cn.Open();
                SqlCommand cmdUpdatde = new SqlCommand();
                SqlCommand cmdInsert = new SqlCommand();
                SqlCommand cmdDelete = new SqlCommand();

                cmdUpdatde.Connection = cn;
                cmdInsert.Connection = cn;
                cmdDelete.Connection = cn;
                cmdUpdatde.CommandType = System.Data.CommandType.Text;


                cmdUpdatde.CommandText = "update  [dbo].[Table] set Name = @Name, Basic = @Basic, DeptNo = @DeptNo where EmpNo = @EmpNo";
                cmdUpdatde.Parameters.Add(new SqlParameter { ParameterName = "@Name", SourceColumn = "Name", SourceVersion = DataRowVersion.Current });
                cmdUpdatde.Parameters.Add(new SqlParameter { ParameterName = "@Basic", SourceColumn = "Basic", SourceVersion = DataRowVersion.Current });
                cmdUpdatde.Parameters.Add(new SqlParameter { ParameterName = "@DeptNo", SourceColumn = "DeptNo", SourceVersion = DataRowVersion.Current });
                cmdUpdatde.Parameters.Add(new SqlParameter { ParameterName = "@EmpNo", SourceColumn = "EmpNo", SourceVersion = DataRowVersion.Original });



                cmdInsert.CommandText = "insert into  [dbo].[Table] values (@EmpNo, @Name, @Basic, @DeptNo)";
                cmdInsert.Parameters.Add(new SqlParameter { ParameterName = "@EmpNo", SourceColumn = "EmpNo", SourceVersion = DataRowVersion.Current });
                cmdInsert.Parameters.Add(new SqlParameter { ParameterName = "@Name", SourceColumn = "Name", SourceVersion = DataRowVersion.Current });
                cmdInsert.Parameters.Add(new SqlParameter { ParameterName = "@Basic", SourceColumn = "Basic", SourceVersion = DataRowVersion.Current });
                cmdInsert.Parameters.Add(new SqlParameter { ParameterName = "@DeptNo", SourceColumn = "DeptNo", SourceVersion = DataRowVersion.Current });

                cmdDelete.CommandText = "delete from  [dbo].[Table] where EmpNo=@EmpNo";
                cmdDelete.Parameters.Add(new SqlParameter { ParameterName = "@EmpNo", SourceColumn = "EmpNo", SourceVersion = DataRowVersion.Original });

                SqlDataAdapter da = new SqlDataAdapter();
                da.UpdateCommand = cmdUpdatde;
                da.InsertCommand = cmdInsert;
                da.DeleteCommand = cmdDelete;
                da.Update(ds, "Emps");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                cn.Close();
            }

        }

    }




}
