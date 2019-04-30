namespace trenter_a4
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
            this.mealCostTB = new System.Windows.Forms.TextBox();
            this.partySizeGB = new System.Windows.Forms.GroupBox();
            this.moreThan6 = new System.Windows.Forms.RadioButton();
            this.lessThan6 = new System.Windows.Forms.RadioButton();
            this.additionalDiscountGB = new System.Windows.Forms.GroupBox();
            this.senior = new System.Windows.Forms.CheckBox();
            this.student = new System.Windows.Forms.CheckBox();
            this.military = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tipListBox = new System.Windows.Forms.ListBox();
            this.partySizeGB.SuspendLayout();
            this.additionalDiscountGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Meal Cost";
            // 
            // mealCostTB
            // 
            this.mealCostTB.Location = new System.Drawing.Point(282, 27);
            this.mealCostTB.Name = "mealCostTB";
            this.mealCostTB.Size = new System.Drawing.Size(100, 22);
            this.mealCostTB.TabIndex = 1;
            // 
            // partySizeGB
            // 
            this.partySizeGB.Controls.Add(this.moreThan6);
            this.partySizeGB.Controls.Add(this.lessThan6);
            this.partySizeGB.Location = new System.Drawing.Point(63, 90);
            this.partySizeGB.Name = "partySizeGB";
            this.partySizeGB.Size = new System.Drawing.Size(234, 154);
            this.partySizeGB.TabIndex = 3;
            this.partySizeGB.TabStop = false;
            this.partySizeGB.Text = "Party Size";
            // 
            // moreThan6
            // 
            this.moreThan6.AutoSize = true;
            this.moreThan6.Location = new System.Drawing.Point(65, 97);
            this.moreThan6.Name = "moreThan6";
            this.moreThan6.Size = new System.Drawing.Size(105, 21);
            this.moreThan6.TabIndex = 1;
            this.moreThan6.TabStop = true;
            this.moreThan6.Text = "More than 6";
            this.moreThan6.UseVisualStyleBackColor = true;
            this.moreThan6.Click += new System.EventHandler(this.MoreThan6_Click);
            // 
            // lessThan6
            // 
            this.lessThan6.AutoSize = true;
            this.lessThan6.Location = new System.Drawing.Point(67, 36);
            this.lessThan6.Name = "lessThan6";
            this.lessThan6.Size = new System.Drawing.Size(103, 21);
            this.lessThan6.TabIndex = 0;
            this.lessThan6.TabStop = true;
            this.lessThan6.Text = "Less than 6";
            this.lessThan6.UseVisualStyleBackColor = true;
            this.lessThan6.Click += new System.EventHandler(this.LessThan6_Click);
            // 
            // additionalDiscountGB
            // 
            this.additionalDiscountGB.Controls.Add(this.senior);
            this.additionalDiscountGB.Controls.Add(this.student);
            this.additionalDiscountGB.Controls.Add(this.military);
            this.additionalDiscountGB.Location = new System.Drawing.Point(340, 90);
            this.additionalDiscountGB.Name = "additionalDiscountGB";
            this.additionalDiscountGB.Size = new System.Drawing.Size(235, 154);
            this.additionalDiscountGB.TabIndex = 4;
            this.additionalDiscountGB.TabStop = false;
            this.additionalDiscountGB.Text = "Additional Discount";
            // 
            // senior
            // 
            this.senior.AutoSize = true;
            this.senior.Location = new System.Drawing.Point(63, 113);
            this.senior.Name = "senior";
            this.senior.Size = new System.Drawing.Size(117, 21);
            this.senior.TabIndex = 4;
            this.senior.Text = "Senior Citizen";
            this.senior.UseVisualStyleBackColor = true;
            // 
            // student
            // 
            this.student.AutoSize = true;
            this.student.Location = new System.Drawing.Point(63, 75);
            this.student.Name = "student";
            this.student.Size = new System.Drawing.Size(79, 21);
            this.student.TabIndex = 3;
            this.student.Text = "Student";
            this.student.UseVisualStyleBackColor = true;
            // 
            // military
            // 
            this.military.AutoSize = true;
            this.military.Location = new System.Drawing.Point(63, 36);
            this.military.Name = "military";
            this.military.Size = new System.Drawing.Size(128, 21);
            this.military.TabIndex = 2;
            this.military.Text = "Military/Veteran";
            this.military.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(233, 411);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 48);
            this.button1.TabIndex = 5;
            this.button1.Text = "Calculate Total";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // tipListBox
            // 
            this.tipListBox.FormattingEnabled = true;
            this.tipListBox.ItemHeight = 16;
            this.tipListBox.Location = new System.Drawing.Point(177, 250);
            this.tipListBox.Name = "tipListBox";
            this.tipListBox.Size = new System.Drawing.Size(268, 132);
            this.tipListBox.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 471);
            this.Controls.Add(this.tipListBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.additionalDiscountGB);
            this.Controls.Add(this.partySizeGB);
            this.Controls.Add(this.mealCostTB);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Meal Cost Calculator";
            this.partySizeGB.ResumeLayout(false);
            this.partySizeGB.PerformLayout();
            this.additionalDiscountGB.ResumeLayout(false);
            this.additionalDiscountGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox mealCostTB;
        private System.Windows.Forms.GroupBox partySizeGB;
        private System.Windows.Forms.RadioButton moreThan6;
        private System.Windows.Forms.RadioButton lessThan6;
        private System.Windows.Forms.GroupBox additionalDiscountGB;
        private System.Windows.Forms.CheckBox senior;
        private System.Windows.Forms.CheckBox student;
        private System.Windows.Forms.CheckBox military;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox tipListBox;
    }
}

