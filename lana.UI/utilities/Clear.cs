using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lana.UI.utilities
{
    public static class Clear
    {
        public static void ClearControl(Control ctrl)
        {
            foreach (Control c in ctrl.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = string.Empty;
                }
                else if (c is MaskedTextBox)
                {
                    ((MaskedTextBox)c).Text = string.Empty;
                }
                else if (c is PictureBox)
                {
                    ((PictureBox)c).Image = null;
                }
                else
                {
                    ClearControl(c);
                }


            }
        }
    }
}
