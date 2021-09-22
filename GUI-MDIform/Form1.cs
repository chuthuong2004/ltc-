using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_MDIform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mởBàiTập1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBai1 frm = new frmBai1();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mởBàiTập2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmbai2 frm = new frmbai2();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mởBàiTập3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBai3 frm = new frmBai3();
            frm.MdiParent = this;
            frm.Show();
        }

        private void arrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }
    }
}
