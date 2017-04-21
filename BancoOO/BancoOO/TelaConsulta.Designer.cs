namespace BancoOO
{
    partial class TelaConsulta
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rbExcluir = new System.Windows.Forms.RadioButton();
            this.rbAlterar = new System.Windows.Forms.RadioButton();
            this.rbTransferencia = new System.Windows.Forms.RadioButton();
            this.rbSaqueDebito = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 129);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(545, 281);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // rbExcluir
            // 
            this.rbExcluir.AutoSize = true;
            this.rbExcluir.Location = new System.Drawing.Point(339, 78);
            this.rbExcluir.Name = "rbExcluir";
            this.rbExcluir.Size = new System.Drawing.Size(56, 17);
            this.rbExcluir.TabIndex = 2;
            this.rbExcluir.Text = "Excluir";
            this.rbExcluir.UseVisualStyleBackColor = true;
            this.rbExcluir.CheckedChanged += new System.EventHandler(this.rbExcluir_CheckedChanged);
            // 
            // rbAlterar
            // 
            this.rbAlterar.AutoSize = true;
            this.rbAlterar.Location = new System.Drawing.Point(119, 78);
            this.rbAlterar.Name = "rbAlterar";
            this.rbAlterar.Size = new System.Drawing.Size(55, 17);
            this.rbAlterar.TabIndex = 3;
            this.rbAlterar.Text = "Alterar";
            this.rbAlterar.UseVisualStyleBackColor = true;
            // 
            // rbTransferencia
            // 
            this.rbTransferencia.AutoSize = true;
            this.rbTransferencia.Location = new System.Drawing.Point(339, 28);
            this.rbTransferencia.Name = "rbTransferencia";
            this.rbTransferencia.Size = new System.Drawing.Size(90, 17);
            this.rbTransferencia.TabIndex = 4;
            this.rbTransferencia.Text = "Transferência";
            this.rbTransferencia.UseVisualStyleBackColor = true;
            // 
            // rbSaqueDebito
            // 
            this.rbSaqueDebito.AutoSize = true;
            this.rbSaqueDebito.Checked = true;
            this.rbSaqueDebito.Location = new System.Drawing.Point(119, 28);
            this.rbSaqueDebito.Name = "rbSaqueDebito";
            this.rbSaqueDebito.Size = new System.Drawing.Size(94, 17);
            this.rbSaqueDebito.TabIndex = 5;
            this.rbSaqueDebito.TabStop = true;
            this.rbSaqueDebito.Text = "Saque/Crédito";
            this.rbSaqueDebito.UseVisualStyleBackColor = true;
            // 
            // TelaConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 422);
            this.Controls.Add(this.rbSaqueDebito);
            this.Controls.Add(this.rbTransferencia);
            this.Controls.Add(this.rbAlterar);
            this.Controls.Add(this.rbExcluir);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TelaConsulta";
            this.Text = "Consulta";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton rbExcluir;
        private System.Windows.Forms.RadioButton rbAlterar;
        private System.Windows.Forms.RadioButton rbTransferencia;
        private System.Windows.Forms.RadioButton rbSaqueDebito;
    }
}

