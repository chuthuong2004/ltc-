using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_DanhMay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            tblKey.Controls.Clear();
            int key = 32;
            for (int i = 0; i < tblKey.RowCount; i++)
            {
                for (int j = 0; j < tblKey.ColumnCount; j++)
                {
                    Label lblGhe = new Label();
                    lblGhe.Text = (char)key + "";
                    lblGhe.AutoSize = false;
                    lblGhe.Dock = DockStyle.Fill;
                    lblGhe.TextAlign = ContentAlignment.MiddleCenter;
                    lblGhe.Width = lblGhe.Height = 100;
                    lblGhe.BackColor = Color.Gray;
                    lblGhe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                    tblKey.Controls.Add(lblGhe, j, i);
                    key++;
                }
            }
        }

        private void txtNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Label lblGhe = sender as Label;
            //int key = 32;
            //for (int i = 0; i < tblKey.Controls.Count; i++)
            //{

            //    Label lbl = tblKey.Controls[i] as Label;
            //    Char ch = (char)key;
            //    if (e.KeyChar == ch)
            //    {
            //        lbl.BackColor = Color.Red;
            //    }
            //    else
            //    {
            //        lbl.BackColor = Color.Gray;
            //    }
            //    key++;
            //}
        }

        private void txtNhap_KeyUp(object sender, KeyEventArgs e)
        {
            Label lblGhe = sender as Label;
            int key = 32;
            for (int i = 0; i < tblKey.Controls.Count; i++)
            {

                Label lbl = tblKey.Controls[i] as Label;
                Char ch = (char)key;
                if (e.KeyValue == ch)
                {
                    lbl.BackColor = Color.Gray;
                }
                key++;
            }
        }

        private void txtNhap_KeyDown(object sender, KeyEventArgs e)
        {
            Label lblGhe = sender as Label;
            int key = 32;
            for (int i = 0; i < tblKey.Controls.Count; i++)
            {

                Label lbl = tblKey.Controls[i] as Label;
                Char ch = (char)key;
                if (e.KeyValue == ch)
                {
                    lbl.BackColor = Color.Red;
                }
                key++;
            }
        }
    }
}
