using lana.BLL;
using lana.DTO;
using lana.UI.utilities;

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
    public partial class frmDelete : Form
    {
        public frmDelete()
        {
            InitializeComponent();
        }
        UsuarioDTO obj = new UsuarioDTO();
        UsuarioBLL objBLL = new UsuarioBLL();
        //fechar
        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
        //pesquisar
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Digite um Id", "Atenção !!", MessageBoxButtons.OK);
                txtId.Focus();
                return;
            }

            int codigo = Convert.ToInt32(txtId.Text.Trim());
            obj = objBLL.PesquisarUser(codigo);
            if (obj != null)
            {

                btnExcluir.Enabled = true;

                txtId.Text = obj.IdUsuario.ToString();
                lblNome.Text = obj.NomeUsuario.ToString();
                lblSenha.Text = obj.SenhaUsuario.ToString();
                lblData.Text = obj.DtNascUsuario.ToString("dd/MM/yyyy");
                pBox1.ImageLocation = obj.UrlImgUsuario.ToString();
               lblUrlImg.Text = obj.UrlImgUsuario.ToString();

                if (obj.TpUsuario == "1")
                {
                    lblTpUsuario.Text = "Administrador";
                }
                else
                {
                    lblTpUsuario.Text = "Outros";

                }

            }
            else
            {
                MessageBox.Show("Usuário inexistente !!");
                Clear.ClearControl(this);
                txtId.Focus();
                return;
            }
        }
        //cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Clear.ClearControl(this);
            btnExcluir.Enabled=false;
            txtId.Focus();
        }

        //somente numeros
        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //excluir
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show("Deseja realmente excluir este registro ??", "ATENÇÃO PORRA!!",MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (msg == DialogResult.Yes)
            {
                int id = Convert.ToInt32(txtId.Text.Trim());
                objBLL.DeleteUser(id);
                Clear.ClearControl(this);
                txtId.Focus();
                MessageBox.Show("Registro eliminado com sucesso !!", "SUCESSO !", MessageBoxButtons.OK);
            }
            else if (msg == DialogResult.No)
            {
                Clear.ClearControl(this);
                txtId.Focus();
            }
        }
        //load
        private void frmDelete_Load(object sender, EventArgs e)
        {
            btnExcluir.Enabled = false;
        }
    }
}
