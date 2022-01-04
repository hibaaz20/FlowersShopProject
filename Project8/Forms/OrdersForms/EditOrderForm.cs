using Project8.DataAccess.CommandDesignPattern;
using Project8.DataAccess.CommandDesignPattern.OrdersCommands;
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
    public partial class EditOrderForm : Form
    {
        static string username;
        static string FlowerType;
        static string FlowerColor;
        static string orderid;

        public EditOrderForm()
        {
            InitializeComponent();
        }

        public EditOrderForm(TextBox orderID)
        {
            orderid = orderID.Text;
        }

    
        

        private void EditOrderForm_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (radioButton1Rose.Checked)
            {
                FlowerType = "Rose";
            }
            else if (radioButton1Azalea.Checked)
            {
                FlowerType = "Azalea";

            }
            else if (radioButton1Aster.Checked)
            {
                FlowerType = "Aster";
            }
            else if (radioButton1Buttercup.Checked)
            {
                FlowerType = "Buttercup";
            }
            else if (radioButton1Crocus.Checked)
            {
                FlowerType = "Crocus";
            }

            if (RedRadioButton.Checked)
            {
                FlowerColor = "Red";
            }
            else if (YellowradioButton1.Checked)
            {
                FlowerColor = "Yellow";

            }
            else if (BlueRadioButton.Checked)
            {
                FlowerColor = "Blue";

            }
            else if (WhiteradioButton.Checked)
            {
                FlowerColor = "White";

            }
            else if (PinkradioButton1.Checked)
            {
                FlowerColor = "Pink";

            }
            else
            {
                MessageBox.Show("Please choose a color", "Didn't select a color", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            int num;
            int quantity;
            int orderId;

            bool isQuantityInt = int.TryParse(QuantitytextBox1.Text, out num);
            bool isOrderidInt = int.TryParse(orderid, out num);

            if (string.IsNullOrEmpty(QuantitytextBox1.Text))
            {
                MessageBox.Show("Please Fill The Quantity Textbox", "Quantity textbox is empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {

                if (isQuantityInt)
                {
                    quantity = int.Parse(QuantitytextBox1.Text);
                    orderId = int.Parse(orderid);

                    UpdateOrderCommands command = new UpdateOrderCommands();
                    ICommand updateCommand = new UpdateOrderCommand(command, orderId,FlowerType,FlowerColor,quantity);
                    UpdateOrdersCMD updatecmd = new UpdateOrdersCMD(updateCommand);

                    updatecmd.update();

                    MessageBox.Show("Your order updated");
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Enter Vaild Input", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
