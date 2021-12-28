using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project8.Database
{
    interface ICheckIfUserHasOrders
    {
        bool IsUserHasOrders(string username);
        bool ICheckIfOrderExist(int orderid);
    }
    public class CheckOrders : ICheckIfUserHasOrders
    {
       static string connString = SqlConn.stringConn;

        public bool IsUserHasOrders(string username)
        {

            string cmdText = "SELECT COUNT(*) FROM Orders WHERE UserName = @username ";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(cmdText, conn))
                {
                    cmd.Parameters.AddWithValue("@UserName", username);

                    int count = (int)cmd.ExecuteScalar();


                    return (count > 0);


                }
            }
        }


        public bool ICheckIfOrderExist(int Orderid)
        {
            string cmdText = "SELECT COUNT(*) FROM Orders WHERE OrderId = @Orderid ";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(cmdText, conn))
                {
                    cmd.Parameters.AddWithValue("@OrderId", Orderid);

                    int count = (int)cmd.ExecuteScalar();


                    return (count > 0);


                }
            }
        }


   

    }
}
