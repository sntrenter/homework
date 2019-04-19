namespace trenter_a3
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Num1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Num2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.EquationTB = new System.Windows.Forms.TextBox();
            this.UsernameTB = new System.Windows.Forms.TextBox();
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // Num1
            // 
            this.Num1.AutoSize = true;
            this.Num1.Location = new System.Drawing.Point(123, 251);
            this.Num1.Name = "Num1";
            this.Num1.Size = new System.Drawing.Size(20, 17);
            this.Num1.TabIndex = 2;
            this.Num1.Text = "   ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(229, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "+";
            // 
            // Num2
            // 
            this.Num2.AutoSize = true;
            this.Num2.Location = new System.Drawing.Point(307, 251);
            this.Num2.Name = "Num2";
            this.Num2.Size = new System.Drawing.Size(20, 17);
            this.Num2.TabIndex = 4;
            this.Num2.Text = "   ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(394, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "=";
            // 
            // EquationTB
            // 
            this.EquationTB.Location = new System.Drawing.Point(527, 251);
            this.EquationTB.Name = "EquationTB";
            this.EquationTB.Size = new System.Drawing.Size(100, 22);
            this.EquationTB.TabIndex = 6;
            // 
            // UsernameTB
            // 
            this.UsernameTB.Location = new System.Drawing.Point(277, 89);
            this.UsernameTB.Name = "UsernameTB";
            this.UsernameTB.Size = new System.Drawing.Size(100, 22);
            this.UsernameTB.TabIndex = 7;
            // 
            // PasswordTB
            // 
            this.PasswordTB.Location = new System.Drawing.Point(277, 174);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.PasswordChar = '*';
            this.PasswordTB.Size = new System.Drawing.Size(100, 22);
            this.PasswordTB.TabIndex = 8;
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(310, 339);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(75, 23);
            this.Login.TabIndex = 9;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.PasswordTB);
            this.Controls.Add(this.UsernameTB);
            this.Controls.Add(this.EquationTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Num2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Num1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "User Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Num1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Num2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox EquationTB;
        private System.Windows.Forms.TextBox UsernameTB;
        private System.Windows.Forms.TextBox PasswordTB;
        private System.Windows.Forms.Button Login;
    }
}

