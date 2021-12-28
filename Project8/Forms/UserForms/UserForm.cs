using HackerU_MidProject2.Database;
using Microsoft.Data.SqlClient;
using Project8.Database;
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

namespace Project8.Forms.UserForms
{
    public partial class UserForm : Form
    {
        public static string connString = SqlConn.stringConn;

        static string username;
        static string password;

        public UserForm()
        {
            InitializeComponent();
        }
        public UserForm(TextBox text)
        {
            username = text.Text;
        }

        private void EditOrder_Button_Click(object sender, EventArgs e)
        {
            GetOrderId goi = new GetOrderId();
            goi.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ShowDetailsButton_Click(object sender, EventArgs e)
        {


            var sqlCommand = $" SELECT * INTO #TempTable3 FROM Users ALTER TABLE #TempTable3 DROP COLUMN  UserPassword SELECT FirstName,LastName,OrderId FROM #TempTable3  join Orders ON #TempTable3.UserName = Orders.UserName  where Orders.UserName =  '{username}'; ";
            var sqlCommand2 = $" SELECT * INTO #TempTable3 FROM Users ALTER TABLE #TempTable3 DROP COLUMN  UserPassword SELECT FirstName,LastName FROM #TempTable3    where UserName =  '{username}'; ";

            var c = new SqlConnection(connString);


            using (SqlConnection conn = new SqlConnection(connString))
            {
                CheckOrders cho = new CheckOrders();

           

                conn.Open();
                if (cho.IsUserHasOrders(username))
                {     var dataAdapter = new SqlDataAdapter(sqlCommand, c);
                    using (SqlCommand cmd = new SqlCommand(sqlCommand, conn))
                    {

                        var commandBuilder = new SqlCommandBuilder(dataAdapter);
                        var ds = new DataSet();
                        dataAdapter.Fill(ds);
                        dataGridView1.DataSource = ds.Tables[0];

                        conn.Close();
                    }
                }
                else
                {
                    var dataAdapter = new SqlDataAdapter(sqlCommand2, c);
                    using (SqlCommand cmd = new SqlCommand(sqlCommand2, conn))
                    {

                        var commandBuilder = new SqlCommandBuilder(dataAdapter);
                        var ds = new DataSet();
                        dataAdapter.Fill(ds);
                        dataGridView1.DataSource = ds.Tables[0];

                        conn.Close();
                    }
                    MessageBox.Show("You Didnt Place Any Order Yet", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }



            }
        }

        private void AddOrder_Button_Click(object sender, EventArgs e)
        {
            AddOrderForm adf = new AddOrderForm();
            adf.ShowDialog();
        }

        private void DeleteAccount_Button_Click(object sender, EventArgs e)
        {
            DialogResult result =  MessageBox.Show("Are you sure you want to delete your account","Deleting account",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                CRUD.UsersClass.Delete(username, password);
                MessageBox.Show("Your account has been deleted");
                this.Hide();

            }
            
        }

        private void CancelOrder_button_Click(object sender, EventArgs e)
        {
            CancelOrderForm cof = new CancelOrderForm();
            CancelOrderForm cof2 = new CancelOrderForm(dataGridView1);
            CancelOrderForm cof3 = new CancelOrderForm(username);

            cof.ShowDialog();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
        }

        private void ShowOrderDetailsbutton_Click(object sender, EventArgs e)
        {


            var sqlCommand = $" SELECT * INTO #TempTable3 FROM Flowers  SELECT * FROM #TempTable3 right join Orders ON #TempTable3.FlowerType = Orders.ItemName where Orders.OrderId = '{OrderIDtextBox1.Text}'; ";

            var c = new SqlConnection(connString);


            using (SqlConnection conn = new SqlConnection(connString))
            {
                CheckOrders cho = new CheckOrders();
                if (cho.IsUserHasOrders(username))
                {
                    int num;
                    bool isOrderIdInt = int.TryParse(OrderIDtextBox1.Text, out num);
                    if (isOrderIdInt)
                    {
                        if (cho.ICheckIfOrderExist(int.Parse(OrderIDtextBox1.Text)))
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
                        else
                        {
                            MessageBox.Show($"Order With Id {OrderIDtextBox1.Text} Doesnt Exist", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Enter Valid Input", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }
                else
                {

                    MessageBox.Show("You Didnt Place Any Order Yet", "No Orders Found", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.ReadOnly = true;

        }

        private void button5_Click(object sender, EventArgs e)
        {  
            CheckOrders ch = new CheckOrders();
            string day = dateTimePicker1.Value.Day.ToString();
            string month = dateTimePicker1.Value.Month.ToString();
            string year = dateTimePicker1.Value.Year.ToString();
            string FilterDate = $"{year}/{month}/{day}";


            if (dateTimePicker1.Value > DateTime.Now)
            {
                MessageBox.Show("Enter a valid date");
            }

            else if (ch.IsUserHasOrders(username) == false)
            {
                MessageBox.Show("You didn't place any order yet");

            }

            else
            {
                CRUD.OrdersClass.FilterOrdersByUserName(FilterDate, username, dataGridView1);
            }
        }
    }
}
