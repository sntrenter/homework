namespace trenter_a1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.aboutMe = new System.Windows.Forms.TextBox();
            this.selfPorterait = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.selfPorterait)).BeginInit();
            this.SuspendLayout();
            // 
            // aboutMe
            // 
            this.aboutMe.Location = new System.Drawing.Point(230, 39);
            this.aboutMe.Multiline = true;
            this.aboutMe.Name = "aboutMe";
            this.aboutMe.Size = new System.Drawing.Size(185, 194);
            this.aboutMe.TabIndex = 0;
            this.aboutMe.Text = resources.GetString("aboutMe.Text");
            // 
            // selfPorterait
            // 
            this.selfPorterait.Image = ((System.Drawing.Image)(resources.GetObject("selfPorterait.Image")));
            this.selfPorterait.ImageLocation = "strenter.jpg";
            this.selfPorterait.Location = new System.Drawing.Point(12, 32);
            this.selfPorterait.Name = "selfPorterait";
            this.selfPorterait.Size = new System.Drawing.Size(202, 201);
            this.selfPorterait.TabIndex = 1;
            this.selfPorterait.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 452);
            this.Controls.Add(this.selfPorterait);
            this.Controls.Add(this.aboutMe);
            this.Name = "Form1";
            this.Text = "Sam Trenter\'s Schedule";
            ((System.ComponentModel.ISupportInitialize)(this.selfPorterait)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox aboutMe;
        private System.Windows.Forms.PictureBox selfPorterait;
    }
}

