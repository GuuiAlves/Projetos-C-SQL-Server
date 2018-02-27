namespace Manager_PA.Formularios
{
    partial class FrmCadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gpbDados = new System.Windows.Forms.GroupBox();
            this.txbCadastroSenha = new System.Windows.Forms.TextBox();
            this.lblCadastroSenha = new System.Windows.Forms.Label();
            this.txbCadastroUsuario = new System.Windows.Forms.TextBox();
            this.txbCadastroNome = new System.Windows.Forms.TextBox();
            this.lblCadastroUsuario = new System.Windows.Forms.Label();
            this.lblCadastroNome = new System.Windows.Forms.Label();
            this.btnCadastroCadastrar = new System.Windows.Forms.Button();
            this.btnCadastroExcluir = new System.Windows.Forms.Button();
            this.btnCadastroAlterar = new System.Windows.Forms.Button();
            this.btnCadastroLocalizar = new System.Windows.Forms.Button();
            this.gpbBotoes = new System.Windows.Forms.GroupBox();
            this.btnCadastroCancelar = new System.Windows.Forms.Button();
            this.btnCadastroSalvar = new System.Windows.Forms.Button();
            this.lblCadastroCodigo = new System.Windows.Forms.Label();
            this.txbCadastroCodigo = new System.Windows.Forms.TextBox();
            this.gpbDados.SuspendLayout();
            this.gpbBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbDados
            // 
            this.gpbDados.Controls.Add(this.txbCadastroCodigo);
            this.gpbDados.Controls.Add(this.lblCadastroCodigo);
            this.gpbDados.Controls.Add(this.txbCadastroSenha);
            this.gpbDados.Controls.Add(this.lblCadastroSenha);
            this.gpbDados.Controls.Add(this.txbCadastroUsuario);
            this.gpbDados.Controls.Add(this.txbCadastroNome);
            this.gpbDados.Controls.Add(this.lblCadastroUsuario);
            this.gpbDados.Controls.Add(this.lblCadastroNome);
            this.gpbDados.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbDados.ForeColor = System.Drawing.Color.Black;
            this.gpbDados.Location = new System.Drawing.Point(68, 21);
            this.gpbDados.Name = "gpbDados";
            this.gpbDados.Size = new System.Drawing.Size(458, 164);
            this.gpbDados.TabIndex = 0;
            this.gpbDados.TabStop = false;
            this.gpbDados.Text = "Dados cadastrais";
            // 
            // txbCadastroSenha
            // 
            this.txbCadastroSenha.Location = new System.Drawing.Point(20, 122);
            this.txbCadastroSenha.Name = "txbCadastroSenha";
            this.txbCadastroSenha.Size = new System.Drawing.Size(100, 20);
            this.txbCadastroSenha.TabIndex = 5;
            // 
            // lblCadastroSenha
            // 
            this.lblCadastroSenha.AutoSize = true;
            this.lblCadastroSenha.Location = new System.Drawing.Point(17, 106);
            this.lblCadastroSenha.Name = "lblCadastroSenha";
            this.lblCadastroSenha.Size = new System.Drawing.Size(37, 13);
            this.lblCadastroSenha.TabIndex = 4;
            this.lblCadastroSenha.Text = "Senha";
            // 
            // txbCadastroUsuario
            // 
            this.txbCadastroUsuario.Location = new System.Drawing.Point(20, 83);
            this.txbCadastroUsuario.Name = "txbCadastroUsuario";
            this.txbCadastroUsuario.Size = new System.Drawing.Size(100, 20);
            this.txbCadastroUsuario.TabIndex = 3;
            // 
            // txbCadastroNome
            // 
            this.txbCadastroNome.Location = new System.Drawing.Point(20, 44);
            this.txbCadastroNome.Name = "txbCadastroNome";
            this.txbCadastroNome.Size = new System.Drawing.Size(367, 20);
            this.txbCadastroNome.TabIndex = 2;
            // 
            // lblCadastroUsuario
            // 
            this.lblCadastroUsuario.AutoSize = true;
            this.lblCadastroUsuario.Location = new System.Drawing.Point(17, 67);
            this.lblCadastroUsuario.Name = "lblCadastroUsuario";
            this.lblCadastroUsuario.Size = new System.Drawing.Size(55, 13);
            this.lblCadastroUsuario.TabIndex = 2;
            this.lblCadastroUsuario.Text = "Usuário*";
            // 
            // lblCadastroNome
            // 
            this.lblCadastroNome.AutoSize = true;
            this.lblCadastroNome.Location = new System.Drawing.Point(17, 28);
            this.lblCadastroNome.Name = "lblCadastroNome";
            this.lblCadastroNome.Size = new System.Drawing.Size(37, 13);
            this.lblCadastroNome.TabIndex = 1;
            this.lblCadastroNome.Text = "Nome*";
            // 
            // btnCadastroCadastrar
            // 
            this.btnCadastroCadastrar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCadastroCadastrar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnCadastroCadastrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnCadastroCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCadastroCadastrar.ForeColor = System.Drawing.Color.Black;
            this.btnCadastroCadastrar.Location = new System.Drawing.Point(7, 14);
            this.btnCadastroCadastrar.Name = "btnCadastroCadastrar";
            this.btnCadastroCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastroCadastrar.TabIndex = 0;
            this.btnCadastroCadastrar.Text = "Novo";
            this.btnCadastroCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastroCadastrar.Click += new System.EventHandler(this.btnCadastroCadastrar_Click);
            // 
            // btnCadastroExcluir
            // 
            this.btnCadastroExcluir.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCadastroExcluir.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnCadastroExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnCadastroExcluir.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCadastroExcluir.ForeColor = System.Drawing.Color.Black;
            this.btnCadastroExcluir.Location = new System.Drawing.Point(463, 14);
            this.btnCadastroExcluir.Name = "btnCadastroExcluir";
            this.btnCadastroExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnCadastroExcluir.TabIndex = 2;
            this.btnCadastroExcluir.Text = "Excluir";
            this.btnCadastroExcluir.UseVisualStyleBackColor = false;
            // 
            // btnCadastroAlterar
            // 
            this.btnCadastroAlterar.Location = new System.Drawing.Point(191, 14);
            this.btnCadastroAlterar.Name = "btnCadastroAlterar";
            this.btnCadastroAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastroAlterar.TabIndex = 3;
            this.btnCadastroAlterar.Text = "Alterar";
            this.btnCadastroAlterar.UseVisualStyleBackColor = true;
            // 
            // btnCadastroLocalizar
            // 
            this.btnCadastroLocalizar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCadastroLocalizar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnCadastroLocalizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnCadastroLocalizar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCadastroLocalizar.ForeColor = System.Drawing.Color.Black;
            this.btnCadastroLocalizar.Location = new System.Drawing.Point(99, 14);
            this.btnCadastroLocalizar.Name = "btnCadastroLocalizar";
            this.btnCadastroLocalizar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastroLocalizar.TabIndex = 1;
            this.btnCadastroLocalizar.Text = "Localizar";
            this.btnCadastroLocalizar.UseVisualStyleBackColor = false;
            // 
            // gpbBotoes
            // 
            this.gpbBotoes.Controls.Add(this.btnCadastroCancelar);
            this.gpbBotoes.Controls.Add(this.btnCadastroSalvar);
            this.gpbBotoes.Controls.Add(this.btnCadastroAlterar);
            this.gpbBotoes.Controls.Add(this.btnCadastroExcluir);
            this.gpbBotoes.Controls.Add(this.btnCadastroLocalizar);
            this.gpbBotoes.Controls.Add(this.btnCadastroCadastrar);
            this.gpbBotoes.Location = new System.Drawing.Point(27, 191);
            this.gpbBotoes.Name = "gpbBotoes";
            this.gpbBotoes.Size = new System.Drawing.Size(543, 49);
            this.gpbBotoes.TabIndex = 4;
            this.gpbBotoes.TabStop = false;
            // 
            // btnCadastroCancelar
            // 
            this.btnCadastroCancelar.Location = new System.Drawing.Point(375, 14);
            this.btnCadastroCancelar.Name = "btnCadastroCancelar";
            this.btnCadastroCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastroCancelar.TabIndex = 5;
            this.btnCadastroCancelar.Text = "Cancelar";
            this.btnCadastroCancelar.UseVisualStyleBackColor = true;
            this.btnCadastroCancelar.Click += new System.EventHandler(this.btnCadastroCancelar_Click);
            // 
            // btnCadastroSalvar
            // 
            this.btnCadastroSalvar.Location = new System.Drawing.Point(283, 14);
            this.btnCadastroSalvar.Name = "btnCadastroSalvar";
            this.btnCadastroSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastroSalvar.TabIndex = 4;
            this.btnCadastroSalvar.Text = "Salvar";
            this.btnCadastroSalvar.UseVisualStyleBackColor = true;
            this.btnCadastroSalvar.Click += new System.EventHandler(this.btnCadastroSalvar_Click);
            // 
            // lblCadastroCodigo
            // 
            this.lblCadastroCodigo.AutoSize = true;
            this.lblCadastroCodigo.Location = new System.Drawing.Point(271, 16);
            this.lblCadastroCodigo.Name = "lblCadastroCodigo";
            this.lblCadastroCodigo.Size = new System.Drawing.Size(49, 13);
            this.lblCadastroCodigo.TabIndex = 6;
            this.lblCadastroCodigo.Text = "Codigo*";
            // 
            // txbCadastroCodigo
            // 
            this.txbCadastroCodigo.Enabled = false;
            this.txbCadastroCodigo.Location = new System.Drawing.Point(326, 13);
            this.txbCadastroCodigo.Name = "txbCadastroCodigo";
            this.txbCadastroCodigo.Size = new System.Drawing.Size(61, 20);
            this.txbCadastroCodigo.TabIndex = 7;
            // 
            // FrmCadastro
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 246);
            this.Controls.Add(this.gpbBotoes);
            this.Controls.Add(this.gpbDados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MinimumSize = new System.Drawing.Size(527, 280);
            this.Name = "FrmCadastro";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Usuários";
            this.Load += new System.EventHandler(this.FrmCadastro_Load);
            this.gpbDados.ResumeLayout(false);
            this.gpbDados.PerformLayout();
            this.gpbBotoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbDados;
        private System.Windows.Forms.Label lblCadastroNome;
        private System.Windows.Forms.TextBox txbCadastroNome;
        private System.Windows.Forms.Button btnCadastroExcluir;
        private System.Windows.Forms.Button btnCadastroCadastrar;
        private System.Windows.Forms.TextBox txbCadastroSenha;
        private System.Windows.Forms.Label lblCadastroSenha;
        private System.Windows.Forms.Button btnCadastroAlterar;
        private System.Windows.Forms.TextBox txbCadastroUsuario;
        private System.Windows.Forms.Label lblCadastroUsuario;
        private System.Windows.Forms.Button btnCadastroLocalizar;
        private System.Windows.Forms.GroupBox gpbBotoes;
        private System.Windows.Forms.Button btnCadastroCancelar;
        private System.Windows.Forms.Button btnCadastroSalvar;
        private System.Windows.Forms.TextBox txbCadastroCodigo;
        private System.Windows.Forms.Label lblCadastroCodigo;
    }
}