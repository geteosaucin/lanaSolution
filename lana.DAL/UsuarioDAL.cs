using lana.DTO;

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace lana.DAL
{
    public class UsuarioDAL:Conexao
    {
        //autenticar
        public UsuarioDTO Autenticar(string usuario,string senha )
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("SELECT * FROM usuario WHERE NomeUsuario = @NomeUsuario AND SenhaUsuario = @SenhaUsuario;", conn);
                cmd.Parameters.AddWithValue("@NomeUsuario", usuario);
                cmd.Parameters.AddWithValue("@SenhaUsuario", senha);
                dr = cmd.ExecuteReader();

                UsuarioDTO _usuario = null;
                if (dr.Read())
                {
                    _usuario = new UsuarioDTO();
                    _usuario.NomeUsuario = dr["NomeUsuario"].ToString();
                    _usuario.SenhaUsuario = dr["SenhaUsuario"].ToString();
                    _usuario.TpUsuario = dr["TpUsuario"].ToString();
                }
                return _usuario;
            }
            catch (Exception ex)
            {

                throw new Exception($"Usuário não cadastrado !! {ex.Message}");
            }
            finally
            {
                Desconectar();
            }

        }
    

        //CRUD
        //Create
        public void Create(UsuarioDTO usuario)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("INSERT INTO Usuario (NomeUsuario,SenhaUsuario,DtNascUsuario,UrlImgUsuario,TpUsuario) VALUES (@nome,@senha,@data,@img,@tpusuario);", conn);
                cmd.Parameters.AddWithValue("@nome", usuario.NomeUsuario);
                cmd.Parameters.AddWithValue("@senha", usuario.SenhaUsuario);
                cmd.Parameters.AddWithValue("@data", usuario.DtNascUsuario);
                cmd.Parameters.AddWithValue("@img", usuario.UrlImgUsuario);
                cmd.Parameters.AddWithValue("@tpusuario", usuario.TpUsuario);
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
        public List<UsuarioDTO> Read()
        {
            try
            {
                Conectar() ;
                cmd = new SqlCommand("SELECT IdUsuario,NomeUsuario,SenhaUsuario, DtNascUsuario,UrlImgUsuario, DescricaoTipoUsuario FROM Usuario INNER JOIN TipoUsuario ON TpUsuario = IdTipoUsuario", conn);
                dr = cmd.ExecuteReader();
                List<UsuarioDTO> Lista = new List<UsuarioDTO>();
                while (dr.Read())
                {
                    UsuarioDTO usuario = new UsuarioDTO();
                    usuario.IdUsuario = Convert.ToInt32(dr["IdUsuario"]);
                    usuario.NomeUsuario = dr["NomeUsuario"].ToString();
                    usuario.SenhaUsuario = dr["SenhaUsuario"].ToString();
                    usuario.DtNascUsuario = Convert.ToDateTime(dr["DtNascUsuario"]);
                    usuario.UrlImgUsuario = dr["UrlImgUsuario"].ToString();
                    usuario.TpUsuario = dr["DescricaoTipoUsuario"].ToString();
                    Lista.Add(usuario);

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


        //Update
        public void Update(UsuarioDTO usuario)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("UPDATE Usuario SET NomeUsuario=@nome,SenhaUsuario=@senha,DtNascUsuario=@data,UrlImgUsuario=@img,TpUsuario=@tpusuario WHERE IdUsuario = @id;", conn);
                cmd.Parameters.AddWithValue("@nome", usuario.NomeUsuario);
                cmd.Parameters.AddWithValue("@senha", usuario.SenhaUsuario);
                cmd.Parameters.AddWithValue("@data", usuario.DtNascUsuario);
                cmd.Parameters.AddWithValue("@img", usuario.UrlImgUsuario);
                cmd.Parameters.AddWithValue("@tpusuario", usuario.TpUsuario);
                cmd.Parameters.AddWithValue("@id", usuario.IdUsuario);
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
                cmd = new SqlCommand("DELETE FROM Usuario WHERE IdUsuario=@id", conn);
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
        public List<TipoUsuarioDTO> GetTipos()
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("SELECT * FROM TipoUsuario;", conn);
                dr = cmd.ExecuteReader();
                List<TipoUsuarioDTO> Lista = new List<TipoUsuarioDTO>();
                while (dr.Read())
                {
                    TipoUsuarioDTO tipoUsuario = new TipoUsuarioDTO();
                    tipoUsuario.IdTipoUsuario = Convert.ToInt32(dr["IdTipoUsuario"]);
                    tipoUsuario.DescricaoTipoUsuario = dr["DescricaoTipoUsuario"].ToString();
                  
                    Lista.Add(tipoUsuario);

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
        public UsuarioDTO Pesquisar(int id)
        {
            try
            {
                Conectar();
                cmd = new SqlCommand("SELECT * FROM usuario WHERE IdUsuario = @IdUsuario;", conn);
                cmd.Parameters.AddWithValue("@IdUsuario", id);
                dr = cmd.ExecuteReader();

                UsuarioDTO _id = null;
                if (dr.Read())
                {
                    _id = new UsuarioDTO();
                    _id.IdUsuario = Convert.ToInt32(dr["IdUsuario"]);
                    _id.NomeUsuario = dr["NomeUsuario"].ToString();
                    _id.SenhaUsuario = dr["SenhaUsuario"].ToString();
                    _id.DtNascUsuario = Convert.ToDateTime(dr["DtNascUsuario"]);
                    _id.UrlImgUsuario = dr["UrlImgUsuario"].ToString();
                    _id.TpUsuario = dr["TpUsuario"].ToString();
                }
                return _id;
            }
            catch (Exception ex)
            {

                throw new Exception($"Usuário não cadastrado !! {ex.Message}");
            }
            finally
            {
                Desconectar();
            }

        }



    }
}
