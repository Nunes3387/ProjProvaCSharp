namespace Proj10042023
{
    partial class Form4
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtSegmento = new System.Windows.Forms.Label();
            this.txtDescricaodoSegmento = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Segmento";
            // 
            // txtSegmento
            // 
            this.txtSegmento.AutoSize = true;
            this.txtSegmento.Location = new System.Drawing.Point(10, 60);
            this.txtSegmento.Name = "txtSegmento";
            this.txtSegmento.Size = new System.Drawing.Size(121, 13);
            this.txtSegmento.TabIndex = 36;
            this.txtSegmento.Text = "Descricao do Segmento";
            // 
            // txtDescricaodoSegmento
            // 
            this.txtDescricaodoSegmento.Location = new System.Drawing.Point(13, 76);
            this.txtDescricaodoSegmento.Name = "txtDescricaodoSegmento";
            this.txtDescricaodoSegmento.Size = new System.Drawing.Size(206, 20);
            this.txtDescricaodoSegmento.TabIndex = 35;
            this.txtDescricaodoSegmento.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(67, 126);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(81, 20);
            this.btnSalvar.TabIndex = 38;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 450);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSegmento);
            this.Controls.Add(this.txtDescricaodoSegmento);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtSegmento;
        private System.Windows.Forms.TextBox txtDescricaodoSegmento;
        private System.Windows.Forms.Button btnSalvar;
    }
}