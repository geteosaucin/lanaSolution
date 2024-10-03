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
    public partial class frmReadProduct : Form
    {
        public frmReadProduct()
        {
            InitializeComponent();
        }
        ProdutoDTO produto = new ProdutoDTO();
        ProdutoBLL obj = new ProdutoBLL();

        private void frmReadProduct_Load(object sender, EventArgs e)
        {
            txtId.Enabled = false;

            cBox1.Items.Clear();
            cBox1.DisplayMember = "DescricaoCategoria";
            cBox1.ValueMember = "IdCategoria";
            cBox1.DataSource = obj.GetCategoriaBLL();

            DataGridViewRow row = dgv1.RowTemplate;
            row.Height = 100;

        }

        private void btnPdf_Click(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {

            dgv1.DataSource = obj.ListProduct();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgv1_SelectionChanged(object sender, EventArgs e)
        {
            ProdutoDTO produto = new ProdutoDTO();
        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int productId = int.Parse(dgv1.Rows[e.RowIndex].Cells["IdProduto"].Value.ToString());
            produto = obj.PesquisarProduct(productId);
            txtId.Text = produto.IdProduto.ToString();
            txtNome.Text = produto.NomeProduto.ToString();
            txtEstoque.Text = produto.EstoqueProduto.ToString();
            txtDescricao.Text = produto.DescricaoProduto.ToString();
            txtPreco.Text = produto.PrecoProduto.ToString();
            ckBox1.Checked = produto.EmLancamento;
            if (produto.CategoriaId == "1")
            {
                cBox1.Text = "Eletronico";
            }
            else if (produto.CategoriaId == "2")
            {
                cBox1.Text = "Eletrodomestico";
            }
            else
            {
                cBox1.Text = "Quiquilharia";
            }
            pBox1.ImageLocation = produto.UrlImgProduto.ToString();

        }

        //record
        private void btnRecord_Click(object sender, EventArgs e)
        {
            produto.NomeProduto = txtNome.Text.Trim();
            produto.EstoqueProduto = Convert.ToInt32(txtEstoque.Text.Trim());
            produto.DescricaoProduto = txtDescricao.Text.Trim();
            produto.PrecoProduto = Convert.ToInt32(txtPreco.Text.Trim());
            if (ckBox1.Checked)
            {
                produto.EmLancamento = true;
            }
            else
            {
                produto.EmLancamento = false;
            }
            produto.CategoriaId = cBox1.SelectedValue.ToString();

            produto.UrlImgProduto = pBox1.ImageLocation;


            if (string.IsNullOrEmpty(txtId.Text))
            {

                obj.CreateProduct(produto);
                dgv1.DataSource = obj.ListProduct();
                MessageBox.Show($"Produto {produto.NomeProduto.ToUpper()} cadastrado com sucesso !");
                Clear.ClearControl(this);
                txtNome.Focus();
            }
            else
            {
                produto.IdProduto = Convert.ToInt32(txtId.Text);
                obj.UpdateProduct(produto);
                dgv1.DataSource = obj.ListProduct();
                MessageBox.Show($"Produto {produto.NomeProduto.ToUpper()} editado com sucesso !");
                Clear.ClearControl(this);
                txtNome.Focus();
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

        //clear
        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear.ClearControl(this);
            txtNome.Focus();
        }

        //delete
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show("Deseja realmente excluir este registro ??", "ATENÇÃO PORRA!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (msg == DialogResult.Yes)
            {
                int id = Convert.ToInt32(txtId.Text.Trim());
                obj.DeleteProduct(id);
                dgv1.DataSource = obj.ListProduct();
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
    }
}
