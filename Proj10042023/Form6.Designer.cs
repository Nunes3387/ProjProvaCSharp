namespace Proj10042023
{
    partial class Form6
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
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDescricaoMoeda = new System.Windows.Forms.Label();
            this.txtDescricaoMoeda = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(98, 126);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(81, 20);
            this.btnSalvar.TabIndex = 48;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Tipo Moeda";
            // 
            // lblDescricaoMoeda
            // 
            this.lblDescricaoMoeda.AutoSize = true;
            this.lblDescricaoMoeda.Location = new System.Drawing.Point(34, 49);
            this.lblDescricaoMoeda.Name = "lblDescricaoMoeda";
            this.lblDescricaoMoeda.Size = new System.Drawing.Size(55, 13);
            this.lblDescricaoMoeda.TabIndex = 44;
            this.lblDescricaoMoeda.Text = "Descricao";
            // 
            // txtDescricaoMoeda
            // 
            this.txtDescricaoMoeda.Location = new System.Drawing.Point(37, 65);
            this.txtDescricaoMoeda.Name = "txtDescricaoMoeda";
            this.txtDescricaoMoeda.Size = new System.Drawing.Size(206, 20);
            this.txtDescricaoMoeda.TabIndex = 43;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 450);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDescricaoMoeda);
            this.Controls.Add(this.txtDescricaoMoeda);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDescricaoMoeda;
        private System.Windows.Forms.TextBox txtDescricaoMoeda;
    }
}