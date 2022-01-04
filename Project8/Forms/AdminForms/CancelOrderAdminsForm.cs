using Project8.DataAccess.CommandDesignPattern;
using Project8.DataAccess.CommandDesignPattern.AdminsCommands;
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
                    DeleteOrdersCommands command = new DeleteOrdersCommands();
                    ICommand deleteorder = new DeleteeOrderCommand(command, int.Parse(textBox1.Text));
                    DeleteOrdersCMD deleteOrders = new DeleteOrdersCMD(deleteorder);
                    deleteOrders.delete();


                    MessageBox.Show("Order Canceled!");


                    AdminsShowOrders command2 = new AdminsShowOrders();
                    ICommand showorder = new AdminShowOrderCommand(command2, datagridView);
                    AdminShowOrdersCMD showOrdersCMD = new AdminShowOrdersCMD(showorder);
                    deleteOrders.delete();


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

      
    }
}
