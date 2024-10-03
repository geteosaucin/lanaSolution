using DGVPrinterHelper;

using lana.BLL;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lana.UI
{
    public partial class frmRelatorioUser : Form
    {
        public frmRelatorioUser()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            UsuarioBLL obj = new UsuarioBLL();
            dgv1.DataSource = obj.ListUser();
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = lblTitulo.Text;
            printer.PageNumbers = true;
            printer.PorportionalColumns = true;
            printer.Footer = DateTime.Now.ToString();
            printer.PrintDataGridView(dgv1);
        }

        private void frmRelatorioUser_Load(object sender, EventArgs e)
        {

        }
    }
}
