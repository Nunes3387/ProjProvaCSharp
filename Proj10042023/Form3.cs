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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Agenda agenda = new Agenda()
            {
                DescricaoContaCorrente = txtDescricaoContaCorrente.Text,
                LimiteContaCorrente = Convert.ToInt16(txtLimiteContaCorrente.Text),
                SaldoContraCorrente = Convert.ToDouble(txtSaldoContraCorrente.Text),
            };

            if (new AgendaController().Inserir(agenda))
            {
                MessageBox.Show("Registro inserido!");
                
            }
            else
                MessageBox.Show("Erro ao inserir registro!");
        }
    }
    }

