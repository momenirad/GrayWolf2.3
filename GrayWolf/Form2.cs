using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GrayWolf
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            DefaultManager di1 = new DefaultManager();
            di1.Dock = DockStyle.Fill;
            xtraScrollableControl1.Controls.Add(di1);
        }

        private void navBarItem1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            foreach (Control ctrl in xtraScrollableControl1.Controls)
            {
                ctrl.Dispose();
            }
            UserControl1 uc1 = new UserControl1();
            uc1.Dock = DockStyle.Fill;
            xtraScrollableControl1.Controls.Add(uc1);
        }

        private void navBarItem2_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            foreach (Control ctrl in xtraScrollableControl1.Controls)
            {
                ctrl.Dispose();
            }
            UserControl2 uc2 = new UserControl2();
            uc2.Dock = DockStyle.Fill;
            xtraScrollableControl1.Controls.Add(uc2);
        }

        private void navBarItem3_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            foreach (Control ctrl in xtraScrollableControl1.Controls)
            {
                ctrl.Dispose();
            }
            UserControl3_1 uc3 = new UserControl3_1();
            uc3.Dock = DockStyle.Fill;
            xtraScrollableControl1.Controls.Add(uc3);
        }

        private void navBarItem4_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            foreach (Control ctrl in xtraScrollableControl1.Controls)
            {
                ctrl.Dispose();
            }
            UserControl4 uc4 = new UserControl4();
            uc4.Dock = DockStyle.Fill;
            xtraScrollableControl1.Controls.Add(uc4);
        }

        private void navBarItem14_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            foreach (Control ctrl in xtraScrollableControl1.Controls)
            {
                ctrl.Dispose();
            }
            UserControl5 uc5 = new UserControl5();
            uc5.Dock = DockStyle.Fill;
            xtraScrollableControl1.Controls.Add(uc5);
        }

        private void navBarItem5_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            foreach (Control ctrl in xtraScrollableControl1.Controls)
            {
                ctrl.Dispose();
            }
            UserControl6 uc6 = new UserControl6();
            uc6.Dock = DockStyle.Fill;
            xtraScrollableControl1.Controls.Add(uc6);
        }

        private void navBarItem6_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            foreach (Control ctrl in xtraScrollableControl1.Controls)
            {
                ctrl.Dispose();
            }
            UserControl7 uc7 = new UserControl7();
            uc7.Dock = DockStyle.Fill;
            xtraScrollableControl1.Controls.Add(uc7);
        }

        private void navBarItem7_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            foreach (Control ctrl in xtraScrollableControl1.Controls)
            {
                ctrl.Dispose();
            }
            UserControl8 uc8 = new UserControl8();
            uc8.Dock = DockStyle.Fill;
            xtraScrollableControl1.Controls.Add(uc8);
        }

        private void navBarItem16_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            foreach (Control ctrl in xtraScrollableControl1.Controls)
            {
                ctrl.Dispose();
            }
            UserControl9 uc9 = new UserControl9();
            uc9.Dock = DockStyle.Fill;
            xtraScrollableControl1.Controls.Add(uc9);
        }

        private void navBarItem8_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            foreach (Control ctrl in xtraScrollableControl1.Controls)
            {
                ctrl.Dispose();
            }
            UserControl10 uc10 = new UserControl10();
            uc10.Dock = DockStyle.Fill;
            xtraScrollableControl1.Controls.Add(uc10);
        }

        private void navBarItem9_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            foreach (Control ctrl in xtraScrollableControl1.Controls)
            {
                ctrl.Dispose();
            }
            UserControl11 uc11 = new UserControl11();
            uc11.Dock = DockStyle.Fill;
            xtraScrollableControl1.Controls.Add(uc11);
        }

        private void navBarItem10_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            foreach (Control ctrl in xtraScrollableControl1.Controls)
            {
                ctrl.Dispose();
            }
            UserControl12 uc12 = new UserControl12();
            uc12.Dock = DockStyle.Fill;
            xtraScrollableControl1.Controls.Add(uc12);
        }
        private void navBarItem13_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            foreach (Control ctrl in xtraScrollableControl1.Controls)
            {
                ctrl.Dispose();
            }
            UserControl13 uc13 = new UserControl13();
            uc13.Dock = DockStyle.Fill;
            xtraScrollableControl1.Controls.Add(uc13);
        }

        private void navBarItem15_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            foreach (Control ctrl in xtraScrollableControl1.Controls)
            {
                ctrl.Dispose();
            }
            UserControl14 uc14 = new UserControl14();
            uc14.Dock = DockStyle.Fill;
            xtraScrollableControl1.Controls.Add(uc14);
        }

        private void navBarItem17_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            foreach (Control ctrl in xtraScrollableControl1.Controls)
            {
                ctrl.Dispose();
            }
            UserControl15 uc15 = new UserControl15();
            uc15.Dock = DockStyle.Fill;
            xtraScrollableControl1.Controls.Add(uc15);
        }

        private void navBarItem19_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            foreach (Control ctrl in xtraScrollableControl1.Controls)
            {
                ctrl.Dispose();
            }
            UserControl16 uc16 = new UserControl16();
            uc16.Dock = DockStyle.Fill;
            xtraScrollableControl1.Controls.Add(uc16);
        }

        private void navBarItem20_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            foreach (Control ctrl in xtraScrollableControl1.Controls)
            {
                ctrl.Dispose();
            }
            UserControl17 uc17 = new UserControl17();
            uc17.Dock = DockStyle.Fill;
            xtraScrollableControl1.Controls.Add(uc17);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            foreach (Control ctrl in xtraScrollableControl1.Controls)
            {
                ctrl.Dispose();
            }
            DefaultManager di1 = new DefaultManager();
            di1.Dock = DockStyle.Fill;
            xtraScrollableControl1.Controls.Add(di1);
        }
    }
}
