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
    public partial class UserControl3_1 : UserControl
    {
        public UserControl3_1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Insert(0, "محمد درخشانی");
            
            listBox1.Items.Insert(1, "محمد رضائیان");
            listBox1.Items.Insert(2, "محمد محرابیان");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl1 in panelControl1.Controls)
            {
                ctrl1.Dispose();
            }
            UserControl3_2 uc3_2 = new UserControl3_2();
            uc3_2.Dock = DockStyle.Fill;
            panelControl1.Controls.Remove(textBox1);
            panelControl1.Controls.Remove(listBox1);
            panelControl1.Controls.Remove(button2);
            panelControl1.Controls.Remove(label3);
            
            panelControl1.Controls.Add(uc3_2);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        
    }
}
