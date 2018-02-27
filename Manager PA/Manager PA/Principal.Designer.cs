namespace Manager_PA.Formularios
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.lblID = new System.Windows.Forms.Label();
            this.lblCadastroNome = new System.Windows.Forms.Label();
            this.lblCadastroCargo = new System.Windows.Forms.Label();
            this.txbCadastroID = new System.Windows.Forms.TextBox();
            this.txbCadastroNome = new System.Windows.Forms.TextBox();
            this.txbCadastroCargo = new System.Windows.Forms.TextBox();
            this.lblCadastroSenha = new System.Windows.Forms.Label();
            this.txbCadastroSenha = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roteiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iSupplyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subContratadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(17, 28);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(25, 13);
            this.lblID.TabIndex = 0;
            // 
            // lblCadastroNome
            // 
            this.lblCadastroNome.AutoSize = true;
            this.lblCadastroNome.Location = new System.Drawing.Point(17, 67);
            this.lblCadastroNome.Name = "lblCadastroNome";
            this.lblCadastroNome.Size = new System.Drawing.Size(37, 13);
            this.lblCadastroNome.TabIndex = 1;
            // 
            // lblCadastroCargo
            // 
            this.lblCadastroCargo.AutoSize = true;
            this.lblCadastroCargo.Location = new System.Drawing.Point(17, 106);
            this.lblCadastroCargo.Name = "lblCadastroCargo";
            this.lblCadastroCargo.Size = new System.Drawing.Size(43, 13);
            this.lblCadastroCargo.TabIndex = 2;
            // 
            // txbCadastroID
            // 
            this.txbCadastroID.Location = new System.Drawing.Point(20, 44);
            this.txbCadastroID.Name = "txbCadastroID";
            this.txbCadastroID.Size = new System.Drawing.Size(51, 20);
            this.txbCadastroID.TabIndex = 1;
            // 
            // txbCadastroNome
            // 
            this.txbCadastroNome.Location = new System.Drawing.Point(20, 83);
            this.txbCadastroNome.Name = "txbCadastroNome";
            this.txbCadastroNome.Size = new System.Drawing.Size(367, 20);
            this.txbCadastroNome.TabIndex = 2;
            // 
            // txbCadastroCargo
            // 
            this.txbCadastroCargo.Location = new System.Drawing.Point(20, 122);
            this.txbCadastroCargo.Name = "txbCadastroCargo";
            this.txbCadastroCargo.Size = new System.Drawing.Size(100, 20);
            this.txbCadastroCargo.TabIndex = 3;
            // 
            // lblCadastroSenha
            // 
            this.lblCadastroSenha.AutoSize = true;
            this.lblCadastroSenha.Location = new System.Drawing.Point(17, 155);
            this.lblCadastroSenha.Name = "lblCadastroSenha";
            this.lblCadastroSenha.Size = new System.Drawing.Size(37, 13);
            this.lblCadastroSenha.TabIndex = 4;
            // 
            // txbCadastroSenha
            // 
            this.txbCadastroSenha.Location = new System.Drawing.Point(20, 171);
            this.txbCadastroSenha.Name = "txbCadastroSenha";
            this.txbCadastroSenha.Size = new System.Drawing.Size(100, 20);
            this.txbCadastroSenha.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1026, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuárioToolStripMenuItem,
            this.roteiroToolStripMenuItem,
            this.iSupplyToolStripMenuItem,
            this.subContratadaToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // usuárioToolStripMenuItem
            // 
            this.usuárioToolStripMenuItem.Name = "usuárioToolStripMenuItem";
            this.usuárioToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.usuárioToolStripMenuItem.Text = "Usuário";
            this.usuárioToolStripMenuItem.Click += new System.EventHandler(this.usuárioToolStripMenuItem_Click);
            // 
            // roteiroToolStripMenuItem
            // 
            this.roteiroToolStripMenuItem.Name = "roteiroToolStripMenuItem";
            this.roteiroToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.roteiroToolStripMenuItem.Text = "Roteiro";
            // 
            // iSupplyToolStripMenuItem
            // 
            this.iSupplyToolStripMenuItem.Name = "iSupplyToolStripMenuItem";
            this.iSupplyToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.iSupplyToolStripMenuItem.Text = "iSupply";
            // 
            // subContratadaToolStripMenuItem
            // 
            this.subContratadaToolStripMenuItem.Name = "subContratadaToolStripMenuItem";
            this.subContratadaToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.subContratadaToolStripMenuItem.Text = "Sub Contratada";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1026, 583);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager PA";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblCadastroNome;
        private System.Windows.Forms.Label lblCadastroCargo;
        private System.Windows.Forms.TextBox txbCadastroID;
        private System.Windows.Forms.TextBox txbCadastroNome;
        private System.Windows.Forms.TextBox txbCadastroCargo;
        private System.Windows.Forms.Label lblCadastroSenha;
        private System.Windows.Forms.TextBox txbCadastroSenha;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roteiroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iSupplyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subContratadaToolStripMenuItem;
    }
}