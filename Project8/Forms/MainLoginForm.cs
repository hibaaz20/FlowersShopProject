using HackerU_MidProject1;
using Project8.Forms;
using Project8.Forms.UserForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project8
{
    public partial class MainLoginForm : Form
    {
        public MainLoginForm()
        {
            InitializeComponent();
            Password_textBox.PasswordChar = '*';
        }

    
     
     
        private void MainLoginForm_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }

     
    
       

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

     
      

        private void Login_button_Click(object sender, EventArgs e)
        {
            LoginMethods lm = new LoginMethods();
            string username =Username_textBox.Text;
            string pw = Password_textBox.Text;
            if (lm.CheckUsername(username, pw))
            {
                MessageBox.Show($"Hello {username}");
                UserForm UW = new UserForm();
                UW.ShowDialog();
            }
            else if (lm.CheckAdmin(username,pw))
            {
                MessageBox.Show($"Hello {username}");
                AdminsForm adminsForm = new AdminsForm();
                adminsForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("One of the fileds you entered is incorrect", "Username or password is incorrect",  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      

      
      
        private void RecoverPWbutton1_Click(object sender, EventArgs e)
        {
            RecoverPWForm uspw = new RecoverPWForm();
            uspw.ShowDialog();
        }

        private void CreateAccount_Button_Click_1(object sender, EventArgs e)
        {
            CreateAcc_Form caf = new CreateAcc_Form();
            caf.ShowDialog();

        }

        private void Username_textBox_TextChanged_1(object sender, EventArgs e)
        {

            UserForm usf = new UserForm(Username_textBox);
            AddOrderForm adf = new AddOrderForm(Username_textBox);
        }

      
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Password_textBox.PasswordChar = (checkBox1.Checked ? char.MinValue : '*');
        }
    }
}
