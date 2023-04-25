using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Data;
using System.Configuration;

namespace InfobridgeProject.App_Code
{
    public class EmployeeCRUD
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public EmployeeCRUD()
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
        }
        public DataTable GetAllEmployess()
        {
           
           DataTable tb= new DataTable();
            string qry = "select * from UserDetails";
            cmd = new SqlCommand(qry, con);
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                tb.Load(dr);
            }
            con.Close();
            return tb;

        }
        public Employee GetEmployeeById(int id)
        {
            Employee emp = new Employee();
            string qry = "select * from UserDetails where id=@id";
            cmd = new SqlCommand(qry, con);
            cmd.Parameters.AddWithValue("@id", id);
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    emp.Id = Convert.ToInt32(dr["id"]);
                    emp.Name = dr["Name"].ToString();
                    emp.DOB = dr["DOB"].ToString();
                    emp.Sex = dr["sex"].ToString();
                    emp.Phone = dr["phone"].ToString();
                    emp.Address = dr["address"].ToString();
                }
            }
            con.Close();
            return emp;
        }
        public int AddEmployee(Employee emp)
        {
            int result = 0;
            string qry = "insert into UserDetails values(@id,@name,@dob,@sex,@phone,@address)";
            cmd = new SqlCommand(qry, con);
            cmd.Parameters.AddWithValue("@name", emp.Name);
            cmd.Parameters.AddWithValue("@id",emp.Id);
            cmd.Parameters.AddWithValue("@dob", emp.DOB);
            cmd.Parameters.AddWithValue("@sex", emp.Sex);
            cmd.Parameters.AddWithValue("@phone", emp.Phone);
            cmd.Parameters.AddWithValue("@address", emp.Address);
            con.Open();
            result = cmd.ExecuteNonQuery();
            con.Close();
            return result;

        }
        public int UpdateEmployee(Employee emp)
        {
            int result = 0;
            string qry = "update UserDetails set Name=@name,DOB=@dob,sex=@sex,phone=@phone,address=@address  where id=@id";
            cmd = new SqlCommand(qry, con);
            cmd.Parameters.AddWithValue("@id", emp.Id);
            cmd.Parameters.AddWithValue("@name", emp.Name);
            cmd.Parameters.AddWithValue("@dob", emp.DOB);
            cmd.Parameters.AddWithValue("@sex", emp.Sex);
            cmd.Parameters.AddWithValue("@phone", emp.Phone);
            cmd.Parameters.AddWithValue("@address", emp.Address);
            con.Open();
            result = cmd.ExecuteNonQuery();
            con.Close();
            return result;
        }
        public int DeleteEmployee(int id)
        {
            int result = 0;
            string qry = "delete from UserDetails where id=@id";
            cmd = new SqlCommand(qry, con);
            cmd.Parameters.AddWithValue("@id", id);
            con.Open();
            result = cmd.ExecuteNonQuery();
            con.Close();
            return result;
        }
    }
}