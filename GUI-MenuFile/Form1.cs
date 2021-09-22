using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_MenuFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mnuFileExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mnuFileNewProject_Click(object sender, EventArgs e)
        {
            frmNewProject frm = new frmNewProject();
            frm.ShowDialog();
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Button btn = contextMenuStrip1.SourceControl as Button;
            btn.BackColor = Color.Red;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Button btn = contextMenuStrip1.SourceControl as Button;
            btn.BackColor = Color.Green;
        }

        private void yelowwToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Button btn = contextMenuStrip1.SourceControl as Button;
            btn.BackColor = Color.Yellow;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                Button btn = new Button();
                btn.Text = random.Next(100) + "";
                btn.Height = 50;
                btn.Width = 100;
                flowLayoutPanel1.Controls.Add(btn);
                btn.ContextMenuStrip = contextMenuStrip1;
            }
        }
    }
}
