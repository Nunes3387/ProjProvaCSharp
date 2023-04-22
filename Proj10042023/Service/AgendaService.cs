using Proj10042023.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Proj10042023.Service
{
    class AgendaService
    {
        //Implementar a conexao
        string strCon = @"Server=(localdb)\MSSQLLocalDB;Integrated Security=true;AttachDbFileName=D:\bancoAula\dbAgendaTurma.mdf;";
        SqlConnection conn;

        public AgendaService()
        {
            //Abertua da conexao
            conn = new SqlConnection(strCon);
            conn.Open();
        }

        public bool Inserir(Agenda agenda)
        {
            //Implementar
            //SqlCommand commandInsert = new SqlCommand(strInsert, conn);
            //using (SqlConnection connection = new SqlConnection(connectionString))

            //string strInsertCliente = $"insert into Cliente (Nome, Telefone) values ('{agenda.Nome}', '{agenda.Telefone}')";
            string strInsertCliente = "insert into Cliente (Nome, Telefone) values (@Nome, @Telefone);";
            SqlCommand commandInsertCliente = new SqlCommand(strInsertCliente, conn);
            commandInsertCliente.Parameters.Add(new SqlParameter("@Nome", agenda.Nome));
            commandInsertCliente.Parameters.Add(new SqlParameter("@Telefone", agenda.Telefone));
            commandInsertCliente.ExecuteNonQuery();

            string strInsertEndereco = "insert into Endereco (Estado, Cidade, Bairro, Numero, Rua) values (@Estado, @Cidade, @Bairro, @Numero, @Rua);";
            SqlCommand commandInsertEndereco = new SqlCommand(strInsertEndereco, conn);
            commandInsertEndereco.Parameters.Add(new SqlParameter("@Estado", agenda.Estado));
            commandInsertEndereco.Parameters.Add(new SqlParameter("@Cidade", agenda.Cidade));
            commandInsertEndereco.Parameters.Add(new SqlParameter("@Bairro", agenda.Bairro));
            commandInsertEndereco.Parameters.Add(new SqlParameter("@Numero", agenda.Numero));
            commandInsertEndereco.Parameters.Add(new SqlParameter("@Rua", agenda.Rua));
            commandInsertEndereco.ExecuteNonQuery();

            string strInsertContaPoupanca = "insert into ContaPoupanca (DescricaoContaPoupanca, QtdTempoContaPoupanca, TaxaJuros, Saldo) values (@DescricaoContaPoupanca, @QtdTempoContaPoupanca, @TaxaJuros, @SaldoContaPoupanca);";
            SqlCommand commandInsertContaPoupanca = new SqlCommand(strInsertContaPoupanca, conn);
            commandInsertContaPoupanca.Parameters.Add(new SqlParameter("@DescricaoContaPoupanca", agenda.DescricaoContaPoupanca));
            commandInsertContaPoupanca.Parameters.Add(new SqlParameter("@QtdTempoContaPoupanca", agenda.QtdTempoContaPoupanca));
            commandInsertContaPoupanca.Parameters.Add(new SqlParameter("@TaxaJuros", agenda.TaxaJuros));
            commandInsertContaPoupanca.Parameters.Add(new SqlParameter("@SaldoContaPoupanca", agenda.SaldoContaPoupanca));
            commandInsertContaPoupanca.ExecuteNonQuery();

            string strInsertContaCorrente = "insert into ContaCorrente (DescricaoContaCorrente, LimiteContaCorrente, SaldoContaCorrente) values (@DescricaoContaCorrente, @LimiteContaCorrente, @SaldoContaCorrente);";
            SqlCommand commandInsertContaCorrente = new SqlCommand(strInsertContaCorrente, conn);
            commandInsertContaCorrente.Parameters.Add(new SqlParameter("@DescricaoContaCorrente", agenda.DescricaoContaCorrente));
            commandInsertContaCorrente.Parameters.Add(new SqlParameter("@LimiteContaCorrente", agenda.LimiteContaCorrente));
            commandInsertContaCorrente.Parameters.Add(new SqlParameter("@saldoContaCorrente", agenda.SaldoContaCorrente));
            commandInsertContaCorrente.ExecuteNonQuery();

            string strInsertSegmento = "insert into Segmento (DescricaodoSegmento) values (@DescricaodoSegmento);";
            SqlCommand commandInsertSegmento = new SqlCommand(strInsertSegmento, conn);
            commandInsertSegmento.Parameters.Add(new SqlParameter("@DescricaoSegmento", agenda.DescricaodoSegmento));
            commandInsertSegmento.ExecuteNonQuery();

            string strInsertMoeda = "insert into Moeda (Descricao) values (@DescricaoMoeda);";
            SqlCommand commandInsertMoeda = new SqlCommand(strInsertMoeda, conn);
            commandInsertMoeda.Parameters.Add(new SqlParameter("@DescricaoMoeda", agenda.DescricaoMoeda));
            commandInsertMoeda.ExecuteNonQuery();

            string strInsertBonus = "insert into Bonus (Descricao) values (@DescricaoBonus);";
            SqlCommand commandInsertBonus = new SqlCommand(strInsertBonus, conn);
            commandInsertBonus.Parameters.Add(new SqlParameter("@DescricaoBonus", agenda.DescricaoBonus));
            commandInsertBonus.ExecuteNonQuery();

            conn.Close();
            return true;
        }

        public List<Agenda> TodosOsRegistros()
        {
            List<Agenda> agendas = new List<Agenda>();

            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT Id, ");
            sb.Append("       Nome, ");
            sb.Append("       Telefone, ");
            sb.Append("       Estado,   ");
            sb.Append("       Cidade,   ");
            sb.Append("       Bairro,   ");
            sb.Append("       Numero,   ");
            sb.Append("       Rua,      ");
            sb.Append("       Descricao da Conta Poupanca,");
            sb.Append("       QtdTempoContaPoupanca,");
            sb.Append("       TaxaJuros,");
            sb.Append("       SaldoContaPoupanca,");
            sb.Append("       Descricao da Conta Corrente,");
            sb.Append("       Limite da Conta Corrente,");
            sb.Append("       Saldo da Conta Corrente,");
            sb.Append("       DescricaodoSegmento,");
            sb.Append("       Descricao da Moeda,");
            sb.Append("       Descricao do Bonus,");
            sb.Append("  FROM Agenda");

           

            SqlCommand commandSelect = new SqlCommand(sb.ToString(), conn);
            SqlDataReader dr = commandSelect.ExecuteReader();

            while (dr.Read())
            {
                Agenda agenda = new Agenda();

                agenda.Id = Convert.ToInt32(dr["Id"]);
                agenda.Nome = dr["Nome"].ToString();
                agenda.Telefone = dr["Telefone"].ToString();
                agenda.Estado = dr["Estado"].ToString();
                agenda.Cidade = dr["Cidade"].ToString();
                agenda.Bairro = dr["Bairro"].ToString();
                agenda.Numero = dr["Numero"].ToString();
                agenda.Rua = dr["Rua"].ToString();
                agenda.DescricaoContaPoupanca = dr["Descricao da Conta Poupanca"].ToString();
                agenda.QtdTempoContaPoupanca = dr["Quantidade de Tempo da Conta Poupanca"].ToString();
                agenda.TaxaJuros =  Convert.ToDouble(dr["Taxa Juros"]);
                agenda.SaldoContaPoupanca = Convert.ToDouble(dr["Saldo Poupanca"]);
                agenda.DescricaoContaCorrente = dr["Descricao da Conta Corrente"].ToString();
                agenda.LimiteContaCorrente = Convert.ToDouble(dr["Limite da Conta Corrente"]);
                agenda.SaldoContaCorrente = Convert.ToDouble(dr["Saldo da Conta Corrente"]);
                agenda.DescricaodoSegmento = dr["Descricao do Segmento"].ToString();
                agenda.DescricaoMoeda = dr["Descricao da Moeda"].ToString();
                agenda.DescricaoBonus = dr["Descricao do Bonus"].ToString();


                agendas.Add(agenda);
            }
            return agendas;
        }

    }
}
