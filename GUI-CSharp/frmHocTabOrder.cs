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
    public partial class frmHocTabOrder : Form
    {
        public frmHocTabOrder()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void frmHocTabOrder_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn có chắc chắn muốn thoát",
               "Hỏi thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Xin Chào !","Message");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello", "Message", MessageBoxButtons.YesNo);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đây là nội dung", "Đây là tiêu đề"
                , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn có chắc chắn muốn xóa không ?",
                "Xác nhận xóa", MessageBoxButtons.YesNoCancel, 
                MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                this.Text = "Bạn chọn Yes";
            }
            else if (ret == DialogResult.No)
            {
                this.Text = "Bạn chọn No";
            }
            else if (ret == DialogResult.Cancel)
            {
                this.Text = "Bạn chọn Cancel";
            }
        }
    }
}
