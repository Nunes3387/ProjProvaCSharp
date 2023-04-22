namespace Proj10042023
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblSaldocc = new System.Windows.Forms.Label();
            this.txtSaldoContraCorrente = new System.Windows.Forms.TextBox();
            this.lblLimitecc = new System.Windows.Forms.Label();
            this.txtLimiteContaCorrente = new System.Windows.Forms.TextBox();
            this.lblDcc = new System.Windows.Forms.Label();
            this.txtDescricaoContaCorrente = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Conta Corrente";
            // 
            // lblSaldocc
            // 
            this.lblSaldocc.AutoSize = true;
            this.lblSaldocc.Location = new System.Drawing.Point(16, 166);
            this.lblSaldocc.Name = "lblSaldocc";
            this.lblSaldocc.Size = new System.Drawing.Size(111, 13);
            this.lblSaldocc.TabIndex = 38;
            this.lblSaldocc.Text = "Saldo Contra Corrente";
            // 
            // txtSaldoContraCorrente
            // 
            this.txtSaldoContraCorrente.Location = new System.Drawing.Point(19, 182);
            this.txtSaldoContraCorrente.Name = "txtSaldoContraCorrente";
            this.txtSaldoContraCorrente.Size = new System.Drawing.Size(206, 20);
            this.txtSaldoContraCorrente.TabIndex = 37;
            // 
            // lblLimitecc
            // 
            this.lblLimitecc.AutoSize = true;
            this.lblLimitecc.Location = new System.Drawing.Point(16, 123);
            this.lblLimitecc.Name = "lblLimitecc";
            this.lblLimitecc.Size = new System.Drawing.Size(108, 13);
            this.lblLimitecc.TabIndex = 36;
            this.lblLimitecc.Text = "Limite Conta Corrente";
            // 
            // txtLimiteContaCorrente
            // 
            this.txtLimiteContaCorrente.Location = new System.Drawing.Point(19, 139);
            this.txtLimiteContaCorrente.Name = "txtLimiteContaCorrente";
            this.txtLimiteContaCorrente.Size = new System.Drawing.Size(206, 20);
            this.txtLimiteContaCorrente.TabIndex = 35;
            // 
            // lblDcc
            // 
            this.lblDcc.AutoSize = true;
            this.lblDcc.Location = new System.Drawing.Point(16, 70);
            this.lblDcc.Name = "lblDcc";
            this.lblDcc.Size = new System.Drawing.Size(129, 13);
            this.lblDcc.TabIndex = 34;
            this.lblDcc.Text = "Descricao Conta Corrente";
            // 
            // txtDescricaoContaCorrente
            // 
            this.txtDescricaoContaCorrente.Location = new System.Drawing.Point(19, 86);
            this.txtDescricaoContaCorrente.Name = "txtDescricaoContaCorrente";
            this.txtDescricaoContaCorrente.Size = new System.Drawing.Size(206, 20);
            this.txtDescricaoContaCorrente.TabIndex = 33;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(82, 223);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(81, 20);
            this.btnSalvar.TabIndex = 40;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 450);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSaldocc);
            this.Controls.Add(this.txtSaldoContraCorrente);
            this.Controls.Add(this.lblLimitecc);
            this.Controls.Add(this.txtLimiteContaCorrente);
            this.Controls.Add(this.lblDcc);
            this.Controls.Add(this.txtDescricaoContaCorrente);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSaldocc;
        private System.Windows.Forms.TextBox txtSaldoContraCorrente;
        private System.Windows.Forms.Label lblLimitecc;
        private System.Windows.Forms.TextBox txtLimiteContaCorrente;
        private System.Windows.Forms.Label lblDcc;
        private System.Windows.Forms.TextBox txtDescricaoContaCorrente;
        private System.Windows.Forms.Button btnSalvar;
    }
}