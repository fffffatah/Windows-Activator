using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Activator
{
    public partial class About : Form
    {
        Landing mainLand;
        public About(Landing landObj)
        {
            mainLand = landObj;
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

        
        private void continueAbout_Click(object sender, EventArgs e)
        {
            mainLand.Enabled = true;
            this.Close();      
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(githubProfileLink.Text);
        }
    }
}
