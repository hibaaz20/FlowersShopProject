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
    public partial class AddOrderForm : Form
    {
        static string username;
        static string FlowerType;
        static string FlowerColor;

      

        public AddOrderForm()
        {
            InitializeComponent();
        }
        public AddOrderForm(TextBox UN)
        {
            username = UN.Text;
        }

     
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }






        private void button1_Click(object sender, EventArgs e)
        {

            if (radioButton1Rose.Checked)
            {
                FlowerType = Flowers.Rose.ToString(); ;
            }
            else if (radioButton1Azalea.Checked)
            {
                FlowerType = Flowers.Azalea.ToString();

            }
            else if (radioButton1Aster.Checked)
            {
                FlowerType = Flowers.Aster.ToString();
            }
            else if (radioButton1Buttercup.Checked)
            {
                FlowerType = Flowers.Buttercup.ToString();
            }
            else if (radioButton1Crocus.Checked)
            {
                FlowerType = Flowers.Crocus.ToString();
            }


            if (RedRadioButton.Checked)
            {
                FlowerColor = Colors.Red.ToString();
            }
            else if (YellowradioButton1.Checked)
            {
                FlowerColor = Colors.Yellow.ToString();

            }
            else if (BlueRadioButton.Checked)
            {
                FlowerColor = Colors.Blue.ToString();

            }
            else if (WhiteradioButton.Checked)
            {
                FlowerColor = Colors.White.ToString();

            }
            else if (PinkradioButton1.Checked)
            {
                FlowerColor = Colors.Pink.ToString();

            }
            else
            {
                MessageBox.Show("Please choose a color", "Didn't select a color", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Random r1 = new Random();
            int orderid = r1.Next(5000);
            int num;
            bool isQuantityInt = int.TryParse(QuantitytextBox1.Text, out num);
            int quantity;

          

            if (string.IsNullOrEmpty(QuantitytextBox1.Text))
            {
                MessageBox.Show("Please Fill The Quantity Textbox", "Quantity textbox is empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {

                if (isQuantityInt)
                {
                    quantity = int.Parse(QuantitytextBox1.Text);

                    if (quantity > 0)
                    {
                        AddOrderCommands command = new AddOrderCommands();
                        ICommand addOrder = new AddOrderCommand(command, username, orderid, FlowerType, FlowerColor, quantity);
                        AddOrdersCMD ordersCMD = new AddOrdersCMD(addOrder);

                        ordersCMD.add();

                        MessageBox.Show("We received your order!");

                    }
                    else
                    {
                        MessageBox.Show("Enter Vaild Number", "Invalid Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Enter Vaild Input", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    
        

     
   

     

     
    } 
    enum  Flowers
        {
            Rose,
        Azalea,
        Aster, 
        Buttercup,
        Crocus
    }
    enum Colors
        {
        Red,
        Yellow,
        Blue,
        White,
        Pink
    }
}
