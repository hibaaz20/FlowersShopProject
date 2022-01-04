using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project8.DataAccess.CommandDesignPattern.AdminsCommands
{
    public class AdminsShowOrders
    {
        public void AdminShowOrders(DataGridView dataGridv)
        {
            string txtcmd = $"SELECT * FROM Orders ";

            using (SqlConnection conn = new SqlConnection(SqlConn.stringConn))
            {
                var dataAdapter = new SqlDataAdapter(txtcmd, conn);

                conn.Open();
                using (SqlCommand cmd = new SqlCommand(txtcmd, conn))
                {
                    var commandBuilder = new SqlCommandBuilder(dataAdapter);
                    var ds = new DataSet();
                    dataAdapter.Fill(ds);
                    dataGridv.DataSource = ds.Tables[0];

                    conn.Close();
                }
            }

        }
    }
    class AdminShowOrderCommand : ICommand
    {
        private AdminsShowOrders _commands;
        public DataGridView dataGridView;

        public AdminShowOrderCommand(AdminsShowOrders cmd, DataGridView dataGridv)
        {
            _commands = cmd;
            dataGridView = dataGridv;
        }

        public void Execute()
        {
            _commands.AdminShowOrders(dataGridView);
        }
    }


    public class AdminShowOrdersCMD
    {
        ICommand showOrders;

        public AdminShowOrdersCMD(ICommand showCommand)
        {
            showOrders = showCommand;
        }

        public void ShowOrders()
        {
            showOrders.Execute();
        }
    }

}
