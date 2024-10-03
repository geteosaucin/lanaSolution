using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lana.DAL
{
    public class Conexao
    {
        //variaveis
        protected SqlConnection conn;
        protected SqlCommand cmd;
        protected SqlDataReader dr;

        //metodos
        protected void Conectar()
        {
            try
            {
                conn = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB;Initial Catalog=lanaDB ;Integrated Security = true");
                conn.Open();

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        protected void Desconectar()
        {
            try
            {
               
                conn.Close();

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

    }
}
