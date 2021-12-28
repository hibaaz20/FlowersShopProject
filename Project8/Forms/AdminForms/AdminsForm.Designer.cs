
namespace Project8.Forms
{
    partial class AdminsForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.ShowUsers_button = new System.Windows.Forms.Button();
            this.Back_Button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.UserName_textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.GetOrderDetails_button = new System.Windows.Forms.Button();
            this.OrderId_textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(468, 384);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("David", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(153, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Users List:";
            // 
            // ShowUsers_button
            // 
            this.ShowUsers_button.BackColor = System.Drawing.Color.Gold;
            this.ShowUsers_button.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowUsers_button.Location = new System.Drawing.Point(627, 82);
            this.ShowUsers_button.Name = "ShowUsers_button";
            this.ShowUsers_button.Size = new System.Drawing.Size(186, 40);
            this.ShowUsers_button.TabIndex = 2;
            this.ShowUsers_button.Text = "Show Users";
            this.ShowUsers_button.UseVisualStyleBackColor = false;
            this.ShowUsers_button.Click += new System.EventHandler(this.ShowUsers_button_Click);
            // 
            // Back_Button
            // 
            this.Back_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_Button.Location = new System.Drawing.Point(18, 507);
            this.Back_Button.Name = "Back_Button";
            this.Back_Button.Size = new System.Drawing.Size(125, 39);
            this.Back_Button.TabIndex = 9;
            this.Back_Button.Text = "Back";
            this.Back_Button.UseVisualStyleBackColor = true;
            this.Back_Button.Click += new System.EventHandler(this.Back_Button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(492, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "Enter Username:";
            // 
            // UserName_textBox1
            // 
            this.UserName_textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName_textBox1.Location = new System.Drawing.Point(642, 160);
            this.UserName_textBox1.Name = "UserName_textBox1";
            this.UserName_textBox1.Size = new System.Drawing.Size(155, 31);
            this.UserName_textBox1.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(803, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 31);
            this.button1.TabIndex = 12;
            this.button1.Text = "Get User Details";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GetOrderDetails_button
            // 
            this.GetOrderDetails_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetOrderDetails_button.Location = new System.Drawing.Point(803, 239);
            this.GetOrderDetails_button.Name = "GetOrderDetails_button";
            this.GetOrderDetails_button.Size = new System.Drawing.Size(138, 32);
            this.GetOrderDetails_button.TabIndex = 14;
            this.GetOrderDetails_button.Text = "Get Order Details";
            this.GetOrderDetails_button.UseVisualStyleBackColor = true;
            this.GetOrderDetails_button.Click += new System.EventHandler(this.GetOrderDetails_button_Click);
            // 
            // OrderId_textBox1
            // 
            this.OrderId_textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderId_textBox1.Location = new System.Drawing.Point(642, 240);
            this.OrderId_textBox1.Name = "OrderId_textBox1";
            this.OrderId_textBox1.Size = new System.Drawing.Size(155, 31);
            this.OrderId_textBox1.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(492, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 29);
            this.label4.TabIndex = 16;
            this.label4.Text = "Enter Order Id:";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(497, 341);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 43);
            this.button2.TabIndex = 17;
            this.button2.Text = "Add Order";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(653, 341);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 43);
            this.button3.TabIndex = 18;
            this.button3.Text = "Edit Order";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(803, 341);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(130, 43);
            this.button4.TabIndex = 19;
            this.button4.Text = "Cancel Order";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FloralWhite;
            this.label3.Font = new System.Drawing.Font("David", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label3.Location = new System.Drawing.Point(529, 427);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(351, 28);
            this.label3.TabIndex = 20;
            this.label3.Text = "Filter all orders from date :";
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(667, 513);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(130, 27);
            this.button5.TabIndex = 27;
            this.button5.Text = "Filter";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(618, 467);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(205, 24);
            this.dateTimePicker1.TabIndex = 29;
            // 
            // AdminsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project8.Properties.Resources.flower_3415550_960_7203;
            this.ClientSize = new System.Drawing.Size(962, 558);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.OrderId_textBox1);
            this.Controls.Add(this.GetOrderDetails_button);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.UserName_textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Back_Button);
            this.Controls.Add(this.ShowUsers_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AdminsForm";
            this.Tag = "";
            this.Text = "AdminsForm";
            this.Load += new System.EventHandler(this.AdminsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ShowUsers_button;
        private System.Windows.Forms.Button Back_Button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UserName_textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button GetOrderDetails_button;
        private System.Windows.Forms.TextBox OrderId_textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}