using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project8.Methods
{

    interface ICreateAccountProccess
    {
        bool IsUsernameAvaliable(string username);
    }


    public class CreateAccMethods : ICreateAccountProccess
    {
        public static string connString = SqlConn.stringConn;

        public bool IsUsernameAvaliable(string username)
        {
            string cmdText = "SELECT COUNT(*) FROM Users WHERE UserName = @username ";

            using (System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(connString))
            {
                conn.Open();

                using (System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(cmdText, conn))
                {
                    cmd.Parameters.AddWithValue("@UserName", username);

                    int count = (int)cmd.ExecuteScalar();


                    return (count > 0); // if username already exist


                }
            }
        }

    }
}
