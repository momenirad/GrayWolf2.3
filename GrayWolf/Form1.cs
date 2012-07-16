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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = textBox1.Text;
            string pass = textBox2.Text;
            if (user == "kamyar")
                if (pass == "kamyar")
                {
                    var regionReq = new Form2();
                    regionReq.ShowDialog();
                    //MessageBox.Show("kamyar signed in");
                }
                else
                {
                    MessageBox.Show("کلمه عبور با شناسه مطابقت ندارد");
                }
            if(user=="momeni")
                if (pass == "rad")
                {
                    var regionReq = new Form3();
                    regionReq.ShowDialog();
                    
                }
                else
                {
                    MessageBox.Show("کلمه عبور با شناسه مطابقت ندارد");
                }
            
        }

        
    }
}
