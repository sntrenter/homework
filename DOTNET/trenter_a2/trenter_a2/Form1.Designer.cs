namespace trenter_a2
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
            this.weightTB = new System.Windows.Forms.TextBox();
            this.heightFeetTB = new System.Windows.Forms.TextBox();
            this.heightInchesTB = new System.Windows.Forms.TextBox();
            this.weightLabel = new System.Windows.Forms.Label();
            this.lbsLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.ftLabel = new System.Windows.Forms.Label();
            this.inLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.calculatedBMI = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // weightTB
            // 
            this.weightTB.Location = new System.Drawing.Point(101, 93);
            this.weightTB.Name = "weightTB";
            this.weightTB.Size = new System.Drawing.Size(100, 22);
            this.weightTB.TabIndex = 0;
            // 
            // heightFeetTB
            // 
            this.heightFeetTB.Location = new System.Drawing.Point(101, 185);
            this.heightFeetTB.Name = "heightFeetTB";
            this.heightFeetTB.Size = new System.Drawing.Size(100, 22);
            this.heightFeetTB.TabIndex = 1;
            // 
            // heightInchesTB
            // 
            this.heightInchesTB.Location = new System.Drawing.Point(267, 185);
            this.heightInchesTB.Name = "heightInchesTB";
            this.heightInchesTB.Size = new System.Drawing.Size(100, 22);
            this.heightInchesTB.TabIndex = 2;
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Location = new System.Drawing.Point(30, 96);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(52, 17);
            this.weightLabel.TabIndex = 3;
            this.weightLabel.Text = "Weight";
            // 
            // lbsLabel
            // 
            this.lbsLabel.AutoSize = true;
            this.lbsLabel.Location = new System.Drawing.Point(233, 96);
            this.lbsLabel.Name = "lbsLabel";
            this.lbsLabel.Size = new System.Drawing.Size(30, 17);
            this.lbsLabel.TabIndex = 4;
            this.lbsLabel.Text = "lbs.";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(33, 185);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(49, 17);
            this.heightLabel.TabIndex = 5;
            this.heightLabel.Text = "Height";
            // 
            // ftLabel
            // 
            this.ftLabel.AutoSize = true;
            this.ftLabel.Location = new System.Drawing.Point(225, 189);
            this.ftLabel.Name = "ftLabel";
            this.ftLabel.Size = new System.Drawing.Size(20, 17);
            this.ftLabel.TabIndex = 6;
            this.ftLabel.Text = "ft.";
            // 
            // inLabel
            // 
            this.inLabel.AutoSize = true;
            this.inLabel.Location = new System.Drawing.Point(394, 189);
            this.inLabel.Name = "inLabel";
            this.inLabel.Size = new System.Drawing.Size(23, 17);
            this.inLabel.TabIndex = 7;
            this.inLabel.Text = "in.";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(162, 285);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Calculate BMI";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // calculatedBMI
            // 
            this.calculatedBMI.AutoSize = true;
            this.calculatedBMI.Location = new System.Drawing.Point(203, 342);
            this.calculatedBMI.Name = "calculatedBMI";
            this.calculatedBMI.Size = new System.Drawing.Size(0, 17);
            this.calculatedBMI.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 409);
            this.Controls.Add(this.calculatedBMI);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.inLabel);
            this.Controls.Add(this.ftLabel);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.lbsLabel);
            this.Controls.Add(this.weightLabel);
            this.Controls.Add(this.heightInchesTB);
            this.Controls.Add(this.heightFeetTB);
            this.Controls.Add(this.weightTB);
            this.Name = "Form1";
            this.Text = "BMI Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox weightTB;
        private System.Windows.Forms.TextBox heightFeetTB;
        private System.Windows.Forms.TextBox heightInchesTB;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.Label lbsLabel;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Label ftLabel;
        private System.Windows.Forms.Label inLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label calculatedBMI;
    }
}

