
namespace Project8
{
    partial class RecoverPWForm
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
            this.Back = new System.Windows.Forms.Button();
            this.SetNewPW_Butt = new System.Windows.Forms.Button();
            this.Password_textBox = new System.Windows.Forms.TextBox();
            this.Username_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.Khaki;
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Location = new System.Drawing.Point(527, 174);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(91, 39);
            this.Back.TabIndex = 18;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // SetNewPW_Butt
            // 
            this.SetNewPW_Butt.BackColor = System.Drawing.Color.Khaki;
            this.SetNewPW_Butt.Font = new System.Drawing.Font("Century751 SeBd BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetNewPW_Butt.Location = new System.Drawing.Point(255, 174);
            this.SetNewPW_Butt.Name = "SetNewPW_Butt";
            this.SetNewPW_Butt.Size = new System.Drawing.Size(165, 39);
            this.SetNewPW_Butt.TabIndex = 17;
            this.SetNewPW_Butt.Text = "Set New Password";
            this.SetNewPW_Butt.UseVisualStyleBackColor = false;
            this.SetNewPW_Butt.Click += new System.EventHandler(this.SetNewPW_Butt_Click);
            // 
            // Password_textBox
            // 
            this.Password_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_textBox.Location = new System.Drawing.Point(255, 123);
            this.Password_textBox.Name = "Password_textBox";
            this.Password_textBox.Size = new System.Drawing.Size(165, 35);
            this.Password_textBox.TabIndex = 16;
            // 
            // Username_textBox
            // 
            this.Username_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username_textBox.Location = new System.Drawing.Point(255, 49);
            this.Username_textBox.Name = "Username_textBox";
            this.Username_textBox.Size = new System.Drawing.Size(165, 35);
            this.Username_textBox.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(71, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 28);
            this.label4.TabIndex = 14;
            this.label4.Text = "New Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(71, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 28);
            this.label3.TabIndex = 13;
            this.label3.Text = "Username:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(439, 129);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(92, 24);
            this.checkBox1.TabIndex = 19;
            this.checkBox1.Text = "Show pw";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // RecoverPWForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 223);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.SetNewPW_Butt);
            this.Controls.Add(this.Password_textBox);
            this.Controls.Add(this.Username_textBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "RecoverPWForm";
            this.Text = "RecoverPWForm";
            this.Load += new System.EventHandler(this.RecoverPWForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button SetNewPW_Butt;
        private System.Windows.Forms.TextBox Password_textBox;
        private System.Windows.Forms.TextBox Username_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}