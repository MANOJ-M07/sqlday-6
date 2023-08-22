/*using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisconnectedArc
{
    internal class Program
    {
        static SqlDataReader reader;
        static SqlCommand cmd;
        static SqlConnection con;
        static string constr = "Server=LAPTOP-DLI2FL88;database=EmpsDb;trusted_connection=true";
        static void Main(string[] args)
        {
            try
            {
                con = new SqlConnection(constr);
                cmd = new SqlCommand("select * from Emps", con);
                con.Open();
                reader = cmd.ExecuteReader();
                Console.WriteLine("ID \t FirstName \t LastName \t Salary \t Designation");
                while (reader.Read())
                {
                    Console.Write(reader["Id"]+"\t");
                    Console.Write(reader["Fname"]+"\t\t");
                    Console.Write(reader["Lname"]+"\t\t");
                    Console.Write(reader["Salary"]+"\t\t");
                    Console.Write(reader["Designation"]+"\t");
                    Console.Write("\n");
                }
            }
            catch(Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
            finally { Console.ReadKey(); }
        }
    }
}
*/

//insert example
/*using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisconnectedArc
{
    internal class Program
    {
        static SqlDataReader reader;
        static SqlCommand cmd;
        static SqlConnection con;
        static string constr = "Server=LAPTOP-DLI2FL88;database=EmpsDb;trusted_connection=true";
        static void Main(string[] args)
        {
            try
            {
                con = new SqlConnection(constr);
                cmd = new SqlCommand()
                {
                    CommandText = "insert into Emps(Id,Fname,Lname,Salary,Designation) values (@id,@fn,@ln,@sal,@desg)",
                    Connection = con
                };
                Console.WriteLine("Enter Emloyee Id");
                cmd.Parameters.AddWithValue("@id",int.Parse(Console.ReadLine()));
                Console.WriteLine("enter employee first name");
                cmd.Parameters.AddWithValue("@fn",Console.ReadLine());
                Console.WriteLine("Enter employee last name");
                cmd.Parameters.AddWithValue("@ln", Console.ReadLine());
                Console.WriteLine("enter the salary");
                cmd.Parameters.AddWithValue("@sal",double.Parse(Console.ReadLine()));
                Console.WriteLine("enter the designation");
                cmd.Parameters.AddWithValue("@desg", Console.ReadLine());

                con.Open();
                int nor=cmd.ExecuteNonQuery();
                if (nor >= -1)
                {
                    Console.WriteLine("Record inserteed");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { Console.ReadKey(); }
        }
    }
}
*/

//delete example
/*using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisconnectedArc
{
    internal class Program
    {
        static SqlDataReader reader;
        static SqlCommand cmd;
        static SqlConnection con;
        static string constr = "Server=LAPTOP-DLI2FL88;database=EmpsDb;trusted_connection=true";
        static void Main(string[] args)
        {
            try
            {
                con = new SqlConnection(constr);
                cmd = new SqlCommand()
                {
                    CommandText = "delete from Emps where Id=@id",
                    Connection = con
                };
                Console.WriteLine("Enter Emloyee Id to delete");
                cmd.Parameters.AddWithValue("@id", int.Parse(Console.ReadLine()));
                

                con.Open();
                int nor = cmd.ExecuteNonQuery();
                if (nor >= -1)
                {
                    Console.WriteLine("Record deleted");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { Console.ReadKey(); }
        }
    }
}*/


//to find the employee through the id example

