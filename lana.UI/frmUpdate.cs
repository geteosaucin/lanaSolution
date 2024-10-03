using lana.BLL;
using lana.DTO;
using lana.UI.utilities;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lana.UI
{
    public partial class frmUpdate : Form
    {
        public frmUpdate()
        {
            InitializeComponent();
        }
        UsuarioDTO obj = new UsuarioDTO();
        UsuarioBLL objBLL = new UsuarioBLL();
        //load
        private void frmUpdate_Load(object sender, EventArgs e)
        {
            gBox1.Enabled = false;
            cBox1.Items.Clear();
            cBox1.DisplayMember = "DescricaoTipoUsuario";
            cBox1.ValueMember = "IdTipoUsuario";
            cBox1.DataSource = objBLL.GetTiposUser();
            btnEditar.Visible = false;
            btnSalvar.Visible = false;
        }

        //validacao
        private bool ValidaForm()
        {
            bool valida;
            if (string.IsNullOrEmpty(txtNome.Text))
            {
                txtNome.BackColor = Color.Red;
                MessageBox.Show("Digite a porra do nome!", "Se liga!", MessageBoxButtons.OK);
                txtNome.BackColor = DefaultBackColor;
                txtNome.Focus();
                valida = false;
            }
            else if (string.IsNullOrEmpty(txtSenha.Text))
            {
                txtSenha.BackColor = Color.Red;
                MessageBox.Show("Digite a porra da senha!", "Se liga!", MessageBoxButtons.OK);
                txtSenha.BackColor = DefaultBackColor;
                txtSenha.Focus();
                valida = false;
            }
            else if (string.IsNullOrEmpty(txtData.Text) || txtData.Text.Length < 10)
            {
                txtData.BackColor = Color.Red;
                MessageBox.Show("Digite a porra da data!", "Se liga!", MessageBoxButtons.OK);
                txtData.BackColor = DefaultBackColor;
                txtData.Focus();
                valida = false;
            }
            else if (pBox1.Image == null)
            {
                pBox1.BackColor = Color.Red;
                MessageBox.Show("Selecione a porra da imagem!", "Se liga!", MessageBoxButtons.OK);
                pBox1.BackColor = DefaultBackColor;
                btnImg.Focus();
                valida = false;
            }
            else
            {
                valida = true;

            }
            return valida;

        }

        //permite somente numeros
        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
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
                btnEditar.Visible = true;


                txtId.Text = obj.IdUsuario.ToString();
                txtNome.Text = obj.NomeUsuario.ToString();
                txtSenha.Text = obj.SenhaUsuario.ToString();
                txtData.Text = obj.DtNascUsuario.ToString();
                pBox1.ImageLocation = obj.UrlImgUsuario.ToString();

                if (obj.TpUsuario=="1")
                {
                    cBox1.Text = "Administrador";
                }
                else
                {
                    cBox1.Text = "Outros";

                }


            }
            else
            {
                MessageBox.Show("Usuário inexistente !!");
                return;
            }
        }
        //salvar
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidaForm())
            {
                obj.IdUsuario = Convert.ToInt32(txtId.Text.Trim());
                obj.NomeUsuario = txtNome.Text.Trim();
                obj.SenhaUsuario = txtSenha.Text.Trim();
                obj.DtNascUsuario = Convert.ToDateTime(txtData.Text);
                //imagem
                obj.UrlImgUsuario = pBox1.ImageLocation.ToString();
                //salvando a imagem
                //salvando a url
                string nomeImg = txtNome.Text + ".jpg";

                string pasta = @"C:\Users\wil.rrsilva\source\repos\lanaSolution\lana.UI\img\";
                string pathImage = Path.Combine(pasta, nomeImg);

                obj.UrlImgUsuario = pathImage;

                //salvando na pasta
                Image a = pBox1.Image;
                a.Save(pathImage);


                obj.TpUsuario = cBox1.SelectedValue.ToString();

                objBLL.UpdateUser(obj);
                MessageBox.Show($"Usuário {obj.NomeUsuario.ToUpper()} editado com sucesso !!");
            }
        }
        //imagem
        private void btnImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Imagens | *.bmp; *.jpg;*.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string img = ofd.FileName.ToString();
                pBox1.ImageLocation = img;
            }
        }
        //fechar
        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
        //clear
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Clear.ClearControl(this);
            gBox1.Enabled = false;
            txtId.Enabled = true;
            btnPesquisar.Enabled = true;
            btnSalvar.Visible = btnEditar.Visible = false;
            txtId.Focus();
        }
        //editar
        private void btnEditar_Click(object sender, EventArgs e)
        {
            gBox1.Enabled = true;
            txtId.Enabled = false;
            btnPesquisar.Enabled = false;
            btnSalvar.Visible = true;
        }
    }
}
