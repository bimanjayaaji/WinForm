using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsStartup
{
    public partial class Form1 : Form
    {
        private string _form2Label;

        public Form1(string form2Label)
        {
            InitializeComponent();
            this._form2Label = form2Label;
            label1.Text = _form2Label;
        }
    }
}
