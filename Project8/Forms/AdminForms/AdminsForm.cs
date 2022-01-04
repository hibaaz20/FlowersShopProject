using Microsoft.Data.SqlClient;
using Project8.DataAccess.CommandDesignPattern;
using Project8.DataAccess.CommandDesignPattern.AdminsCommands;
using Project8.Database;
using Project8.Forms.AdminForms;
using Project8.Methods;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project8.Forms
{
    public partial class AdminsForm : Form
    {
        public static string connString = SqlConn.stringConn;

        public AdminsForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.ReadOnly = true;
        }

        private void ShowUsers_button_Click(object sender, EventArgs e)
        {
            var sqlCommand = "SELECT UserName FROM Users ";


            var c = new SqlConnection(connString);


            using (SqlConnection conn = new SqlConnection(connString))
            {

                var dataAdapter = new SqlDataAdapter(sqlCommand, c);

                conn.Open();


                using (SqlCommand cmd = new SqlCommand(sqlCommand, conn))
                {


                    var commandBuilder = new SqlCommandBuilder(dataAdapter);
                    var ds = new DataSet();
                    dataAdapter.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                    conn.Close();
                }
            }

        }

        private void Back_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            string username = UserName_textBox1.Text;

            var sqlCommand = $"SELECT Users.UserName,Users.FirstName,LastName, Orders.OrderId FROM Users FULL OUTER JOIN Orders ON Users.UserName = Orders.UserName where Users.UserName = '{username}' ORDER BY Orders.OrderId; ";
            var c = new SqlConnection(connString);
            CheckOrders ch1 = new CheckOrders();
            CheckIfuserExist ch2 = new CheckIfuserExist();
            if (ch2.IfUserExist(username))
            {

                using (SqlConnection conn = new SqlConnection(connString))
                {

                    var dataAdapter = new SqlDataAdapter(sqlCommand, c);

                    conn.Open();


                    using (SqlCommand cmd = new SqlCommand(sqlCommand, conn))
                    {
                        if (ch1.IsUserHasOrders(username) == false)
                        {
                            MessageBox.Show($"User '{username}' Didn't Place Any Order Yet", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }


                        var commandBuilder = new SqlCommandBuilder(dataAdapter);
                        var ds = new DataSet();
                        dataAdapter.Fill(ds);
                        dataGridView1.DataSource = ds.Tables[0];

                        conn.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("User Doesn't Exist","",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

        }

        private void GetOrderDetails_button_Click(object sender, EventArgs e)
        {
            CheckOrders cho = new CheckOrders();

            int num;
           string orderId = OrderId_textBox1.Text;
            bool IsOrderIdValid = int.TryParse(orderId, out num);

            if (IsOrderIdValid)
            {
                int _orderId = int.Parse(orderId);

                if (cho.ICheckIfOrderExist(_orderId))
                {
                    var sqlCommand = $" SELECT UserName,FirstName,LastName into #TempTable FROM Users  SELECT * FROM #TempTable left join Orders on   #TempTable.UserName = Orders.UserName where OrderId =  '{orderId}'; ";
                    var c = new SqlConnection(connString);


                    using (SqlConnection conn = new SqlConnection(connString))
                    {
                        var dataAdapter = new SqlDataAdapter(sqlCommand, c);

                        conn.Open();



                        using (SqlCommand cmd = new SqlCommand(sqlCommand, conn))
                        {


                            var commandBuilder = new SqlCommandBuilder(dataAdapter);
                            var ds = new DataSet();
                            dataAdapter.Fill(ds);
                            dataGridView1.DataSource = ds.Tables[0];

                            conn.Close();
                        }
                    }
                }

                else
                {
                    MessageBox.Show($"Order with Id '{orderId}' Doesn't Exist");
                }
            }
            else
            {
                MessageBox.Show("Enter a valid input", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void AdminsForm_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminsAddingOrderForm ado = new AdminsAddingOrderForm();
            ado.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GetOrderIdAdminForm go = new GetOrderIdAdminForm();
            go.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CancelOrderAdminsForm co = new CancelOrderAdminsForm();
            CancelOrderAdminsForm co2 = new CancelOrderAdminsForm(dataGridView1);

            co.ShowDialog();
        }

       

     

        private void button5_Click(object sender, EventArgs e)
        {
            string day = dateTimePicker1.Value.Day.ToString();
            string month = dateTimePicker1.Value.Month.ToString();
            string year = dateTimePicker1.Value.Year.ToString();
            string FilterDate = $"{year}/{month}/{day}";


            AdminFilterOrdersCommands filterOrders = new AdminFilterOrdersCommands();
            ICommand filter = new AdminsFilterOrderCommand(filterOrders, FilterDate, dataGridView1);
            AdminFilterOrdersCMD ordersCMD = new AdminFilterOrdersCMD(filter);
            ordersCMD.adminfilter();

        }

    }
}
