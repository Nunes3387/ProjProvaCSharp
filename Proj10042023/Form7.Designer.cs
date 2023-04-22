namespace Proj10042023
{
    partial class Form7
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
            this.lblBonusDescricao = new System.Windows.Forms.Label();
            this.txtBonus = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(87, 188);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(81, 20);
            this.btnSalvar.TabIndex = 54;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 53;
            this.label1.Text = "Bonus";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblBonusDescricao
            // 
            this.lblBonusDescricao.AutoSize = true;
            this.lblBonusDescricao.Location = new System.Drawing.Point(20, 38);
            this.lblBonusDescricao.Name = "lblBonusDescricao";
            this.lblBonusDescricao.Size = new System.Drawing.Size(55, 13);
            this.lblBonusDescricao.TabIndex = 52;
            this.lblBonusDescricao.Text = "Descricao";
            // 
            // txtBonus
            // 
            this.txtBonus.Location = new System.Drawing.Point(23, 54);
            this.txtBonus.Name = "txtBonus";
            this.txtBonus.Size = new System.Drawing.Size(206, 20);
            this.txtBonus.TabIndex = 51;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 450);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblBonusDescricao);
            this.Controls.Add(this.txtBonus);
            this.Name = "Form7";
            this.Text = "Form7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBonusDescricao;
        private System.Windows.Forms.TextBox txtBonus;
    }
}