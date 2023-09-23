using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //label1.Text = "First Name"; // possible to do this, but better to edit them in the designer
            //label2.Text = "Last Name";
            //label3.Text = "Full Name";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show($"Hello {textBox1.Text} {textBox2.Text}");

            //textBox3.Text = $"Hello {textBox1.Text} {textBox2.Text}";

            //if (progressBar1.Value < 100) 
            //{
            //    progressBar1.Value += 10;
            //}

            //Form1 frm = new Form1();
            //frm.Show(); // opening up another separate window instance 

            //toolStripStatusLabel1.Text = "Working...";
            //if (toolStripProgressBar1.Value < 100)
            //{
            //    toolStripProgressBar1.Value += 10;
            //}
        }
    }
}
