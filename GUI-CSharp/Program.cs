using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_CSharp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //frmSignIn frm = new frmSignIn();
            //if (frm.ShowDialog() == DialogResult.OK)
            //{
            //    Application.Run(new frmPicture());
            //}
            Application.Run(new frmComboBox());


        }
    }
}
