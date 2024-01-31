using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;
using DAL;

namespace BAL
{
    public class OrderOperations
    {
        public DAL.DbConnection db = new DAL.DbConnection();

        public int deleteOrder(int id)
        {
            SqlCommand cmd = new SqlCommand("DeleteOrder");
            cmd.CommandType = CommandType.StoredProcedure;
            //parameter
            cmd.Parameters.Add("@order_id", SqlDbType.Int).Value = id;

            return db.ExeNonQuery(cmd);
        }

        public DataTable GetOrderIdByID(int orderid)
        {
            SqlCommand cmd = new SqlCommand("GetOrderById");
            cmd.CommandType = CommandType.StoredProcedure;
            //parameter
            cmd.Parameters.Add("@order_id", SqlDbType.Int).Value = orderid;

            return db.ExeReader(cmd);

        }

        public int inserCustomerOrder(Order order)
        {
            SqlCommand cmd = new SqlCommand("InsertOrder");
            cmd.CommandType = CommandType.StoredProcedure;
            //parameter
            cmd.Parameters.Add("@customer_id", SqlDbType.Int).Value = order.customerid;
            cmd.Parameters.Add("@category", SqlDbType.VarChar, 255).Value = order.category ;
            cmd.Parameters.Add("@order_date", SqlDbType.Date).Value = order.orderdate;
            cmd.Parameters.Add("@delivery_date", SqlDbType.Date).Value = order.delieverydate;
            cmd.Parameters.Add("@full_payment", SqlDbType.Decimal).Value = order.fullpayment;
            cmd.Parameters.Add("@pending", SqlDbType.Decimal).Value = order.pendingpayment;
            cmd.Parameters.Add("@advance_payment", SqlDbType.Decimal).Value = order.advancepayment;
            return db.ExeNonQuery(cmd);
        }

        public int updateOrder(Order order)
        {
            SqlCommand cmd = new SqlCommand("UpdateOrder");
            cmd.CommandType = CommandType.StoredProcedure;
            //parameter
            cmd.Parameters.Add("@order_id", SqlDbType.Int).Value = order.orderid;
            cmd.Parameters.Add("@category", SqlDbType.VarChar, 255).Value = order.category;
            cmd.Parameters.Add("@order_date", SqlDbType.Date).Value = order.orderdate;
            cmd.Parameters.Add("@delivery_date", SqlDbType.Date).Value = order.delieverydate;
            cmd.Parameters.Add("@full_payment", SqlDbType.Decimal).Value = order.fullpayment;
            cmd.Parameters.Add("@pending", SqlDbType.Decimal).Value = order.pendingpayment;
            cmd.Parameters.Add("@advance_payment", SqlDbType.Decimal).Value = order.advancepayment;

            return db.ExeNonQuery(cmd);
        }
    }
}
