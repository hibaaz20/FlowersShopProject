
namespace Project8
{
    partial class MainLoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Login_button = new System.Windows.Forms.Button();
            this.RecoverPWbutton1 = new System.Windows.Forms.Button();
            this.Username_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CreateAccount_Button = new System.Windows.Forms.Button();
            this.Password_textBox = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Login_button
            // 
            this.Login_button.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_button.Location = new System.Drawing.Point(444, 253);
            this.Login_button.Name = "Login_button";
            this.Login_button.Size = new System.Drawing.Size(128, 32);
            this.Login_button.TabIndex = 4;
            this.Login_button.Text = "Login";
            this.Login_button.UseVisualStyleBackColor = true;
            this.Login_button.Click += new System.EventHandler(this.Login_button_Click);
            // 
            // RecoverPWbutton1
            // 
            this.RecoverPWbutton1.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecoverPWbutton1.ForeColor = System.Drawing.Color.Black;
            this.RecoverPWbutton1.Location = new System.Drawing.Point(149, 264);
            this.RecoverPWbutton1.Name = "RecoverPWbutton1";
            this.RecoverPWbutton1.Size = new System.Drawing.Size(128, 26);
            this.RecoverPWbutton1.TabIndex = 6;
            this.RecoverPWbutton1.Text = "Click Here";
            this.RecoverPWbutton1.UseVisualStyleBackColor = true;
            this.RecoverPWbutton1.Click += new System.EventHandler(this.RecoverPWbutton1_Click);
            // 
            // Username_textBox
            // 
            this.Username_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username_textBox.Location = new System.Drawing.Point(444, 144);
            this.Username_textBox.Name = "Username_textBox";
            this.Username_textBox.Size = new System.Drawing.Size(128, 26);
            this.Username_textBox.TabIndex = 10;
            this.Username_textBox.TextChanged += new System.EventHandler(this.Username_textBox_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(311, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(315, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Futura Md BT", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(308, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(306, 45);
            this.label4.TabIndex = 14;
            this.label4.Text = " FLOWERS SHOP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 19);
            this.label3.TabIndex = 15;
            this.label3.Text = "Forgot Password?";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.CreateAccount_Button);
            this.groupBox1.Location = new System.Drawing.Point(128, 313);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(515, 121);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Levenim MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(129, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(296, 35);
            this.label5.TabIndex = 10;
            this.label5.Text = "Don\'t Have Account?";
            // 
            // CreateAccount_Button
            // 
            this.CreateAccount_Button.Font = new System.Drawing.Font("Footlight MT Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateAccount_Button.ForeColor = System.Drawing.Color.Black;
            this.CreateAccount_Button.Location = new System.Drawing.Point(193, 74);
            this.CreateAccount_Button.Name = "CreateAccount_Button";
            this.CreateAccount_Button.Size = new System.Drawing.Size(142, 36);
            this.CreateAccount_Button.TabIndex = 9;
            this.CreateAccount_Button.Text = "Create One";
            this.CreateAccount_Button.UseVisualStyleBackColor = true;
            this.CreateAccount_Button.Click += new System.EventHandler(this.CreateAccount_Button_Click_1);
            // 
            // Password_textBox
            // 
            this.Password_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_textBox.Location = new System.Drawing.Point(444, 201);
            this.Password_textBox.Name = "Password_textBox";
            this.Password_textBox.Size = new System.Drawing.Size(128, 26);
            this.Password_textBox.TabIndex = 12;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(578, 206);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 20);
            this.checkBox1.TabIndex = 17;
            this.checkBox1.Text = "Show pw";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // MainLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.BackgroundImage = global::Project8.Properties.Resources.pngtree_simple_flower_cosmetics_psd_layered_master_map_background_material_image_155839;
            this.ClientSize = new System.Drawing.Size(669, 446);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Password_textBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Username_textBox);
            this.Controls.Add(this.RecoverPWbutton1);
            this.Controls.Add(this.Login_button);
            this.ForeColor = System.Drawing.Color.DarkRed;
            this.Name = "MainLoginForm";
            this.Text = "form1";
            this.Load += new System.EventHandler(this.MainLoginForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Login_button;
        private System.Windows.Forms.Button RecoverPWbutton1;
        private System.Windows.Forms.TextBox Username_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button CreateAccount_Button;
        private System.Windows.Forms.TextBox Password_textBox;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}