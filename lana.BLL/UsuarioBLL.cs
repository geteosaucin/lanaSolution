using lana.DAL;
using lana.DTO;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lana.BLL
{
    public class UsuarioBLL
    {
        UsuarioDAL obj = new UsuarioDAL();

        //autenticar
        public UsuarioDTO AutenticaUsuario(string nome, string senha)
        {
            return obj.Autenticar(nome, senha);
        }

        //listar
        public List<UsuarioDTO> ListUser()
        {
            return obj.Read();
        }

        //createUser
        public void CreateUser(UsuarioDTO user)
        {
            obj.Create(user);

        }

        //load combo box
        public List<TipoUsuarioDTO> GetTiposUser()
        {
            return obj.GetTipos();
        }


        //pesquisar
        public UsuarioDTO PesquisarUser(int id)
        {
            return obj.Pesquisar(id);
        }

        //Update
        public void UpdateUser(UsuarioDTO usuario)
        {
            obj.Update(usuario);
        }


        //Delete
        public void DeleteUser(int id)
        {
            obj.Delete(id);
        }

    }
}
