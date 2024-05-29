namespace controle_financeiro
{
    partial class PrincipalUI
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
      this.menu = new System.Windows.Forms.MenuStrip();
      this.menuItemReceitas = new System.Windows.Forms.ToolStripMenuItem();
      this.menuItemReceitasSalario = new System.Windows.Forms.ToolStripMenuItem();
      this.menuItemReceitasCobrancas = new System.Windows.Forms.ToolStripMenuItem();
      this.menuItemDespesas = new System.Windows.Forms.ToolStripMenuItem();
      this.menuItemDespesasFixas = new System.Windows.Forms.ToolStripMenuItem();
      this.menuItemDespesasCompras = new System.Windows.Forms.ToolStripMenuItem();
      this.menuItemDespesasCartoes = new System.Windows.Forms.ToolStripMenuItem();
      this.menu.SuspendLayout();
      this.SuspendLayout();
      // 
      // menu
      // 
      this.menu.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.menu.GripMargin = new System.Windows.Forms.Padding(2);
      this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemReceitas,
            this.menuItemDespesas});
      this.menu.Location = new System.Drawing.Point(0, 0);
      this.menu.Name = "menu";
      this.menu.Padding = new System.Windows.Forms.Padding(5);
      this.menu.Size = new System.Drawing.Size(780, 30);
      this.menu.TabIndex = 1;
      this.menu.Text = "menu";
      // 
      // menuItemReceitas
      // 
      this.menuItemReceitas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemReceitasCobrancas,
            this.menuItemReceitasSalario});
      this.menuItemReceitas.Name = "menuItemReceitas";
      this.menuItemReceitas.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
      this.menuItemReceitas.Size = new System.Drawing.Size(67, 20);
      this.menuItemReceitas.Text = "Receitas";
      // 
      // menuItemReceitasSalario
      // 
      this.menuItemReceitasSalario.Name = "menuItemReceitasSalario";
      this.menuItemReceitasSalario.Padding = new System.Windows.Forms.Padding(0);
      this.menuItemReceitasSalario.Size = new System.Drawing.Size(180, 20);
      this.menuItemReceitasSalario.Text = "Salário";
      // 
      // menuItemReceitasCobrancas
      // 
      this.menuItemReceitasCobrancas.Name = "menuItemReceitasCobrancas";
      this.menuItemReceitasCobrancas.Padding = new System.Windows.Forms.Padding(0);
      this.menuItemReceitasCobrancas.Size = new System.Drawing.Size(180, 20);
      this.menuItemReceitasCobrancas.Text = "Cobranças";
      this.menuItemReceitasCobrancas.Click += new System.EventHandler(this.menuItemReceitasCobrancas_Click);
      // 
      // menuItemDespesas
      // 
      this.menuItemDespesas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemDespesasCompras,
            this.menuItemDespesasCartoes,
            this.menuItemDespesasFixas});
      this.menuItemDespesas.Name = "menuItemDespesas";
      this.menuItemDespesas.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
      this.menuItemDespesas.Size = new System.Drawing.Size(74, 20);
      this.menuItemDespesas.Text = "Despesas";
      // 
      // menuItemDespesasFixas
      // 
      this.menuItemDespesasFixas.Name = "menuItemDespesasFixas";
      this.menuItemDespesasFixas.Padding = new System.Windows.Forms.Padding(0);
      this.menuItemDespesasFixas.Size = new System.Drawing.Size(180, 20);
      this.menuItemDespesasFixas.Text = "Fixas";
      // 
      // menuItemDespesasCompras
      // 
      this.menuItemDespesasCompras.Name = "menuItemDespesasCompras";
      this.menuItemDespesasCompras.Padding = new System.Windows.Forms.Padding(0);
      this.menuItemDespesasCompras.Size = new System.Drawing.Size(180, 20);
      this.menuItemDespesasCompras.Text = "Compras";
      // 
      // menuItemDespesasCartoes
      // 
      this.menuItemDespesasCartoes.Name = "menuItemDespesasCartoes";
      this.menuItemDespesasCartoes.Size = new System.Drawing.Size(180, 22);
      this.menuItemDespesasCartoes.Text = "Cartões";
      // 
      // PrincipalUI
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
      this.ClientSize = new System.Drawing.Size(780, 557);
      this.Controls.Add(this.menu);
      this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
      this.IsMdiContainer = true;
      this.MainMenuStrip = this.menu;
      this.Margin = new System.Windows.Forms.Padding(4);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.MinimumSize = new System.Drawing.Size(800, 600);
      this.Name = "PrincipalUI";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Controle Financeiro";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.menu.ResumeLayout(false);
      this.menu.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem menuItemReceitas;
        private System.Windows.Forms.ToolStripMenuItem menuItemReceitasSalario;
        private System.Windows.Forms.ToolStripMenuItem menuItemReceitasCobrancas;
        private System.Windows.Forms.ToolStripMenuItem menuItemDespesas;
        private System.Windows.Forms.ToolStripMenuItem menuItemDespesasFixas;
        private System.Windows.Forms.ToolStripMenuItem menuItemDespesasCompras;
    private System.Windows.Forms.ToolStripMenuItem menuItemDespesasCartoes;
  }
}

