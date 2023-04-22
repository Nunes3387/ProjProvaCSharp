namespace Proj10042023
{
    partial class frmAgenda
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
            this.dgvAgenda = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgenda)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAgenda
            // 
            this.dgvAgenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgenda.Location = new System.Drawing.Point(1, 45);
            this.dgvAgenda.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvAgenda.Name = "dgvAgenda";
            this.dgvAgenda.RowHeadersWidth = 51;
            this.dgvAgenda.RowTemplate.Height = 24;
            this.dgvAgenda.Size = new System.Drawing.Size(893, 442);
            this.dgvAgenda.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(392, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Cadastros";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // frmAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 489);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvAgenda);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmAgenda";
            this.Text = "Agenda Telefonica";
            this.Load += new System.EventHandler(this.frmAgenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvAgenda;
        private System.Windows.Forms.Label label1;
    }
}

