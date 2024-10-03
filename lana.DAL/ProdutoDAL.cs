using lana.DTO;

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lana.DAL
{
    public class ProdutoDAL:Conexao
    {
        //CRUD
        //Create
        public void Create(ProdutoDTO produto)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("INSERT INTO Produto (NomeProduto,DescricaoProduto,UrlImgProduto,EstoqueProduto,EmLancamento,PrecoProduto,CategoriaId) VALUES (@NomeProduto,@DescricaoProduto,@UrlImgProduto,@EstoqueProduto,@EmLancamento,@PrecoProduto,@CategoriaId);", conn);
                cmd.Parameters.AddWithValue("@NomeProduto", produto.NomeProduto);
                cmd.Parameters.AddWithValue("@DescricaoProduto", produto.DescricaoProduto);
                cmd.Parameters.AddWithValue("@UrlImgProduto", produto.UrlImgProduto);
                cmd.Parameters.AddWithValue("@EstoqueProduto", produto.EstoqueProduto);
                cmd.Parameters.AddWithValue("@EmLancamento", produto.EmLancamento);
                cmd.Parameters.AddWithValue("@PrecoProduto", produto.PrecoProduto);
                cmd.Parameters.AddWithValue("@CategoriaId", produto.CategoriaId);

                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }

        //Read
        public List<ProdutoDTO> Read()
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("SELECT IdProduto, NomeProduto,DescricaoProduto,UrlImgProduto,EstoqueProduto,EmLancamento,PrecoProduto,DescricaoCategoria FROM Produto INNER JOIN Categoria ON CategoriaId = IdCategoria", conn);
                dr = cmd.ExecuteReader();
                List<ProdutoDTO> Lista = new List<ProdutoDTO>();
                while (dr.Read())
                {
                    ProdutoDTO product = new ProdutoDTO();
                    product.IdProduto = Convert.ToInt32(dr["IdProduto"]);
                    product.NomeProduto = dr["NomeProduto"].ToString();
                    product.DescricaoProduto = dr["DescricaoProduto"].ToString();
                    product.UrlImgProduto = dr["UrlImgProduto"].ToString();
                    product.EstoqueProduto = Convert.ToInt32(dr["EstoqueProduto"]);
                    product.EmLancamento = Convert.ToBoolean(dr["EmLancamento"]);
                    product.PrecoProduto = Convert.ToDouble(dr["PrecoProduto"]);
                    product.CategoriaId = dr["DescricaoCategoria"].ToString();


                    Lista.Add(product);

                }
                return Lista;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }

        //pesquisar
        public ProdutoDTO Pesquisar(int id)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("SELECT * FROM produto WHERE IdProduto = @IdProduto;", conn);
                cmd.Parameters.AddWithValue("@IdProduto", id);
                dr = cmd.ExecuteReader();

                ProdutoDTO _id = null;
                if (dr.Read())
                {
                    _id = new ProdutoDTO();
                    _id.IdProduto = Convert.ToInt32(dr["IdProduto"]);
                    _id.NomeProduto = dr["NomeProduto"].ToString();
                    _id.DescricaoProduto = dr["DescricaoProduto"].ToString();
                    _id.UrlImgProduto = dr["UrlImgProduto"].ToString();
                    _id.EstoqueProduto = Convert.ToInt32(dr["EstoqueProduto"]);
                    _id.EmLancamento = Convert.ToBoolean(dr["EmLancamento"]);
                    _id.PrecoProduto = Convert.ToDouble(dr["PrecoProduto"]);
                    _id.CategoriaId = dr["CategoriaId"].ToString();
                }
                return _id;
            }
            catch (Exception ex)
            {

                throw new Exception($"Produto não cadastrado !! {ex.Message}");
            }
            finally
            {
                Desconectar();
            }

        }


        //Update
        public void Update(ProdutoDTO produto)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("UPDATE Produto SET NomeProduto=@NomeProduto,DescricaoProduto=@DescricaoProduto,UrlImgProduto=@UrlImgProduto,EstoqueProduto=@EstoqueProduto,EmLancamento=@EmLancamento,PrecoProduto=@PrecoProduto,CategoriaId=@CategoriaId WHERE IdProduto = @IdProduto;", conn);
                cmd.Parameters.AddWithValue("@NomeProduto", produto.NomeProduto);
                cmd.Parameters.AddWithValue("@DescricaoProduto", produto.DescricaoProduto);
                cmd.Parameters.AddWithValue("@UrlImgProduto", produto.UrlImgProduto);
                cmd.Parameters.AddWithValue("@EstoqueProduto", produto.EstoqueProduto);
                cmd.Parameters.AddWithValue("@EmLancamento", produto.EmLancamento);
                cmd.Parameters.AddWithValue("@PrecoProduto", produto.PrecoProduto);
                cmd.Parameters.AddWithValue("@CategoriaId", produto.CategoriaId);
                cmd.Parameters.AddWithValue("@IdProduto", produto.IdProduto);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            finally
            {
                Desconectar();
            }

        }


        //Delete
        public void Delete(int id)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("DELETE FROM Produto WHERE IdProduto=@id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }


        //loadComboBox
        public List<CategoriaDTO> GetCategoria()
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("SELECT * FROM Categoria;", conn);
                dr = cmd.ExecuteReader();
                List<CategoriaDTO> Lista = new List<CategoriaDTO>();
                while (dr.Read())
                {
                    CategoriaDTO categoria = new CategoriaDTO();
                    categoria.IdCategoria = Convert.ToInt32(dr["IdCategoria"]);
                    categoria.DescricaoCategoria = dr["DescricaoCategoria"].ToString();

                    Lista.Add(categoria);

                }
                return Lista;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }


       

    }
}
