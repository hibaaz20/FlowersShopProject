
namespace Project8.Forms.UserForms
{
    partial class UserForm
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
            this.ShowDetailsButton = new System.Windows.Forms.Button();
            this.AddOrder_Button = new System.Windows.Forms.Button();
            this.EditOrder_Button = new System.Windows.Forms.Button();
            this.CancelOrder_button = new System.Windows.Forms.Button();
            this.DeleteAccount_Button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.OrderIDtextBox1 = new System.Windows.Forms.TextBox();
            this.ShowOrderDetailsbutton = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(347, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(485, 235);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ShowDetailsButton
            // 
            this.ShowDetailsButton.BackColor = System.Drawing.Color.White;
            this.ShowDetailsButton.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowDetailsButton.Location = new System.Drawing.Point(81, 30);
            this.ShowDetailsButton.Name = "ShowDetailsButton";
            this.ShowDetailsButton.Size = new System.Drawing.Size(194, 50);
            this.ShowDetailsButton.TabIndex = 1;
            this.ShowDetailsButton.Text = "Show My Details";
            this.ShowDetailsButton.UseVisualStyleBackColor = false;
            this.ShowDetailsButton.Click += new System.EventHandler(this.ShowDetailsButton_Click);
            // 
            // AddOrder_Button
            // 
            this.AddOrder_Button.BackColor = System.Drawing.Color.LightBlue;
            this.AddOrder_Button.Font = new System.Drawing.Font("Century751 SeBd BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddOrder_Button.ForeColor = System.Drawing.Color.Black;
            this.AddOrder_Button.Location = new System.Drawing.Point(326, 361);
            this.AddOrder_Button.Name = "AddOrder_Button";
            this.AddOrder_Button.Size = new System.Drawing.Size(147, 45);
            this.AddOrder_Button.TabIndex = 2;
            this.AddOrder_Button.Text = "Add Order";
            this.AddOrder_Button.UseVisualStyleBackColor = false;
            this.AddOrder_Button.Click += new System.EventHandler(this.AddOrder_Button_Click);
            // 
            // EditOrder_Button
            // 
            this.EditOrder_Button.BackColor = System.Drawing.Color.PowderBlue;
            this.EditOrder_Button.Font = new System.Drawing.Font("Century751 SeBd BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditOrder_Button.Location = new System.Drawing.Point(685, 361);
            this.EditOrder_Button.Name = "EditOrder_Button";
            this.EditOrder_Button.Size = new System.Drawing.Size(147, 45);
            this.EditOrder_Button.TabIndex = 3;
            this.EditOrder_Button.Text = "Edit Order";
            this.EditOrder_Button.UseVisualStyleBackColor = false;
            this.EditOrder_Button.Click += new System.EventHandler(this.EditOrder_Button_Click);
            // 
            // CancelOrder_button
            // 
            this.CancelOrder_button.BackColor = System.Drawing.Color.LightBlue;
            this.CancelOrder_button.Font = new System.Drawing.Font("Century751 SeBd BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelOrder_button.Location = new System.Drawing.Point(511, 361);
            this.CancelOrder_button.Name = "CancelOrder_button";
            this.CancelOrder_button.Size = new System.Drawing.Size(147, 45);
            this.CancelOrder_button.TabIndex = 4;
            this.CancelOrder_button.Text = "Cancel Order";
            this.CancelOrder_button.UseVisualStyleBackColor = false;
            this.CancelOrder_button.Click += new System.EventHandler(this.CancelOrder_button_Click);
            // 
            // DeleteAccount_Button
            // 
            this.DeleteAccount_Button.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DeleteAccount_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteAccount_Button.Location = new System.Drawing.Point(12, 446);
            this.DeleteAccount_Button.Name = "DeleteAccount_Button";
            this.DeleteAccount_Button.Size = new System.Drawing.Size(132, 45);
            this.DeleteAccount_Button.TabIndex = 5;
            this.DeleteAccount_Button.Text = "Delete Account";
            this.DeleteAccount_Button.UseVisualStyleBackColor = false;
            this.DeleteAccount_Button.Click += new System.EventHandler(this.DeleteAccount_Button_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(708, 446);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 45);
            this.button1.TabIndex = 6;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Snow;
            this.label1.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(321, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 28);
            this.label1.TabIndex = 7;
            this.label1.Text = "Order Id:";
            // 
            // OrderIDtextBox1
            // 
            this.OrderIDtextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderIDtextBox1.Location = new System.Drawing.Point(464, 291);
            this.OrderIDtextBox1.Name = "OrderIDtextBox1";
            this.OrderIDtextBox1.Size = new System.Drawing.Size(162, 29);
            this.OrderIDtextBox1.TabIndex = 8;
            // 
            // ShowOrderDetailsbutton
            // 
            this.ShowOrderDetailsbutton.BackColor = System.Drawing.Color.Khaki;
            this.ShowOrderDetailsbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowOrderDetailsbutton.Location = new System.Drawing.Point(651, 289);
            this.ShowOrderDetailsbutton.Name = "ShowOrderDetailsbutton";
            this.ShowOrderDetailsbutton.Size = new System.Drawing.Size(162, 37);
            this.ShowOrderDetailsbutton.TabIndex = 9;
            this.ShowOrderDetailsbutton.Text = "Show Order Details";
            this.ShowOrderDetailsbutton.UseVisualStyleBackColor = false;
            this.ShowOrderDetailsbutton.Click += new System.EventHandler(this.ShowOrderDetailsbutton_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(97, 232);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(130, 33);
            this.button5.TabIndex = 30;
            this.button5.Text = "Filter";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FloralWhite;
            this.label3.Font = new System.Drawing.Font("David", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label3.Location = new System.Drawing.Point(11, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(330, 27);
            this.label3.TabIndex = 29;
            this.label3.Text = "Filter all orders from date :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(81, 179);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(203, 24);
            this.dateTimePicker1.TabIndex = 32;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(852, 503);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ShowOrderDetailsbutton);
            this.Controls.Add(this.OrderIDtextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DeleteAccount_Button);
            this.Controls.Add(this.CancelOrder_button);
            this.Controls.Add(this.EditOrder_Button);
            this.Controls.Add(this.AddOrder_Button);
            this.Controls.Add(this.ShowDetailsButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.Load += new System.EventHandler(this.UserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ShowDetailsButton;
        private System.Windows.Forms.Button AddOrder_Button;
        private System.Windows.Forms.Button EditOrder_Button;
        private System.Windows.Forms.Button CancelOrder_button;
        private System.Windows.Forms.Button DeleteAccount_Button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox OrderIDtextBox1;
        private System.Windows.Forms.Button ShowOrderDetailsbutton;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}