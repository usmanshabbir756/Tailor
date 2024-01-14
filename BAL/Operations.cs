using System.Data.SqlClient;
using System.Data;
using DAL;
using BEL;
using System;

namespace BAL
{
    public class Operations
    {
        //db object to call DAL function
        public DbConnection db = new DbConnection();
        //customer object to use customer attribute
        public Customer customer = new Customer();

        //All record form for Record1.cs
        public DataTable GetAllRecord()
        {
            SqlCommand cmd = new SqlCommand("GetCustomerData");
            cmd.CommandType = CommandType.StoredProcedure;
            return db.ExeReader(cmd);
        }

        //insert customer use in NewCustomer1
        public int inserCustomer(Customer customer)
        {

            SqlCommand cmd = new SqlCommand("InsertCustomer");
            cmd.CommandType = CommandType.StoredProcedure;
            //parameter
            cmd.Parameters.Add("@cust_name", SqlDbType.VarChar, 255).Value = customer.name;
            cmd.Parameters.Add("@phone_number", SqlDbType.VarChar, 20).Value = customer.phoneNumber;
            cmd.Parameters.Add("@email", SqlDbType.VarChar, 255).Value = customer.email;
            return db.ExeNonQuery(cmd);
        }
        public DataTable GetIdByNamePhoneNo(Customer customer)
        {
            SqlCommand cmd = new SqlCommand("GetCustomerByNameNumber");
            cmd.CommandType= CommandType.StoredProcedure;
            cmd.Parameters.Add("@cust_name", SqlDbType.VarChar, 255).Value = customer.name;
            cmd.Parameters.Add("@phone_number", SqlDbType.VarChar, 20).Value = customer.phoneNumber;
            return db.ExeReader(cmd);
        }

        public DataTable GetIdByID(int id)
        {
            SqlCommand cmd = new SqlCommand("GetCustomerByID");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@customer_id", SqlDbType.VarChar, 255).Value = id;
            return db.ExeReader(cmd);
        }

        public int updateCustomer(Customer customer)
        {
            SqlCommand cmd = new SqlCommand("UpdateCustomer");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@customer_id", SqlDbType.Int).Value = customer.CustomerId;
            cmd.Parameters.Add("@cust_name", SqlDbType.VarChar, 255).Value = customer.name;
            cmd.Parameters.Add("@phone_number", SqlDbType.VarChar, 20).Value = customer.phoneNumber;
            cmd.Parameters.Add("@email", SqlDbType.VarChar, 255).Value = customer.email;
            return db.ExeNonQuery(cmd);
        }

        public int deleteCustomer(Customer customer)
        {
            SqlCommand cmd = new SqlCommand("DeleteCustomer");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@customer_id", SqlDbType.Int).Value = customer.CustomerId;
            return db.ExeNonQuery(cmd);
        }
    }
}
