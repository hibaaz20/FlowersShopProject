using Project8.DataAccess.CommandDesignPattern;
using Project8.DataAccess.CommandDesignPattern.UserCommands;
using Project8.DataAccess.Methods.CheckLength;
using Project8.DataAccess.Methods.CheckValidation;
using Project8.Methods;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Project8.Forms
{
    
    public partial class CreateAcc_Form : Form
    {
       


        public CreateAcc_Form()
        {
            InitializeComponent();
            Password_TextBox.PasswordChar = '*';

        }

        private void Back_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

     
        private void CreateAcc_Butt_Click(object sender, EventArgs e)
        {

            
            string Fname = FirstName_Text.Text;
            string Lname = Lastname_textBox.Text;
            string userName = Username_textBox.Text;
            string pw = Password_TextBox.Text;

            AddUserCommands command = new AddUserCommands();
            ICommand addcommand = new AddCommand(command, Fname, Lname, userName, pw);
            AddUserCMD crud = new AddUserCMD(addcommand);


            CreateAccMethods cam = new CreateAccMethods();


            if (String.IsNullOrEmpty(FirstName_Text.Text))
            {
                MessageBox.Show("First name field Is Required");
            }
            else if (CheckInputLength.ILength(FirstName_Text.Text) == false)
            {
                MessageBox.Show("First name must be less than 10 letters");
            }
            else if (IsFieldValid.isInputVlid(FirstName_Text.Text) == false)
            {
                MessageBox.Show("First Name cant take numbers");

            }




            else if(String.IsNullOrEmpty(Lastname_textBox.Text))
            {
                MessageBox.Show("Last name field Is Required");
            }
            else if (CheckInputLength.ILength(Lastname_textBox.Text) == false)
            {
                MessageBox.Show("Last name must be less than 10 letters");
            }
            else if (IsFieldValid.isInputVlid(Lastname_textBox.Text) == false)
            {
                MessageBox.Show("Last Name cant take numbers");

            }





            else if (String.IsNullOrEmpty(Password_TextBox.Text))
            {
                 MessageBox.Show("Password field Is Required");
            }
            else if (CheckPasswordLength.PLength(Password_TextBox.Text) == false)
            {
                MessageBox.Show("Password must be at least 5 characters and less than 15");
            }
            



            else if (String.IsNullOrEmpty(Username_textBox.Text))
            {
                MessageBox.Show("Username field Is Required");
            }
            else if (CheckInputLength.ILength(Username_textBox.Text) == false)
            {
                MessageBox.Show("Username must be less than 10 letters");
            }




            else if (cam.IsUsernameAvaliable(userName) ==true)
            {
                MessageBox.Show("This Username is already exist, please choose another one.","Username already exist",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            else
            {
                crud.add();

                MessageBox.Show("You are a member now!");
                MainLoginForm mf = new MainLoginForm();
                this.Hide();
            }            
        }

    
        private void CreateAcc_Form_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Password_TextBox.PasswordChar = (checkBox1.Checked ? char.MinValue : '*');

        }
    }
}
