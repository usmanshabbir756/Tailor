using System.Data.SqlClient;
using System.Data;
using DAL;
using BEL;

namespace BAL
{
    public class Operations
    {
        public DbConnection db = new DbConnection();
        public Customer customer = new Customer();


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

    }
}
