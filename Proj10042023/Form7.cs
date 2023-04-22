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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Agenda agenda = new Agenda()
            {
                DescricaoBonus = txtBonus.Text,
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
