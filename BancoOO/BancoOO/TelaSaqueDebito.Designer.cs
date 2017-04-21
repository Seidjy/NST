namespace BancoOO
{
    partial class TelaSaqueDebito
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
            this.btnEnviarr = new System.Windows.Forms.Button();
            this.lblSaldoo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtValorr = new System.Windows.Forms.TextBox();
            this.lblValorr = new System.Windows.Forms.Label();
            this.rbDebitoo = new System.Windows.Forms.RadioButton();
            this.rbSaquee = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnEnviarr
            // 
            this.btnEnviarr.Location = new System.Drawing.Point(85, 192);
            this.btnEnviarr.Name = "btnEnviarr";
            this.btnEnviarr.Size = new System.Drawing.Size(75, 23);
            this.btnEnviarr.TabIndex = 0;
            this.btnEnviarr.Text = "Enviar";
            this.btnEnviarr.UseVisualStyleBackColor = true;
            this.btnEnviarr.Click += new System.EventHandler(this.btnEnviarr_Click);
            // 
            // lblSaldoo
            // 
            this.lblSaldoo.AutoSize = true;
            this.lblSaldoo.Location = new System.Drawing.Point(44, 129);
            this.lblSaldoo.Name = "lblSaldoo";
            this.lblSaldoo.Size = new System.Drawing.Size(37, 13);
            this.lblSaldoo.TabIndex = 1;
            this.lblSaldoo.Text = "Saldo:";
            this.lblSaldoo.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // txtValorr
            // 
            this.txtValorr.Location = new System.Drawing.Point(85, 79);
            this.txtValorr.Name = "txtValorr";
            this.txtValorr.Size = new System.Drawing.Size(100, 20);
            this.txtValorr.TabIndex = 3;
            // 
            // lblValorr
            // 
            this.lblValorr.AutoSize = true;
            this.lblValorr.Location = new System.Drawing.Point(45, 82);
            this.lblValorr.Name = "lblValorr";
            this.lblValorr.Size = new System.Drawing.Size(34, 13);
            this.lblValorr.TabIndex = 4;
            this.lblValorr.Text = "Valor:";
            // 
            // rbDebitoo
            // 
            this.rbDebitoo.AutoSize = true;
            this.rbDebitoo.Location = new System.Drawing.Point(48, 33);
            this.rbDebitoo.Name = "rbDebitoo";
            this.rbDebitoo.Size = new System.Drawing.Size(56, 17);
            this.rbDebitoo.TabIndex = 5;
            this.rbDebitoo.TabStop = true;
            this.rbDebitoo.Text = "Debito";
            this.rbDebitoo.UseVisualStyleBackColor = true;
            // 
            // rbSaquee
            // 
            this.rbSaquee.AutoSize = true;
            this.rbSaquee.Location = new System.Drawing.Point(170, 33);
            this.rbSaquee.Name = "rbSaquee";
            this.rbSaquee.Size = new System.Drawing.Size(56, 17);
            this.rbSaquee.TabIndex = 6;
            this.rbSaquee.TabStop = true;
            this.rbSaquee.Text = "Saque";
            this.rbSaquee.UseVisualStyleBackColor = true;
            // 
            // TelaSaqueDebito
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.rbSaquee);
            this.Controls.Add(this.rbDebitoo);
            this.Controls.Add(this.lblValorr);
            this.Controls.Add(this.txtValorr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSaldoo);
            this.Controls.Add(this.btnEnviarr);
            this.Name = "TelaSaqueDebito";
            this.Load += new System.EventHandler(this.TelaSaqueDebito_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.RadioButton rbSaque;
        private System.Windows.Forms.RadioButton rbDebito;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label lblMostraSaldo;
        private System.Windows.Forms.Button btnEnviarr;
        private System.Windows.Forms.Label lblSaldoo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtValorr;
        private System.Windows.Forms.Label lblValorr;
        private System.Windows.Forms.RadioButton rbDebitoo;
        private System.Windows.Forms.RadioButton rbSaquee;
    }
}