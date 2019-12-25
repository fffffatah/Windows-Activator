namespace Windows_Activator
{
    partial class Landing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Landing));
            this.exit = new System.Windows.Forms.Button();
            this.minimize = new System.Windows.Forms.Button();
            this.windowsLogo = new System.Windows.Forms.Panel();
            this.activate = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.formIcon = new System.Windows.Forms.Panel();
            this.aboutButton = new System.Windows.Forms.Button();
            this.loadingAnimation = new System.Windows.Forms.PictureBox();
            this.successLabel = new System.Windows.Forms.PictureBox();
            this.failedLabel = new System.Windows.Forms.PictureBox();
            this.switchButton = new System.Windows.Forms.Button();
            this.winLogoSmall = new System.Windows.Forms.Panel();
            this.officeLogoSmall = new System.Windows.Forms.Panel();
            this.officeLogo = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.loadingAnimation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.successLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.failedLabel)).BeginInit();
            this.SuspendLayout();
            // 
            // exit
            // 
            this.exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.exit.Location = new System.Drawing.Point(780, 2);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(48, 26);
            this.exit.TabIndex = 0;
            this.exit.Text = "X";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // minimize
            // 
            this.minimize.FlatAppearance.BorderSize = 0;
            this.minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimize.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.minimize.Location = new System.Drawing.Point(717, 2);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(57, 26);
            this.minimize.TabIndex = 1;
            this.minimize.Text = "--";
            this.minimize.UseVisualStyleBackColor = true;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // windowsLogo
            // 
            this.windowsLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("windowsLogo.BackgroundImage")));
            this.windowsLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.windowsLogo.Location = new System.Drawing.Point(162, 175);
            this.windowsLogo.Name = "windowsLogo";
            this.windowsLogo.Size = new System.Drawing.Size(201, 160);
            this.windowsLogo.TabIndex = 2;
            this.windowsLogo.Paint += new System.Windows.Forms.PaintEventHandler(this.windowsLogo_Paint);
            // 
            // activate
            // 
            this.activate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.activate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.activate.FlatAppearance.BorderSize = 0;
            this.activate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.activate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activate.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.activate.Location = new System.Drawing.Point(327, 424);
            this.activate.Name = "activate";
            this.activate.Size = new System.Drawing.Size(191, 78);
            this.activate.TabIndex = 3;
            this.activate.Text = "Activate";
            this.activate.UseVisualStyleBackColor = false;
            this.activate.Click += new System.EventHandler(this.activate_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.title.Location = new System.Drawing.Point(41, 12);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(148, 20);
            this.title.TabIndex = 4;
            this.title.Text = "Windows Activator";
            // 
            // formIcon
            // 
            this.formIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("formIcon.BackgroundImage")));
            this.formIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.formIcon.Location = new System.Drawing.Point(12, 12);
            this.formIcon.Name = "formIcon";
            this.formIcon.Size = new System.Drawing.Size(23, 20);
            this.formIcon.TabIndex = 5;
            // 
            // aboutButton
            // 
            this.aboutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.aboutButton.FlatAppearance.BorderSize = 0;
            this.aboutButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.aboutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aboutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutButton.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.aboutButton.Location = new System.Drawing.Point(776, 518);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(52, 41);
            this.aboutButton.TabIndex = 6;
            this.aboutButton.Text = "?";
            this.aboutButton.UseVisualStyleBackColor = true;
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // loadingAnimation
            // 
            this.loadingAnimation.Image = ((System.Drawing.Image)(resources.GetObject("loadingAnimation.Image")));
            this.loadingAnimation.Location = new System.Drawing.Point(543, 175);
            this.loadingAnimation.Name = "loadingAnimation";
            this.loadingAnimation.Size = new System.Drawing.Size(191, 167);
            this.loadingAnimation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.loadingAnimation.TabIndex = 7;
            this.loadingAnimation.TabStop = false;
            this.loadingAnimation.Visible = false;
            // 
            // successLabel
            // 
            this.successLabel.Image = ((System.Drawing.Image)(resources.GetObject("successLabel.Image")));
            this.successLabel.Location = new System.Drawing.Point(543, 175);
            this.successLabel.Name = "successLabel";
            this.successLabel.Size = new System.Drawing.Size(191, 167);
            this.successLabel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.successLabel.TabIndex = 8;
            this.successLabel.TabStop = false;
            this.successLabel.Visible = false;
            // 
            // failedLabel
            // 
            this.failedLabel.Image = ((System.Drawing.Image)(resources.GetObject("failedLabel.Image")));
            this.failedLabel.Location = new System.Drawing.Point(543, 175);
            this.failedLabel.Name = "failedLabel";
            this.failedLabel.Size = new System.Drawing.Size(191, 167);
            this.failedLabel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.failedLabel.TabIndex = 9;
            this.failedLabel.TabStop = false;
            this.failedLabel.Visible = false;
            // 
            // switchButton
            // 
            this.switchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.switchButton.FlatAppearance.BorderSize = 0;
            this.switchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.switchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.switchButton.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.switchButton.Location = new System.Drawing.Point(111, 246);
            this.switchButton.Name = "switchButton";
            this.switchButton.Size = new System.Drawing.Size(45, 27);
            this.switchButton.TabIndex = 10;
            this.switchButton.Text = "< >";
            this.switchButton.UseVisualStyleBackColor = true;
            this.switchButton.Click += new System.EventHandler(this.switchButton_Click);
            // 
            // winLogoSmall
            // 
            this.winLogoSmall.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("winLogoSmall.BackgroundImage")));
            this.winLogoSmall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.winLogoSmall.Location = new System.Drawing.Point(29, 226);
            this.winLogoSmall.Name = "winLogoSmall";
            this.winLogoSmall.Size = new System.Drawing.Size(76, 65);
            this.winLogoSmall.TabIndex = 11;
            this.winLogoSmall.Visible = false;
            this.winLogoSmall.Paint += new System.Windows.Forms.PaintEventHandler(this.winLogoSmall_Paint);
            // 
            // officeLogoSmall
            // 
            this.officeLogoSmall.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("officeLogoSmall.BackgroundImage")));
            this.officeLogoSmall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.officeLogoSmall.Location = new System.Drawing.Point(32, 223);
            this.officeLogoSmall.Name = "officeLogoSmall";
            this.officeLogoSmall.Size = new System.Drawing.Size(76, 65);
            this.officeLogoSmall.TabIndex = 0;
            this.officeLogoSmall.Paint += new System.Windows.Forms.PaintEventHandler(this.officeLogoSmall_Paint);
            // 
            // officeLogo
            // 
            this.officeLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("officeLogo.BackgroundImage")));
            this.officeLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.officeLogo.Location = new System.Drawing.Point(162, 175);
            this.officeLogo.Name = "officeLogo";
            this.officeLogo.Size = new System.Drawing.Size(200, 160);
            this.officeLogo.TabIndex = 12;
            this.officeLogo.Visible = false;
            this.officeLogo.Paint += new System.Windows.Forms.PaintEventHandler(this.officeLogo_Paint_1);
            // 
            // Landing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(829, 561);
            this.Controls.Add(this.officeLogo);
            this.Controls.Add(this.officeLogoSmall);
            this.Controls.Add(this.winLogoSmall);
            this.Controls.Add(this.switchButton);
            this.Controls.Add(this.failedLabel);
            this.Controls.Add(this.successLabel);
            this.Controls.Add(this.loadingAnimation);
            this.Controls.Add(this.aboutButton);
            this.Controls.Add(this.formIcon);
            this.Controls.Add(this.title);
            this.Controls.Add(this.activate);
            this.Controls.Add(this.windowsLogo);
            this.Controls.Add(this.minimize);
            this.Controls.Add(this.exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Landing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.loadingAnimation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.successLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.failedLabel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button minimize;
        private System.Windows.Forms.Panel windowsLogo;
        private System.Windows.Forms.Button activate;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Panel formIcon;
        private System.Windows.Forms.Button aboutButton;
        private System.Windows.Forms.PictureBox loadingAnimation;
        private System.Windows.Forms.PictureBox successLabel;
        private System.Windows.Forms.PictureBox failedLabel;
        private System.Windows.Forms.Button switchButton;
        private System.Windows.Forms.Panel winLogoSmall;
        private System.Windows.Forms.Panel officeLogoSmall;
        private System.Windows.Forms.Panel officeLogo;
    }
}

