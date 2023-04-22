using Proj10042023.Controller;
using Proj10042023.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proj10042023
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void txtDcp_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQtdtempo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtJuros_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSaldoPoupanca_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Agenda agenda = new Agenda()
            {
                DescricaoContaPoupanca = txtDcp.Text,
                QtdTempoContaPoupanca = txtQtdtempo.Text,
                TaxaJuros = Convert.ToDouble(txtJuros.Text),
                SaldoContaPoupanca = Convert.ToDouble(txtSaldoPoupanca)
            };

            if (new AgendaController().Inserir(agenda))
            {
                MessageBox.Show("Registro inserido!");
            }
            else
                MessageBox.Show("Erro ao inserir registro!");
        }




        private void lblQtd_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
