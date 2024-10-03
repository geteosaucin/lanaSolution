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
    public partial class mdiAdm : Form
    {
        public mdiAdm()
        {
            InitializeComponent();
        }

        private void mdiAdm_Load(object sender, EventArgs e)
        {
            lblSession.Text = $"Seja bem vindo {Session.nomeUsuario.ToUpper()} ao sistema Lana, sua sessão inicia as {DateTime.Now:t}";
        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRelatorioUser relatorioUser = new frmRelatorioUser();
            relatorioUser.ShowDialog();
        }

        private void relatorioUser_Click(object sender, EventArgs e)
        {
            frmRelatorioUser relatorioUser = new frmRelatorioUser();
            relatorioUser.ShowDialog();
        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCreate relatorioUser = new frmCreate();
            relatorioUser.ShowDialog();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmCreate relatorioUser = new frmCreate();
            relatorioUser.ShowDialog();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdate relatorioUser = new frmUpdate();
            relatorioUser.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmUpdate relatorioUser = new frmUpdate();
            relatorioUser.ShowDialog();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDelete relatorioUser = new frmDelete();
            relatorioUser.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            frmDelete relatorioUser = new frmDelete();
            relatorioUser.ShowDialog();
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sair_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deseja realmente sair da aplicação ?", "Atenção! PORRA !",MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show($"{Session.nomeUsuario.ToUpper()} sua sessão será encerrada !", "Atenção PORRA !", MessageBoxButtons.OK);
            Application.Exit();

            }
            else
            {
                return;
            }

        }

        private void msWord_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("winword");
        }

        private void notepad_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad");

        }

        private void calculadora_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc");

        }
    }
}
