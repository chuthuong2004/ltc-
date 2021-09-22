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
    public partial class frmPicture : Form
    {
        public frmPicture()
        {
            InitializeComponent();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (picOn.Visible == true)
            {
                btnTurnOnOff.Text = txtName.Text + ". Turn on the light, please !";
            }
            else
            {
                btnTurnOnOff.Text = txtName.Text + ". Turn off the light, please !";
            }

        }

        private void btnTurnOnOff_Click(object sender, EventArgs e)
        {
            if (picOn.Visible == false)
            {
                picOn.Visible = true;
                picOff.Visible = false;
                btnTurnOnOff.Text = btnTurnOnOff.Text.Replace("on", "off");
            }
            else
            {
                picOn.Visible = false;
                picOff.Visible = true;
                btnTurnOnOff.Text = btnTurnOnOff.Text.Replace("off", "on");

            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
