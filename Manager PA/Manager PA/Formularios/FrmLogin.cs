using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Manager_PA
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();            
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnSobre_Click(object sender, EventArgs e)
        {
            Sobre.frmSobre sobre = new Sobre.frmSobre();
            sobre.ShowDialog();
            sobre.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            /*SqlConnection conexaosql = new SqlConnection(@"Data Source=GUILHERME-PC\GUILHERME;Initial Catalog=ManagerDatabase;User ID=sa;Password=100loucura");
            String Query = "select * from Usuarios where USUARIO= '" + txbUsuario.Text.Trim() + "' and SENHA= '" + txbSenha.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(Query, conexaosql);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if(dtbl.Rows.Count == 1)
            {
                Formularios.Principal frmP = new Formularios.Principal();
                this.Hide();
                frmP.Show();
            }
            else
            {
                MessageBox.Show("Dados inválidos");
                txbSenha.Clear();
            }*/

            SqlConnection conexaosql = new SqlConnection(@"Data Source=GUILHERME-PC\SQLEXPRESS;User ID=sa;Initial Catalog=DatabaseManagerPA;User ID=sa;Password=admin123");
            SqlCommand comandosql = new SqlCommand("select * from Cadastro_usuarios where usuario_user= '"+ txbUsuario.Text +"' and usuario_senha= '"+ txbSenha.Text +"'", conexaosql);
            SqlDataReader dr;
            conexaosql.Open();
            dr = comandosql.ExecuteReader();
            int count = 0;
            while (dr.Read())
            {
                count += 1;
            }

            if (count == 1)
            {
                Formularios.Principal frmP = new Formularios.Principal();
                this.Hide();
                frmP.Show();
            }
            else if (count > 0)
            {
                MessageBox.Show("Usuario e senha duplicados");
            }
            else
            {
                MessageBox.Show("Usuario ou senha incorretos");
            }

            txbUsuario.Clear();
            txbSenha.Clear();
        }

    }
}

