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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Button[,] arrButton = null;
        Random random = new Random();
        Button lasted = null;
        private void btnVe_Click(object sender, EventArgs e)
        {
            int dong = int.Parse(txtDong.Text);
            int cot = int.Parse(txtCot.Text);
            arrButton = new Button[dong, cot];
            pnButton.Controls.Clear();
            for (int i = 0; i < arrButton.GetLength(0); i++)
            {
                for (int j = 0; j < arrButton.GetLength(1); j++)
                {
                    Button btn = new Button();
                    btn.Text = random.Next(100) + "";
                    btn.Width = btn.Height = 50;
                    btn.Location = new Point(j * btn.Width, i * btn.Height);
                    pnButton.Controls.Add(btn);
                    arrButton[i, j] = btn;
                    btn.BackColor = Color.WhiteSmoke;
                    btn.Click += Btn_Click;
                    btn.Tag = i + ";" + j;
                }
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            if (lasted!=null)
            {
                DoiMau(lasted, Color.WhiteSmoke);
                lasted.ForeColor = Color.Black;
            }
            Button btn = sender as Button;
            lasted = btn;
            DoiMau(lasted, Color.Orange);
            lasted.BackColor = Color.Red;
            lasted.ForeColor = Color.Blue;
        }

        private void DoiMau(Button lasted, Color color)
        {
            string s = lasted.Tag.ToString();
            string[] arr = s.Split(';');
            int i = int.Parse(arr[0]);
            int j = int.Parse(arr[1]);   
            for (int c = 0; c < arrButton.GetLength(1); c++)
            {
                arrButton[i, c].BackColor = color;
            }
            for (int d = 0; d < arrButton.GetLength(0); d++)
            {
                arrButton[d, j].BackColor = color;
            }

        }
    }
}
