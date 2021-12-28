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

namespace Project8.Forms.AdminForms
{
    public partial class CancelOrderAdminsForm : Form
    {
      static DataGridView datagridView;
        public CancelOrderAdminsForm()
        {
            InitializeComponent();
        }


        public CancelOrderAdminsForm(DataGridView dataGridView)
        {
            datagridView = dataGridView;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
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

                    CRUD.OrdersClass.AdminShowOrders(datagridView);

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

        private void CancelOrderAdminsForm_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
