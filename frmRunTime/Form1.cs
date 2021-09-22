using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmRunTime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Button lasted = null;
        private void btnThem_Click(object sender, EventArgs e)
        {
            Button btn = new Button();
            Random random = new Random();
            btn.Text = random.Next(102) + "";
            btn.Width = 100;
            btn.Height = 30;
            btn.BackColor = Color.Orange;
            pnButton.Controls.Add(btn);
            btn.Click += Btn_Click;
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            if( lasted != null)
            {
                lasted.BackColor = Color.Orange;
            }
            Button btn = sender as Button;
            btn.BackColor = Color.Red;
            lasted = btn;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lasted != null)
            {
                pnButton.Controls.Remove(lasted);
            }
        }
    }
}
