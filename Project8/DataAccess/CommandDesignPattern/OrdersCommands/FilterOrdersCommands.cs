using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project8.DataAccess.CommandDesignPattern.OrdersCommands
{
    public class FilterOrdersCommands
    {
        // Filter orders by date for users
        public void FilterOrdersByUserName(string FilterDate, string username, DataGridView dataGridv)
        {
            string txtcmd = $"SELECT OrderId,OrderDate  FROM Orders WHERE OrderDate > '{FilterDate}' and UserName = '{username}' ";
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

    class UserFilterOrderCommand : ICommand
    {
        private FilterOrdersCommands _commands;
        public DataGridView dataGridView;
        public string userName;
        public string filterdate;

        public UserFilterOrderCommand(FilterOrdersCommands cmd, string FilterDate, string username, DataGridView dataGridv)
        {
            _commands = cmd;
            dataGridView = dataGridv;
            filterdate = FilterDate;
            userName = username;
        }

        public void Execute()
        {
            _commands.FilterOrdersByUserName(filterdate, userName, dataGridView);
        }
    }

    public class UserilterOrdersCMD
    {
        private ICommand filterCommand;
        public UserilterOrdersCMD(ICommand filter)
        {
            this.filterCommand = filter;

        }
        public void filter()
        {
            filterCommand.Execute();
        }
    }




}
