using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Manager_PA.Classes
{
    public class DALManagerPA
    {
        private Conexao objConexao;

        public DALManagerPA(Conexao conexao)
        {
            objConexao = conexao;
        }

        public void Incluir(Cadastra_Usuarios cadastro)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objConexao.ObjetoConexao;
            cmd.CommandText = "insert into Cadastro_usuarios(usuario_nome, usuario_user, usuario_senha) values (@nome, @user, @senha); select @@IDENTITY";
            cmd.Parameters.AddWithValue("@nome", cadastro.Nome);
            cmd.Parameters.AddWithValue("@user", cadastro.User);
            cmd.Parameters.AddWithValue("@senha", cadastro.Senha);
            objConexao.Conectar();
            cadastro.Codigo = Convert.ToInt32(cmd.ExecuteScalar());

        }

    }
}
