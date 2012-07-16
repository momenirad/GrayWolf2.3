using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GrayWolf
{
    public partial class UserControl22 : UserControl
    {
        public UserControl22()
        {
            InitializeComponent();
        }

        private void navBarItem1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            foreach (Control ctrl1 in panelControl1.Controls)
            {
                ctrl1.Dispose();
            }
            UserControl23 uc23 = new UserControl23();
            uc23.Dock = DockStyle.Fill;
            panelControl1.Controls.Add(uc23);
        }

        private void navBarItem2_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            foreach (Control ctrl1 in panelControl1.Controls)
            {
                ctrl1.Dispose();
            }
            UserControl24 uc24 = new UserControl24();
            uc24.Dock = DockStyle.Fill;
            panelControl1.Controls.Add(uc24);
        }

        private void navBarItem3_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            foreach (Control ctrl1 in panelControl1.Controls)
            {
                ctrl1.Dispose();
            }
            UserControl25 uc25 = new UserControl25();
            uc25.Dock = DockStyle.Fill;
            panelControl1.Controls.Add(uc25);
        }

        private void navBarItem4_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            foreach (Control ctrl1 in panelControl1.Controls)
            {
                ctrl1.Dispose();
            }
            UserControl26 uc26 = new UserControl26();
            uc26.Dock = DockStyle.Fill;
            panelControl1.Controls.Add(uc26);
        }

        private void navBarItem5_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            foreach (Control ctrl1 in panelControl1.Controls)
            {
                ctrl1.Dispose();
            }
            UserControl27 uc27 = new UserControl27();
            uc27.Dock = DockStyle.Fill;
            panelControl1.Controls.Add(uc27);
        }

        private void navBarItem6_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            foreach (Control ctrl1 in panelControl1.Controls)
            {
                ctrl1.Dispose();
            }
            UserControl28 uc28 = new UserControl28();
            uc28.Dock = DockStyle.Fill;
            panelControl1.Controls.Add(uc28);
        }
    }
}
