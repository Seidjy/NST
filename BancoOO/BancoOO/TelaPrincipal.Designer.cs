namespace BancoOO
{
    partial class TelaPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transferênciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debitoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transferênciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem,
            this.transferênciasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(507, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contaToolStripMenuItem,
            this.consultarToolStripMenuItem});
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.cadastrarToolStripMenuItem.Text = "Contas";
            // 
            // contaToolStripMenuItem
            // 
            this.contaToolStripMenuItem.Name = "contaToolStripMenuItem";
            this.contaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.contaToolStripMenuItem.Text = "Cadastrar";
            this.contaToolStripMenuItem.Click += new System.EventHandler(this.contaToolStripMenuItem_Click);
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.consultarToolStripMenuItem.Text = "Consultar";
            this.consultarToolStripMenuItem.Click += new System.EventHandler(this.consultarToolStripMenuItem_Click);
            // 
            // transferênciasToolStripMenuItem
            // 
            this.transferênciasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saqueToolStripMenuItem,
            this.debitoToolStripMenuItem,
            this.transferênciaToolStripMenuItem});
            this.transferênciasToolStripMenuItem.Name = "transferênciasToolStripMenuItem";
            this.transferênciasToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.transferênciasToolStripMenuItem.Text = "Transferências";
            // 
            // saqueToolStripMenuItem
            // 
            this.saqueToolStripMenuItem.Name = "saqueToolStripMenuItem";
            this.saqueToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saqueToolStripMenuItem.Text = "Saque";
            // 
            // debitoToolStripMenuItem
            // 
            this.debitoToolStripMenuItem.Name = "debitoToolStripMenuItem";
            this.debitoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.debitoToolStripMenuItem.Text = "Debito";
            // 
            // transferênciaToolStripMenuItem
            // 
            this.transferênciaToolStripMenuItem.Name = "transferênciaToolStripMenuItem";
            this.transferênciaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.transferênciaToolStripMenuItem.Text = "Transferência";
            this.transferênciaToolStripMenuItem.Click += new System.EventHandler(this.transferênciaToolStripMenuItem_Click);
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 258);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TelaPrincipal";
            this.Text = "TelaPrincipal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transferênciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem debitoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transferênciaToolStripMenuItem;
    }
}