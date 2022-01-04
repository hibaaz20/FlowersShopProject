using HackerU_MidProject1;
using Project8.DataAccess.CommandDesignPattern;
using Project8.DataAccess.CommandDesignPattern.UserCommands;
using Project8.DataAccess.Methods.CheckLength;
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
using UpdatePWCommands = Project8.DataAccess.CommandDesignPattern.UserCommands.UpdatePWCommands;

namespace Project8
{
    public partial class RecoverPWForm : Form
    {
        public RecoverPWForm()
        {
            InitializeComponent();
            Password_textBox.PasswordChar = '*';

        }

        private void SetNewPW_Butt_Click(object sender, EventArgs e)
        {
            CheckIfuserExist checkIfuser = new CheckIfuserExist();
            string userName = Username_textBox.Text;
            string PW = Password_textBox.Text;


            if (checkIfuser.IfUserExist(userName) )
            {
                if (Password_textBox.Text.Length < 5 )
                {
                    MessageBox.Show("Password must be at least 5 characters and less than 15");
                }
                else
                {
                    UpdatePWCommands command = new UpdatePWCommands();
                    ICommand updatecmd = new UpdateCommand(command, userName,PW);
                    UpdateCMD updateCmd = new UpdateCMD(updatecmd);

                    updateCmd.update();

                    MessageBox.Show("Password Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                }
                

            }

            else if (checkIfuser.IfAdminExist(userName))
            {
                if (Password_textBox.Text.Length < 5)
                {
                    MessageBox.Show("Password must be at least 5 characters and less than 15");
                    
                }
                else
                {

                    AdminCommand command = new AdminCommand();
                    ICommand updatecmd = new AUpdateCommand(command, userName, PW);
                    updatecmd.Execute();

                    MessageBox.Show("Password Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                }
               

            }

            else
            {
                MessageBox.Show("This Username doesn't exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }


        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void RecoverPWForm_Load(object sender, EventArgs e)
        {
            CenterToScreen();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Password_textBox.PasswordChar = (checkBox1.Checked ? char.MinValue : '*');

        }
    }
}
