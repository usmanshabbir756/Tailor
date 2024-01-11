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
            public SqlConnection Conn = new SqlConnection("Data Source=USMAN_SHABBIR;Initial Catalog=TailorManagmentSystem;Integrated Security=True;");

            public SqlConnection GetCon()
            {
                if (Conn.State == ConnectionState.Closed)
                {
                    Conn.Open();
                }

                return Conn;
            }
            


            public int ExeNonQuery(SqlCommand cmd)
            {
                cmd.Connection = GetCon();
                int rowAffected = -1;
                rowAffected = cmd.ExecuteNonQuery(); //==1
                Conn.Close();
                return rowAffected;
            }

            public object ExeScalar(SqlCommand cmd)
            {
                cmd.Connection = GetCon();
                object obj = -1;
                obj = cmd.ExecuteScalar();
                Conn.Close();
                return obj;
            }

            public DataTable ExeReader(SqlCommand cmd)
            {
                cmd.Connection = GetCon();
                SqlDataReader sdr;
                DataTable dt = new DataTable();
                sdr = cmd.ExecuteReader();
                dt.Load(sdr);
                return dt;
            }


    }
}

