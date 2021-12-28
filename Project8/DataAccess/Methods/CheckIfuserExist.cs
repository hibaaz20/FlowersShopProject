using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Project8.SqlConn;
namespace Project8.Methods
{

    interface ICheckIfUserExist
    {
        bool IfUserExist(string username);
    }
    interface ICheckIfAdminExist
    {
        bool IfAdminExist(string adminname);
    }


    public class CheckIfuserExist : ICheckIfUserExist, ICheckIfAdminExist
    {
        public static string connString = SqlConn.stringConn;

        public bool IfAdminExist(string adminname)
        {
            string cmdText = "SELECT COUNT(*) FROM Admins WHERE AdminName = @adminname ";

            using (System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(connString))
            {
                conn.Open();

                using (System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(cmdText, conn))
                {
                    cmd.Parameters.AddWithValue("@AdminName", adminname);

                    int count = (int)cmd.ExecuteScalar();


                    return (count > 0);
                }
            }
        }

        public bool IfUserExist(string username)
        {
            string cmdText = "SELECT COUNT(*) FROM Users WHERE UserName = @username ";

            using (System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(connString))
            {
                conn.Open();

                using (System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(cmdText, conn))
                {
                    cmd.Parameters.AddWithValue("@UserName", username);

                    int count = (int)cmd.ExecuteScalar();


                    return (count > 0);
                }
            }
        }
    
        }
    }

