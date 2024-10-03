using lana.BLL;
using lana.DTO;

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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            //pegando as informacoes do usuario
            string nome = txtNome.Text.Trim();
            string senha = txtSenha.Text.Trim();

            //criando os objs
            UsuarioDTO usuario = new UsuarioDTO();
            UsuarioBLL usuarioBLL = new UsuarioBLL();

            //autenticando
            usuario = usuarioBLL.AutenticaUsuario(nome, senha);

            if (usuario != null)
            {
                switch (usuario.TpUsuario)
                {
                    case "1":
                        Session.nomeUsuario = usuario.NomeUsuario.Trim();
                        mdiAdm obj = new mdiAdm();
                        obj.Show();
                        this.Visible = false;
                        break;
                    case "2":
                        Session.nomeUsuario = usuario.NomeUsuario.Trim();
                        mdiUser _obj = new mdiUser();
                        _obj.Show();
                        this.Visible = false;
                        break;
                }
            }

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = txtSenha.Text = string.Empty;
            txtNome.Focus();

        }
    }
}
