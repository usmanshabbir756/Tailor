using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DbConnection
    {
        //Making sqlconnection by adding
        //datasource  as server name
        //AttachDbFilename give database name from debug folder of application
        public SqlConnection Conn;

        
        public DbConnection()
        {
            this.Conn = new SqlConnection("Data Source=(localdb)" + "\\MSSQLLocalDB;AttachDbFilename=" + System.IO.Path.GetFullPath("TailorManagmentSystem.mdf") + ";Integrated Security=True;");

        }
        public DbConnection(string s)
        {
            this.Conn = new SqlConnection(s);

        }
        //making getcon function to get db connection
        //and open it iif close
            public SqlConnection GetCon()
            {
                if (Conn.State == ConnectionState.Closed)
                {
                    Conn.Open();
                }

                return Conn;
            }


        //Making function to run ExecuteNonQuery not return data query
        public int ExeNonQuery(SqlCommand cmd)
            {
                cmd.Connection = GetCon();
                int rowAffected = -1;
                rowAffected = cmd.ExecuteNonQuery(); //==1
                Conn.Close();
                return rowAffected;
            }


        //Making function to run ExecuteReader return data prom data base in data table
        public DataTable ExeReader(SqlCommand cmd)
            {
                cmd.Connection = GetCon();
                SqlDataReader sdr;
                DataTable dt = new DataTable();
                sdr = cmd.ExecuteReader(); //data that read  sqldatareader
                dt.Load(sdr); //enter data in datatable and send back
                return dt;
            }


    }
}

