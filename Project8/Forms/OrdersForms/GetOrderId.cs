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
    public partial class GetOrderId : Form
    {
        public GetOrderId()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num;
            bool isOrderIdVaild = int.TryParse(textBox1.Text, out num);
            if (isOrderIdVaild)
            {
                CheckOrders cho = new CheckOrders();

                if (cho.ICheckIfOrderExist(int.Parse(textBox1.Text)))

                {
                    EditOrderForm eof = new EditOrderForm();
                    EditOrderForm eo = new EditOrderForm(textBox1);
                    eof.ShowDialog();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Id Number doesnt exist");
                }
            }
            else
            {
                MessageBox.Show("Enter Vaild Input", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

     

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

     

        private void GetOrderId_Load(object sender, EventArgs e)
        {
            CenterToScreen();

        }
    }
}
