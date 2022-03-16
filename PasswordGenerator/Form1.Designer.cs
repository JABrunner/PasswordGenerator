namespace PasswordGenerator
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
            this.PassLabel = new System.Windows.Forms.Label();
            this.PasswordLength = new System.Windows.Forms.Label();
            this.PasswordLengthSlider = new System.Windows.Forms.TrackBar();
            this.CopyPassButton = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordLengthSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PassLabel
            // 
            this.PassLabel.BackColor = System.Drawing.Color.Black;
            this.PassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassLabel.ForeColor = System.Drawing.Color.White;
            this.PassLabel.Location = new System.Drawing.Point(76, 50);
            this.PassLabel.Name = "PassLabel";
            this.PassLabel.Size = new System.Drawing.Size(609, 52);
            this.PassLabel.TabIndex = 0;
            this.PassLabel.Text = "label1";
            this.PassLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PasswordLength
            // 
            this.PasswordLength.BackColor = System.Drawing.Color.Black;
            this.PasswordLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLength.ForeColor = System.Drawing.Color.White;
            this.PasswordLength.Location = new System.Drawing.Point(76, 167);
            this.PasswordLength.Name = "PasswordLength";
            this.PasswordLength.Size = new System.Drawing.Size(609, 52);
            this.PasswordLength.TabIndex = 1;
            this.PasswordLength.Text = "Password Length: 5";
            this.PasswordLength.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PasswordLengthSlider
            // 
            this.PasswordLengthSlider.BackColor = System.Drawing.SystemColors.Desktop;
            this.PasswordLengthSlider.Location = new System.Drawing.Point(182, 234);
            this.PasswordLengthSlider.Name = "PasswordLengthSlider";
            this.PasswordLengthSlider.Size = new System.Drawing.Size(399, 56);
            this.PasswordLengthSlider.TabIndex = 2;
            this.PasswordLengthSlider.Scroll += new System.EventHandler(this.PasswordLengthSlider_Scroll);
            // 
            // CopyPassButton
            // 
            this.CopyPassButton.BackColor = System.Drawing.SystemColors.Window;
            this.CopyPassButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CopyPassButton.Location = new System.Drawing.Point(182, 296);
            this.CopyPassButton.Name = "CopyPassButton";
            this.CopyPassButton.Size = new System.Drawing.Size(399, 51);
            this.CopyPassButton.TabIndex = 3;
            this.CopyPassButton.Text = "Copy Password";
            this.CopyPassButton.UseVisualStyleBackColor = false;
            this.CopyPassButton.Click += new System.EventHandler(this.CopyPassButton_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(182, 354);
            this.progressBar1.Minimum = 1;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(399, 23);
            this.progressBar1.TabIndex = 4;
            this.progressBar1.Value = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(809, 458);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.CopyPassButton);
            this.Controls.Add(this.PasswordLengthSlider);
            this.Controls.Add(this.PasswordLength);
            this.Controls.Add(this.PassLabel);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Password Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PasswordLengthSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PassLabel;
        private System.Windows.Forms.Label PasswordLength;
        private System.Windows.Forms.TrackBar PasswordLengthSlider;
        private System.Windows.Forms.Button CopyPassButton;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

