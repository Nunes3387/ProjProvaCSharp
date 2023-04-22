namespace Proj10042023
{
    partial class Form2
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
            this.label2 = new System.Windows.Forms.Label();
            this.lblSaldocp = new System.Windows.Forms.Label();
            this.txtSaldoPoupanca = new System.Windows.Forms.TextBox();
            this.lblTaxajuros = new System.Windows.Forms.Label();
            this.txtJuros = new System.Windows.Forms.TextBox();
            this.lblQtd = new System.Windows.Forms.Label();
            this.txtQtdtempo = new System.Windows.Forms.TextBox();
            this.lblDcp = new System.Windows.Forms.Label();
            this.txtDcp = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Conta Poupanca";
            // 
            // lblSaldocp
            // 
            this.lblSaldocp.AutoSize = true;
            this.lblSaldocp.Location = new System.Drawing.Point(11, 209);
            this.lblSaldocp.Name = "lblSaldocp";
            this.lblSaldocp.Size = new System.Drawing.Size(117, 13);
            this.lblSaldocp.TabIndex = 41;
            this.lblSaldocp.Text = "Saldo Conta Poupanca";
            // 
            // txtSaldoPoupanca
            // 
            this.txtSaldoPoupanca.Location = new System.Drawing.Point(14, 225);
            this.txtSaldoPoupanca.Name = "txtSaldoPoupanca";
            this.txtSaldoPoupanca.Size = new System.Drawing.Size(206, 20);
            this.txtSaldoPoupanca.TabIndex = 40;
            this.txtSaldoPoupanca.TextChanged += new System.EventHandler(this.txtSaldoPoupanca_TextChanged);
            // 
            // lblTaxajuros
            // 
            this.lblTaxajuros.AutoSize = true;
            this.lblTaxajuros.Location = new System.Drawing.Point(11, 156);
            this.lblTaxajuros.Name = "lblTaxajuros";
            this.lblTaxajuros.Size = new System.Drawing.Size(59, 13);
            this.lblTaxajuros.TabIndex = 39;
            this.lblTaxajuros.Text = "Taxa Juros";
            // 
            // txtJuros
            // 
            this.txtJuros.Location = new System.Drawing.Point(14, 172);
            this.txtJuros.Name = "txtJuros";
            this.txtJuros.Size = new System.Drawing.Size(206, 20);
            this.txtJuros.TabIndex = 38;
            this.txtJuros.TextChanged += new System.EventHandler(this.txtJuros_TextChanged);
            // 
            // lblQtd
            // 
            this.lblQtd.AutoSize = true;
            this.lblQtd.Location = new System.Drawing.Point(11, 113);
            this.lblQtd.Name = "lblQtd";
            this.lblQtd.Size = new System.Drawing.Size(143, 13);
            this.lblQtd.TabIndex = 37;
            this.lblQtd.Text = "Qtd Tempo Conta Poupanca";
            this.lblQtd.Click += new System.EventHandler(this.lblQtd_Click);
            // 
            // txtQtdtempo
            // 
            this.txtQtdtempo.Location = new System.Drawing.Point(14, 129);
            this.txtQtdtempo.Name = "txtQtdtempo";
            this.txtQtdtempo.Size = new System.Drawing.Size(206, 20);
            this.txtQtdtempo.TabIndex = 36;
            this.txtQtdtempo.TextChanged += new System.EventHandler(this.txtQtdtempo_TextChanged);
            // 
            // lblDcp
            // 
            this.lblDcp.AutoSize = true;
            this.lblDcp.Location = new System.Drawing.Point(11, 60);
            this.lblDcp.Name = "lblDcp";
            this.lblDcp.Size = new System.Drawing.Size(138, 13);
            this.lblDcp.TabIndex = 35;
            this.lblDcp.Text = "Descricao Conta Poupanca";
            // 
            // txtDcp
            // 
            this.txtDcp.Location = new System.Drawing.Point(14, 76);
            this.txtDcp.Name = "txtDcp";
            this.txtDcp.Size = new System.Drawing.Size(206, 20);
            this.txtDcp.TabIndex = 34;
            this.txtDcp.TextChanged += new System.EventHandler(this.txtDcp_TextChanged);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(68, 286);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(81, 20);
            this.btnSalvar.TabIndex = 43;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 450);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSaldocp);
            this.Controls.Add(this.txtSaldoPoupanca);
            this.Controls.Add(this.lblTaxajuros);
            this.Controls.Add(this.txtJuros);
            this.Controls.Add(this.lblQtd);
            this.Controls.Add(this.txtQtdtempo);
            this.Controls.Add(this.lblDcp);
            this.Controls.Add(this.txtDcp);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSaldocp;
        private System.Windows.Forms.TextBox txtSaldoPoupanca;
        private System.Windows.Forms.Label lblTaxajuros;
        private System.Windows.Forms.TextBox txtJuros;
        private System.Windows.Forms.Label lblQtd;
        private System.Windows.Forms.TextBox txtQtdtempo;
        private System.Windows.Forms.Label lblDcp;
        private System.Windows.Forms.TextBox txtDcp;
        private System.Windows.Forms.Button btnSalvar;
    }
}