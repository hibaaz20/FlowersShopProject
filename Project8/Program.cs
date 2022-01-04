using Project8.Methods;
using System;
using System.Windows.Forms;

namespace Project8
{
    class Program
    {
        static public string connString = SqlConn.stringConn;

        static void Main(string[] args)
        {
            string cmdText = " insert into Flowers (FlowerId,FlowerType) values (1,'Rose')";
            string cmdText2 = " insert into Flowers (FlowerId,FlowerType) values (2,'Azalea')";
            string cmdText3 = " insert into Flowers (FlowerId,FlowerType) values (3,'Aster')";
            string cmdText4 = " insert into Flowers (FlowerId,FlowerType) values (4,'Buttercup')";
            string cmdText5 = " insert into Flowers (FlowerId,FlowerType) values (5,'Crocus')";

            string cmdTextAdmin = " insert into Admins (AdminName,AdminPassword,FirstName,LastName) values ('hiba',123,'hiba','azzam')";


            if (IfRecordExist(1) == false)

            {
                using (System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(connString))
                {
                    conn.Open();

                    using (System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(cmdText, conn))
                    {
                        cmd.ExecuteNonQuery();

                    }
                }
            }
            if (IfRecordExist(2) == false)
            {
                using (System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(connString))
                {
                    conn.Open();

                    using (System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(cmdText2, conn))
                    {
                        cmd.ExecuteNonQuery();

                    }
                }

            }
            if (IfRecordExist(3) == false)
            {
                using (System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(connString))
                {
                    conn.Open();

                    using (System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(cmdText3, conn))
                    {
                        cmd.ExecuteNonQuery();

                    }
                }

            }
            if (IfRecordExist(4) == false)
            {
                using (System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(connString))
                {
                    conn.Open();

                    using (System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(cmdText4, conn))
                    {
                        cmd.ExecuteNonQuery();

                    }
                }

            } 
            if (IfRecordExist(5) == false)
            {
                using (System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(connString))
                {
                    conn.Open();

                    using (System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(cmdText5, conn))
                    {
                        cmd.ExecuteNonQuery();

                    }
                }

            }
            CheckIfuserExist ch1 = new CheckIfuserExist();
            if (ch1.IfAdminExist("hiba") == false)
            {
                using (System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(connString))
                {
                    conn.Open();

                    using (System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(cmdTextAdmin, conn))
                    {
                        cmd.ExecuteNonQuery();

                    }
                }
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainLoginForm());


        }

        static bool IfRecordExist(int flowerid)
        {
            string cmdText = "SELECT COUNT(*) FROM Flowers WHERE FlowerId = @flowerid";

            using (System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(connString))
            {
                conn.Open();

                using (System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(cmdText, conn))
                {
                    cmd.Parameters.AddWithValue("@FlowerId", flowerid);

                    int count = (int)cmd.ExecuteScalar();


                    return (count > 0);
                }
            }
        }

    }
}
