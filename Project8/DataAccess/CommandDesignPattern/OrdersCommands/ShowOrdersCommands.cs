using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project8.DataAccess.CommandDesignPattern
{
    public class ShowOrdersCommands
    {
        // show orders
        public void ShowOrders(string username, DataGridView dataGridv)
        {
            string txtcmd = $"SELECT OrderId,OrderDate  FROM Orders WHERE UserName = '{username}'";

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
    class ShowOrderCommand : ICommand
    {
        private ShowOrdersCommands _commands;
        public string userName;
        public DataGridView dataGridView;

        public ShowOrderCommand(ShowOrdersCommands cmd, string username, DataGridView dataGridv)
        {
            _commands = cmd;
            userName = username;
            dataGridView = dataGridv;
        }

        public void Execute()
        {
            _commands.ShowOrders(userName, dataGridView);
        }
    }


    public class ShowOrdersCMD
    {

        private ICommand usershowCommand;
        private ICommand adminshowCommand;

        public ShowOrdersCMD(ICommand userShow, ICommand adminShow)
        {

            this.usershowCommand = userShow;
            this.adminshowCommand = adminShow;

        }
        public void userShow()
        {
            usershowCommand.Execute();
        }
       
     
    }



}
