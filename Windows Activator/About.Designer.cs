namespace Windows_Activator
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.continueAbout = new System.Windows.Forms.Button();
            this.profileImage = new System.Windows.Forms.Panel();
            this.aboutLabel = new System.Windows.Forms.Label();
            this.githubProfileLink = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // continueAbout
            // 
            this.continueAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.continueAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.continueAbout.FlatAppearance.BorderSize = 0;
            this.continueAbout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.continueAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.continueAbout.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.continueAbout.Location = new System.Drawing.Point(151, 196);
            this.continueAbout.Name = "continueAbout";
            this.continueAbout.Size = new System.Drawing.Size(106, 40);
            this.continueAbout.TabIndex = 0;
            this.continueAbout.Text = "Close";
            this.continueAbout.UseVisualStyleBackColor = false;
            this.continueAbout.Click += new System.EventHandler(this.continueAbout_Click);
            // 
            // profileImage
            // 
            this.profileImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("profileImage.BackgroundImage")));
            this.profileImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.profileImage.Location = new System.Drawing.Point(25, 46);
            this.profileImage.Name = "profileImage";
            this.profileImage.Size = new System.Drawing.Size(103, 100);
            this.profileImage.TabIndex = 1;
            // 
            // aboutLabel
            // 
            this.aboutLabel.AutoSize = true;
            this.aboutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutLabel.ForeColor = System.Drawing.Color.Aqua;
            this.aboutLabel.Location = new System.Drawing.Point(181, 46);
            this.aboutLabel.Name = "aboutLabel";
            this.aboutLabel.Size = new System.Drawing.Size(153, 20);
            this.aboutLabel.TabIndex = 2;
            this.aboutLabel.Text = "Created by Fatah";
            // 
            // githubProfileLink
            // 
            this.githubProfileLink.AutoSize = true;
            this.githubProfileLink.LinkColor = System.Drawing.Color.Aqua;
            this.githubProfileLink.Location = new System.Drawing.Point(182, 77);
            this.githubProfileLink.Name = "githubProfileLink";
            this.githubProfileLink.Size = new System.Drawing.Size(172, 17);
            this.githubProfileLink.TabIndex = 3;
            this.githubProfileLink.TabStop = true;
            this.githubProfileLink.Text = "https://github.com/fffffatah";
            this.githubProfileLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(415, 262);
            this.Controls.Add(this.githubProfileLink);
            this.Controls.Add(this.aboutLabel);
            this.Controls.Add(this.profileImage);
            this.Controls.Add(this.continueAbout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "About";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button continueAbout;
        private System.Windows.Forms.Panel profileImage;
        private System.Windows.Forms.Label aboutLabel;
        private System.Windows.Forms.LinkLabel githubProfileLink;
    }
}