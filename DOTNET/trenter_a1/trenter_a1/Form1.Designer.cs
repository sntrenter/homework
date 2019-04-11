namespace trenter_a1
{
    partial class classes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(classes));
            this.aboutMe = new System.Windows.Forms.TextBox();
            this.selfPorterait = new System.Windows.Forms.PictureBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.classList = new System.Windows.Forms.TextBox();
            this.fallButton = new System.Windows.Forms.Button();
            this.springButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.selfPorterait)).BeginInit();
            this.SuspendLayout();
            // 
            // aboutMe
            // 
            this.aboutMe.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.aboutMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutMe.Location = new System.Drawing.Point(307, 48);
            this.aboutMe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.aboutMe.Multiline = true;
            this.aboutMe.Name = "aboutMe";
            this.aboutMe.Size = new System.Drawing.Size(245, 238);
            this.aboutMe.TabIndex = 0;
            // 
            // selfPorterait
            // 
            this.selfPorterait.Image = ((System.Drawing.Image)(resources.GetObject("selfPorterait.Image")));
            this.selfPorterait.ImageLocation = "";
            this.selfPorterait.Location = new System.Drawing.Point(16, 39);
            this.selfPorterait.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.selfPorterait.Name = "selfPorterait";
            this.selfPorterait.Size = new System.Drawing.Size(269, 247);
            this.selfPorterait.TabIndex = 1;
            this.selfPorterait.TabStop = false;
            this.selfPorterait.Click += new System.EventHandler(this.selfPorterait_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(431, 543);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(100, 28);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "EXIT";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // classList
            // 
            this.classList.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.classList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classList.Location = new System.Drawing.Point(39, 331);
            this.classList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.classList.Multiline = true;
            this.classList.Name = "classList";
            this.classList.Size = new System.Drawing.Size(491, 184);
            this.classList.TabIndex = 4;
            this.classList.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // fallButton
            // 
            this.fallButton.Location = new System.Drawing.Point(39, 543);
            this.fallButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fallButton.Name = "fallButton";
            this.fallButton.Size = new System.Drawing.Size(154, 28);
            this.fallButton.TabIndex = 5;
            this.fallButton.Text = "Show Fall Course";
            this.fallButton.UseVisualStyleBackColor = true;
            this.fallButton.Click += new System.EventHandler(this.fallButton_Click);
            // 
            // springButton
            // 
            this.springButton.Location = new System.Drawing.Point(231, 543);
            this.springButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.springButton.Name = "springButton";
            this.springButton.Size = new System.Drawing.Size(159, 28);
            this.springButton.TabIndex = 6;
            this.springButton.Text = "Show Spring Course";
            this.springButton.UseVisualStyleBackColor = true;
            this.springButton.Click += new System.EventHandler(this.springButton_Click);
            // 
            // classes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 639);
            this.Controls.Add(this.springButton);
            this.Controls.Add(this.fallButton);
            this.Controls.Add(this.classList);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.selfPorterait);
            this.Controls.Add(this.aboutMe);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "classes";
            this.Text = "Sam Trenter\'s Schedule";
            ((System.ComponentModel.ISupportInitialize)(this.selfPorterait)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox aboutMe;
        private System.Windows.Forms.PictureBox selfPorterait;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox classList;
        private System.Windows.Forms.Button fallButton;
        private System.Windows.Forms.Button springButton;
    }
}

