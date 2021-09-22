using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_ImageList
{
    public partial class frmBackgourndWorker : Form
    {
        public frmBackgourndWorker()
        {
            InitializeComponent();
        }
        Random random = new Random();
        int[] M;
        Button[] Mc;
        int GAP = 50;
        int height = 100;
        int size = 50;
        private void frmBackgourndWorker_Load(object sender, EventArgs e)
        {

        }

        private void btnVe_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtN.Text);
            M = new int[n];
            Mc = new Button[n];
            pnButton.Controls.Clear();
            for (int i = 0; i < n; i++)
            {
                Button btn = new Button();
                int value = random.Next(100);
                btn.Text = value + "";
                btn.Width = btn.Height = size;
                btn.Location = new Point(pnButton.Controls.Count * (btn.Width + GAP),
                    pnButton.Height / 2 - btn.Height);
                pnButton.Controls.Add(btn);
                M[i] = value;
                Mc[i]= btn;

            }
        }
        private void btnSapXep_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BubbleSort(M);
        }
        public void BubbleSort(int[] M)
        {
            Status st = new Status();
            for (int i = 0; i < M.Length -1; i++)
            {
                for (int j = M.Length - 1; j > i; j--)
                {
                    if (M[j] < M[j-1])
                    {
                        int temp = M[j];
                        M[j] = M[j - 1];
                        M[j - 1] = temp;
                        System.Threading.Thread.Sleep(10);
                        MoveButton(j, j - 1);
                    }
                }
            }
        }

        private void MoveButton(int pos1, int pos2)
        {
            Status st = new Status();
            st.Pos1 = pos1;
            st.Pos2 = pos2;
            st.type = MoveType.LINE_TO_TOP_AND_LINE_TO_BOTTOM;
            for (int x = 0; x < height; x++)
            {
                backgroundWorker1.ReportProgress(0, st);
                System.Threading.Thread.Sleep(10);
            }
            st.type = MoveType.LEFT_TO_RIGHT_AND_RIGHT_TO_LEFT;
            int WIDTH = Math.Abs(pos1 - pos2) * (size + GAP);
            for (int x = 0; x < WIDTH; x++)
            {
                backgroundWorker1.ReportProgress(0, st);
                System.Threading.Thread.Sleep(10);
            }
            st.type = MoveType.TOP_TO_LINE_AND_BOTTOM_TO_LINE;
            for (int i = 0; i < height; i++)
            {
                backgroundWorker1.ReportProgress(0, st);
                System.Threading.Thread.Sleep(10);
            }
            st.type = MoveType.CHANGED;
            backgroundWorker1.ReportProgress(0, st);
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            Status st = e.UserState as Status;
            if (st == null) return;
            if (st.type == MoveType.CHANGED)
            {
                //Button btn1 = Mc[st.Pos1];
                Button btnTemp = Mc[st.Pos2];
                Mc[st.Pos2] = Mc[st.Pos1];
                Mc[st.Pos1] = btnTemp;
                return;
            }
            Button btn1 = Mc[st.Pos1];
            Button btn2 = Mc[st.Pos2];
            if (st.type == MoveType.LINE_TO_TOP_AND_LINE_TO_BOTTOM)
            {
                btn1.Top += 1;
                btn2.Top -= 1;
            }
            else if (st.type == MoveType.LEFT_TO_RIGHT_AND_RIGHT_TO_LEFT)
            {
                btn1.Left -= 1;
                btn2.Left += 1;
            }
            else if (st.type == MoveType.TOP_TO_LINE_AND_BOTTOM_TO_LINE)
            {
                btn1.Top -= 1;
                btn2.Top += 1;
            }

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            foreach (Button button in pnButton.Controls)
            {
                button.BackColor = Color.Green;
                button.ForeColor = Color.Black;
            }
        }

        
    }
}
