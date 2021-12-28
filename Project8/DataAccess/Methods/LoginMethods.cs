using Project8;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HackerU_MidProject1
{

    interface ILoginProccess
    {
        bool CheckUsername(string username, string userpassword);
        bool CheckAdmin(string adminname, string adminpassword);
    }

    interface ICreateAccountProccess
    {
        bool IsUsernameAvaliable(string username);
    }





    public class LoginMethods : ILoginProccess
    {
        public static string connString = SqlConn.stringConn;

        public bool CheckUsername(string username, string userpassword)
        {
            string cmdText = "SELECT COUNT(*) FROM Users WHERE UserName = @username and UserPassword = @userpassword ";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(cmdText, conn))
                {
                    cmd.Parameters.AddWithValue("@UserName", username);
                    cmd.Parameters.AddWithValue("@UserPassword", userpassword);

                    int count = (int)cmd.ExecuteScalar();

                    return (count > 0);


                }
            }
        }



        public bool CheckAdmin(string adminname, string adminpassword)
        {
            string cmdText = "SELECT COUNT(*) FROM Admins WHERE AdminName = @adminname AND AdminPassword = @adminpassword";

            using (System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(connString))
            {
                conn.Open();

                using (System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(cmdText, conn))
                {
                    cmd.Parameters.AddWithValue("@AdminName", adminname);
                    cmd.Parameters.AddWithValue("@AdminPassword", adminpassword);

                    int count = (int)cmd.ExecuteScalar();


                    return (count > 0);
                }
            }
        }
    }
}
