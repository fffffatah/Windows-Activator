using System;
using System.Windows.Forms;

namespace Windows_Activator
{
    public partial class Landing : Form
    {
        private string[] winCommand = new string[] { "windows", "office" };
        private int switchAct = 0;
        public Landing()
        {
            InitializeComponent();
        }
        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void activate_Click(object sender, EventArgs e)
        {
            loadingAnimation.Visible=true;
            if (new ActivationStuff().ActivateMe(winCommand[switchAct]).Equals("success"))
            {
                loadingAnimation.Visible = false;
                successLabel.Visible = true;
            }
            else
            {
                loadingAnimation.Visible = false;
                failedLabel.Visible = true;
            }
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            new About(this).Show();
        }

        private void switchButton_Click(object sender, EventArgs e)
        {
            if(switchAct==0)
            {
                switchAct = 1;
                windowsLogo.Visible = false;
                winLogoSmall.Visible = true;
                officeLogo.Visible = true;
                officeLogoSmall.Visible = false;
            }
            else
            {
                switchAct = 0;
                windowsLogo.Visible = true;
                winLogoSmall.Visible = false;
                officeLogo.Visible = false;
                officeLogoSmall.Visible = true;
            }
        }

        private void officeLogoSmall_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void winLogoSmall_Paint(object sender, PaintEventArgs e)
        {

        }


        private void windowsLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void officeLogo_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
