using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manager_PA.Formularios
{
    public partial class FrmCadastro : Form
    {
        public string operacao = "";
        public FrmCadastro()
        {
            InitializeComponent();
        }

        public void AlteraBotoes(int op)
        {
            gpbDados.Enabled = false;
            btnCadastroCadastrar.Enabled = false;
            btnCadastroLocalizar.Enabled = false;
            btnCadastroAlterar.Enabled = false;
            btnCadastroSalvar.Enabled = false;
            btnCadastroExcluir.Enabled = false;
            btnCadastroCancelar.Enabled = false;

            if (op == 1)
            {
                btnCadastroCadastrar.Enabled = true;
                btnCadastroLocalizar.Enabled = true;
            }
            if (op == 2)
            {
                gpbDados.Enabled = true;
                btnCadastroSalvar.Enabled = true;
                btnCadastroCancelar.Enabled = true;
            }

            if (op == 3)
            {
                btnCadastroExcluir.Enabled = true;
                btnCadastroAlterar.Enabled = true;
            }
        }

        public void LimpaCampos()
        {
            txbCadastroNome.Clear();
            txbCadastroSenha.Clear();
            txbCadastroUsuario.Clear();
        }
        private void FrmCadastro_Load(object sender, EventArgs e)
        {
            this.AlteraBotoes(1);
        }

        private void btnCadastroCadastrar_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.AlteraBotoes(2);
            Classes.Cadastra_Usuarios Cadastro = new Classes.Cadastra_Usuarios();
            Cadastro.Nome = txbCadastroNome.Text;
            Cadastro.User = txbCadastroUsuario.Text;
            Cadastro.Senha = txbCadastroSenha.Text;
            if (this.operacao == "inserir")
            {
                String srtConexao = @"Data Source=GUILHERME-PC\SQLEXPRESS;User ID=sa;Initial Catalog=DatabaseManagerPA;User ID=sa;Password=admin123";
                Classes.Conexao conexao = new Classes.Conexao(srtConexao);
                try
                {
                    conexao.Conectar();
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }
            else
            {
                Cadastro.Codigo = Convert.ToInt32(txbCadastroCodigo.Text);
                //alterar o contato que está na tela
            }
        }

        private void btnCadastroCancelar_Click(object sender, EventArgs e)
        {
            this.AlteraBotoes(1);
            this.LimpaCampos();

        }

        private void btnCadastroSalvar_Click(object sender, EventArgs e)
        {
            Classes.Cadastra_Usuarios Cadastro = new Classes.Cadastra_Usuarios();
            Cadastro.Nome = txbCadastroNome.Text;
            Cadastro.User = txbCadastroUsuario.Text;
            Cadastro.Senha = txbCadastroSenha.Text;
            String srtConexao = @"Data Source=GUILHERME-PC\SQLEXPRESS;User ID=sa;Initial Catalog=DatabaseManagerPA;User ID=sa;Password=admin123";
            Classes.Conexao conexao = new Classes.Conexao(srtConexao);
            Classes.DALManagerPA dal = new Classes.DALManagerPA(conexao);
            if (this.operacao == "inserir")
            {
                dal.Incluir(Cadastro);
                MessageBox.Show("Usuário cadastrado! Codigo de cadastro: "+Cadastro.Codigo.ToString());
            }
            else
            {
                Cadastro.Codigo = Convert.ToInt32(txbCadastroCodigo.Text);
                //alterar o contato que está na tela
            }
        }
    }
}
