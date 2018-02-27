using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager_PA.Classes
{
    public class Cadastra_Usuarios
    {

        public Cadastra_Usuarios()
        {
            this.User ="";
            this.Senha ="";
            this.Nome ="";
        }

        public Cadastra_Usuarios(String usuario, String senha, String nome)
        {
            this.User = usuario;
            this.Senha = senha;
            this.Nome = nome;
        }

        private int usuario_codigo = 0;
        public int Codigo
        {
            get { return this.usuario_codigo; }
            set { this.usuario_codigo = value; }
        }

        private String usuario_user;
        public String User
        {
            get { return this.usuario_user; }
            set { this.usuario_user = value; }
        }

        private String usuario_senha;
        public String Senha
        {
            get { return this.usuario_senha; }
            set { this.usuario_senha = value; }
        }

        private String usuario_nome;
        public String Nome
        {
            get { return this.usuario_nome; }
            set { this.usuario_nome = value; }
        }
    }
}
