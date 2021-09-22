using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_TabControls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                button1.BackColor= Color.Red;
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                label2.ForeColor = Color.Red;
                radioButton1.Checked = true;
                textBox2.Text = "Tao là chu thương nè";
            }
        }
    }
}
