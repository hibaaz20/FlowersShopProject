using HackerU_MidProject1;
using HackerU_MidProject2.Database;
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
                CRUD.UsersClass.Update(userName, PW);

                MessageBox.Show("Password Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();

            }

            else if (checkIfuser.IfAdminExist(userName))
            {
                CRUD.AdminsClass.AUpdate(userName, PW);
                MessageBox.Show("Password Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();

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
