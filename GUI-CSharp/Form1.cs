using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_CSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            if(this.BackColor == Color.Orange)
            {
                this.BackColor = Color.Blue;
            }
            else
            {
                this.BackColor = Color.Orange;
            }
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            if (this.BackColor == Color.Orange)
            {
                this.BackColor = Color.Violet;
            }
            else
            {
                this.BackColor = Color.Green;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Bạn chọn đóng cửa sổ");
        }
    }
}
