using HackerU_MidProject2.Database;
using Project8.Database;
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
    public partial class CancelOrderForm : Form
    {
        static DataGridView datagridView;
        static string username;
        public CancelOrderForm()
        {
            InitializeComponent();
        }
        public CancelOrderForm(string un)
        {
            username = un;
        }
        public CancelOrderForm(DataGridView dataGridView)
        {
            datagridView = dataGridView;
        }

        private void button1_Click(object sender, EventArgs e)
        {  
            CheckOrders cho = new CheckOrders();
            int num;

            bool isInt = int.TryParse(textBox1.Text, out num);

            if (isInt)
            {
                if (cho.ICheckIfOrderExist(int.Parse(textBox1.Text)))
                {
                    CRUD.OrdersClass.Deleteorder(int.Parse(textBox1.Text));

                    MessageBox.Show("Order Canceled!");

                    CRUD.OrdersClass.ShowOrders(username,datagridView);
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Order doesnt exist");
                }
            }

            else
            {
                MessageBox.Show("Enter Valid Id");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

     

        private void CancelOrderForm_Load(object sender, EventArgs e)
        {
            CenterToScreen();

        }
    }
}