/*using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisconnectedArc
{
    internal class Program
    {
        static SqlDataReader reader;
        static SqlCommand cmd;
        static SqlConnection con;
        static string constr = "Server=LAPTOP-DLI2FL88;database=EmpsDb;trusted_connection=true";
        static void Main(string[] args)
        {
            try
            {
                int id;
                Console.WriteLine("Enter Emplyoee ID to find out Details");
                id = int.Parse(Console.ReadLine());
                con = new SqlConnection(constr);
                cmd = new SqlCommand()
                {
                    CommandText="select * from Emps where Id =@id",
                    Connection=con
                };
                cmd.Parameters.AddWithValue("id", id);
                con.Open();
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Console.Write("ID:\t" + reader["Id"]);
                        Console.Write("FirstName:\t" + reader["Fname"]);
                        Console.Write("LastName:\t" + reader["Lname"]);
                        Console.Write("salary:\t" + reader["Salary"]);
                        Console.Write("Designation:\t" + reader["Designation"]);

                    }
                }
                else { Console.WriteLine($"No such Id{id} exist in our database"); }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { Console.ReadKey(); }
        }
    }
}*/

//update the details 

/*using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisconnectedArc
{
    internal class Program
    {
        static SqlDataReader reader;
        static SqlCommand cmd;
        static SqlConnection con;
        static string constr = "Server=LAPTOP-DLI2FL88;database=EmpsDb;trusted_connection=true";
        static void Main(string[] args)
        {
            try
            {
                int id;
                Console.WriteLine("Enter Emplyoee ID to update Details");
                id = int.Parse(Console.ReadLine());
                con = new SqlConnection(constr);
                cmd = new SqlCommand()
                {
                    CommandText = "select * from Emps where Id =@id",
                    Connection = con
                };
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    con.Close();
                    con.Open();
                    cmd.CommandText = "update Emps set Fname=@fn, Lname=@ln,Salary=@sal,Designation=@dsg where Id=@eid";
                    Console.WriteLine("enter employee new first name");
                    cmd.Parameters.AddWithValue("@fn", Console.ReadLine());
                    Console.WriteLine("Enter employee new last name");
                    cmd.Parameters.AddWithValue("@ln", Console.ReadLine());
                    Console.WriteLine("enter the new salary");
                    cmd.Parameters.AddWithValue("@sal", double.Parse(Console.ReadLine()));
                    Console.WriteLine("enter the new designation");
                    cmd.Parameters.AddWithValue("@dsg", Console.ReadLine());
                    cmd.Parameters.AddWithValue("@eid", id);
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Record updated");

                }
                else { Console.WriteLine($"no such id {id} exist in data base"); }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { Console.ReadKey(); }
        }
    }
}*/

//scalar example
/*using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisconnectedArc
{
    internal class Program
    {
        static SqlDataReader reader;
        static SqlCommand cmd;
        static SqlConnection con;
        static string constr = "Server=LAPTOP-DLI2FL88;database=EmpsDb;trusted_connection=true";
        static void Main(string[] args)
        {
            try
            {
                con = new SqlConnection(constr);
                cmd = new SqlCommand("select * from Emps", con);
                con.Open();
                Console.WriteLine("number of employee are: "+cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally 
            { 
                con.Close();
                Console.ReadKey(); 
            }
        }
    }
}
*/

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisconnectedArc
{
    internal class Program
    {
        static SqlDataReader reader;
        static SqlCommand cmd;
        static SqlConnection con;
        static string constr = "Server=LAPTOP-DLI2FL88;database=EmpsDb;trusted_connection=true";
        static void Main(string[] args)
        {
            try
            {
                con = new SqlConnection(constr);
                cmd = new SqlCommand();
                Console.WriteLine("Find out 1.Avg 2.Max 3.Min 4.Sum of salary, enter your choice");
                int op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        {
                            cmd.CommandText = "select avg(salary)from Emps";
                            break;
                        }
                    case 2:
                        {
                            cmd.CommandText = "select max(salary)from Emps";
                            break;
                        }
                    case 3:
                        {
                            cmd.CommandText = "select min(salary)from Emps";
                            break;
                        }
                    case 4:
                        {
                            cmd.CommandText = "select sum(salary)from Emps";
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("invalid operation");
                            return;
                        }
                }

                cmd.Connection = con;
                con.Open();
                Console.WriteLine("Result " + cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
                Console.ReadKey();
            }
        }
    }
}


