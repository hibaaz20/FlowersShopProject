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
   public class AdminFilterOrdersCommands
    {

        public void FilterOrders(string FilterDate, DataGridView dataGridv)
        {
            string txtcmd = $"SELECT OrderId,OrderDate  FROM Orders WHERE OrderDate > '{FilterDate}'";

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

    class AdminsFilterOrderCommand : ICommand
    {
        private AdminFilterOrdersCommands _commands;
        public DataGridView dataGridView;
        public string filterdate;

        public AdminsFilterOrderCommand(AdminFilterOrdersCommands cmd, string FilterDate, DataGridView dataGridv)
        {
            _commands = cmd;
            dataGridView = dataGridv;
            filterdate = FilterDate;
        }

        public void Execute()
        {
            _commands.FilterOrders(filterdate, dataGridView);
        }
    }

    public class AdminFilterOrdersCMD
    {
        private ICommand filterCommand;
        public AdminFilterOrdersCMD(ICommand filter)
        {
            this.filterCommand = filter;

        }
        public void adminfilter()
        {
            filterCommand.Execute();
        }
    }

}
