using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;
using DAL;
using System.Collections;

namespace BAL
{
    public class SizeOperations
    {
        public DbConnection db = new DbConnection();
        //public Size size = new Size();

        public int inserCustomerSize(Size size)
        {

            SqlCommand cmd = new SqlCommand("InsertCustomerSize");
            cmd.CommandType = CommandType.StoredProcedure;
            //parameter
            cmd.Parameters.Add("@customer_id", SqlDbType.Int).Value = size.customerId;
            cmd.Parameters.Add("@shoulder ", SqlDbType.VarChar, 20).Value = size.shoulder;
            cmd.Parameters.Add("@waist", SqlDbType.VarChar, 20).Value = size.Waist;
            cmd.Parameters.Add("@thigh", SqlDbType.VarChar, 20).Value = size.Thigh;
            cmd.Parameters.Add("@half_length", SqlDbType.VarChar, 20).Value = size.Halflenght;
            cmd.Parameters.Add("@under_bust", SqlDbType.VarChar, 20).Value = size.Underbust;
            cmd.Parameters.Add("@upper_bust", SqlDbType.VarChar, 20).Value = size.Underbust;
            cmd.Parameters.Add("@skirt_length", SqlDbType.VarChar, 20).Value = size.Skirtlength;
            cmd.Parameters.Add("@trouser_length", SqlDbType.VarChar, 20).Value = size.trouserlength;
            cmd.Parameters.Add("@dress_length", SqlDbType.VarChar, 20).Value = size.dresslength;
            cmd.Parameters.Add("@sleeves", SqlDbType.VarChar, 20).Value = size.sleeves;
            cmd.Parameters.Add("@round_arms", SqlDbType.VarChar, 20).Value = size.roundarms;
            cmd.Parameters.Add("@round_neck", SqlDbType.VarChar, 20).Value = size.roundneck;
            cmd.Parameters.Add("@wrist", SqlDbType.VarChar, 20).Value = size.wrist;
            return db.ExeNonQuery(cmd);
        }

       

        public DataTable GetIdByID(int customerid)
        {
            SqlCommand cmd = new SqlCommand("GetCustomerSize");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@customer_id", SqlDbType.Int).Value = customerid;
            return db.ExeReader(cmd);
        }

        public int updateCustomerSize(Size size)
        {
            SqlCommand cmd = new SqlCommand("UpdateCustomerSize");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@customer_id", SqlDbType.Int).Value = size.customerId;
            cmd.Parameters.Add("@shoulder ", SqlDbType.VarChar, 20).Value = size.shoulder;
            cmd.Parameters.Add("@waist", SqlDbType.VarChar, 20).Value = size.Waist;
            cmd.Parameters.Add("@thigh", SqlDbType.VarChar, 20).Value = size.Thigh;
            cmd.Parameters.Add("@half_length", SqlDbType.VarChar, 20).Value = size.Halflenght;
            cmd.Parameters.Add("@under_bust", SqlDbType.VarChar, 20).Value = size.Underbust;
            cmd.Parameters.Add("@skirt_length", SqlDbType.VarChar, 20).Value = size.Skirtlength;
            cmd.Parameters.Add("@trouser_length", SqlDbType.VarChar, 20).Value = size.trouserlength;
            cmd.Parameters.Add("@dress_length", SqlDbType.VarChar, 20).Value = size.dresslength;
            cmd.Parameters.Add("@sleeves", SqlDbType.VarChar, 20).Value = size.sleeves;
            cmd.Parameters.Add("@round_arms", SqlDbType.VarChar, 20).Value = size.roundarms;
            cmd.Parameters.Add("@round_neck", SqlDbType.VarChar, 20).Value = size.roundneck;
            cmd.Parameters.Add("@wrist", SqlDbType.VarChar, 20).Value = size.wrist;
            return db.ExeNonQuery(cmd);
        }

        public int deleteCustomerSize(int v)
        {
            SqlCommand cmd = new SqlCommand("DeleteCustomerSize");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@customer_id", SqlDbType.Int).Value = v;
            return db.ExeNonQuery(cmd);
        }
    }
}
