namespace BancoOO
{
    partial class TelaCadastro
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
            this.lblAgencia = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtAgencia = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.rbCorrente = new System.Windows.Forms.RadioButton();
            this.rbPoupanca = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lblAgencia
            // 
            this.lblAgencia.AutoSize = true;
            this.lblAgencia.Location = new System.Drawing.Point(12, 23);
            this.lblAgencia.Name = "lblAgencia";
            this.lblAgencia.Size = new System.Drawing.Size(46, 13);
            this.lblAgencia.TabIndex = 0;
            this.lblAgencia.Text = "Agencia";
            this.lblAgencia.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(93, 186);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 4;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtAgencia
            // 
            this.txtAgencia.Location = new System.Drawing.Point(67, 18);
            this.txtAgencia.Name = "txtAgencia";
            this.txtAgencia.Size = new System.Drawing.Size(101, 20);
            this.txtAgencia.TabIndex = 5;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(68, 48);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 6;
            // 
            // rbCorrente
            // 
            this.rbCorrente.AutoSize = true;
            this.rbCorrente.Checked = true;
            this.rbCorrente.Location = new System.Drawing.Point(67, 78);
            this.rbCorrente.Name = "rbCorrente";
            this.rbCorrente.Size = new System.Drawing.Size(65, 17);
            this.rbCorrente.TabIndex = 7;
            this.rbCorrente.TabStop = true;
            this.rbCorrente.Text = "Corrente";
            this.rbCorrente.UseVisualStyleBackColor = true;
            // 
            // rbPoupanca
            // 
            this.rbPoupanca.AutoSize = true;
            this.rbPoupanca.Location = new System.Drawing.Point(160, 78);
            this.rbPoupanca.Name = "rbPoupanca";
            this.rbPoupanca.Size = new System.Drawing.Size(74, 17);
            this.rbPoupanca.TabIndex = 8;
            this.rbPoupanca.Text = "Poupança";
            this.rbPoupanca.UseVisualStyleBackColor = true;
            // 
            // TelaCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.rbPoupanca);
            this.Controls.Add(this.rbCorrente);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtAgencia);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblAgencia);
            this.Name = "TelaCadastro";
            this.Text = "TelaCadastro";
            this.Load += new System.EventHandler(this.TelaCadastro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAgencia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtAgencia;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.RadioButton rbCorrente;
        private System.Windows.Forms.RadioButton rbPoupanca;
    }
}