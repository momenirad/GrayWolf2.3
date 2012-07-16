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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in panelControl1.Controls)
            {
                ctrl.Dispose();
            }
            this.label2.Dispose();
            UserControl22 uc22 = new UserControl22();
            uc22.Dock = DockStyle.Fill;
            panelControl1.Controls.Add(uc22);
        }
    }
}
