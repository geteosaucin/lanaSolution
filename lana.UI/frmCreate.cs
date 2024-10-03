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
    public partial class frmCreate : Form
    {

        UsuarioDTO usuario = new UsuarioDTO();
        UsuarioBLL UsuarioBLL = new UsuarioBLL();

        public frmCreate()
        {
            InitializeComponent();
        }

        //load
        private void frmCreate_Load(object sender, EventArgs e)
        {
            cBox1.Items.Clear();
            cBox1.DisplayMember = "DescricaoTipoUsuario";
            cBox1.ValueMember = "IdTipoUsuario";
            cBox1.DataSource = UsuarioBLL.GetTiposUser();
        }

        //validacao
        private bool ValidaForm()
        {
            bool valida;
            if (string.IsNullOrEmpty(txtNome.Text))
            {
                txtNome.BackColor = Color.Red;
                MessageBox.Show("Digite a porra do nome!","Se liga!",MessageBoxButtons.OK);
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




        //btnClose
        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }


        //carregando a imagem
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

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (ValidaForm())
            {
                
        

            usuario.NomeUsuario = txtNome.Text;
            usuario.SenhaUsuario = txtSenha.Text;

            //ajustando a data
            DateTime dt = DateTime.Parse(txtData.Text);
            usuario.DtNascUsuario = dt;

            //salvando a url
            string nomeImg = txtNome.Text + ".jpg";

            string pasta = @"C:\Users\wil.rrsilva\source\repos\lanaSolution\lana.UI\img\";
            string pathImage = Path.Combine(pasta, nomeImg);

            usuario.UrlImgUsuario = pathImage;

            //salvando na pasta
            Image a = pBox1.Image;
            a.Save(pathImage);



            usuario.TpUsuario = cBox1.SelectedValue.ToString();


            UsuarioBLL.CreateUser(usuario);

            MessageBox.Show($"Usuario {usuario.NomeUsuario.ToUpper()} cadastrado com sucesso !");

                Clear.ClearControl(this);
                txtNome.Focus();


            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Clear.ClearControl(this);
            txtNome.Focus();
        }
    }
}
