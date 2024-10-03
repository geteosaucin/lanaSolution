using lana.DAL;
using lana.DTO;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lana.BLL
{
    public class ProdutoBLL
    {
        ProdutoDAL obj = new ProdutoDAL();

        //createProduct
        public void CreateProduct(ProdutoDTO product)
        {
            obj.Create(product);

        }

        //listar
        public List<ProdutoDTO> ListProduct()
        {
            return obj.Read();
        }

        //load combo box

        //loadComboBox
        public List<CategoriaDTO> GetCategoriaBLL()
        {
            return obj.GetCategoria();
        }


        //pesquisar
        public ProdutoDTO PesquisarProduct(int id)
        {
            return obj.Pesquisar(id);
        }

        //Update
        public void UpdateProduct(ProdutoDTO produto)
        {
            obj.Update(produto);
        }


        //Delete
        public void DeleteProduct(int id)
        {
            obj.Delete(id);
        }
    }
}
