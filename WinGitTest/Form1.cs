using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinGitTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.button1.Text = "버튼클릭";
            this.button1.Text = "버튼클릭2";
            this.button1.Text = "버튼클릭2";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Text = "버튼클릭";
        }
    }
}
