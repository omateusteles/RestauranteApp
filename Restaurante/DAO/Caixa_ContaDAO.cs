using Restaurante.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Restaurante.DAO
{
    public class Caixa_ContaDAO
    {
        public void Insert(Caixa_Conta caixa_conta)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "INSERT INTO CAIXA_CONTA(CD_CAIXA,CD_CONTA,DESCRICAO_PAGAMENTO,VALOR_PAGAMENTO) VALUES(@CD_CAIXA,@CD_CONTA,@DESCRICAO_PAGAMENTO,@VALOR_PAGAMENTO)";
            comando.Parameters.AddWithValue("@CD_CAIXA", caixa_conta.Cd_Caixa);
            comando.Parameters.AddWithValue("@CD_CONTA", caixa_conta.Cd_Conta);
            comando.Parameters.AddWithValue("@DESCRICAO_PAGAMENTO", caixa_conta.Descricao_Pagamento);
            comando.Parameters.AddWithValue("@VALOR_PAGAMENTO", caixa_conta.Valor_Pagamento);

            Conexao_Banco.CRUD(comando);
        }

        public void Delete(int Cd_Caixa_Conta)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "DELETE FROM CAIXA_CONTA WHERE CD_CAIXA_CONTA=@CD_CAIXA_CONTA";
            comando.Parameters.AddWithValue("@CD_CAIXA_CONTA", Cd_Caixa_Conta);

            Conexao_Banco.CRUD(comando);
        }

        public void Update(Caixa_Conta caixa_conta)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "UPDATE CAIXA_CONTA SET DESCRICAO_PAGAMENTO=@DESCRICAO_PAGAMENTO,VALOR_PAGAMENTO=@VALOR_PAGAMENTO WHERE CD_CAIXA_CONTA=@CD_CAIXA_CONTA";
            comando.Parameters.AddWithValue("@DESCRICAO_PAGAMENTO", caixa_conta.Descricao_Pagamento);
            comando.Parameters.AddWithValue("@VALOR_PAGAMENTO", caixa_conta.Valor_Pagamento);
            comando.Parameters.AddWithValue("@CD_CAIXA_CONTA", caixa_conta.Cd_Caixa_Conta);

            Conexao_Banco.CRUD(comando);
        }
        public Caixa_Conta BuscarPorId(int Cd_Caixa_Conta)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM CAIXA_CONTA WHERE CD_CAIXA_CONTA=@CD_CAIXA_CONTA";
            comando.Parameters.AddWithValue("@CD_CAIXA_CONTA", Cd_Caixa_Conta);

            SqlDataReader dr = Conexao_Banco.Selecionar(comando);

            Caixa_Conta caixa_conta = new Caixa_Conta();
            if (dr.HasRows)
            {
                dr.Read();
                caixa_conta.Cd_Caixa_Conta = (int)dr["CD_CAIXA_CONTA"];
                caixa_conta.Cd_Caixa = (int)dr["CD_CAIXA"];
                caixa_conta.Cd_Conta = (int)dr["CD_CONTA"];
                caixa_conta.Valor_Pagamento = (decimal)dr["VALOR_PAGAMENTO"];
                caixa_conta.Descricao_Pagamento = (string)dr["DESCRICAO_PAGAMENTO"]; 
                caixa_conta.Data_Hora_Pagamento = (DateTime)dr["DATA_HORA_PAGAMENTO"];
            }
            else
            {
                caixa_conta = null;
            }
            return caixa_conta;
        }

        public IList<Caixa_Conta> BuscarTodos()
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM CAIXA_CONTA";

            SqlDataReader dr = Conexao_Banco.Selecionar(comando);

            IList<Caixa_Conta> caixas_conta = new List<Caixa_Conta>();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Caixa_Conta caixa_conta = new Caixa_Conta();

                    caixa_conta.Cd_Caixa_Conta = (int)dr["CD_CAIXA_CONTA"];
                    caixa_conta.Cd_Caixa = (int)dr["CD_CAIXA"];
                    caixa_conta.Cd_Conta = (int)dr["CD_CONTA"];
                    caixa_conta.Valor_Pagamento = (decimal)dr["VALOR_PAGAMENTO"];
                    caixa_conta.Descricao_Pagamento = (string)dr["DESCRICAO_PAGAMENTO"];
                    caixa_conta.Data_Hora_Pagamento = (DateTime)dr["DATA_HORA_PAGAMENTO"];

                    caixas_conta.Add(caixa_conta);
                }
            }
            else
            {
                caixas_conta = null;
            }
            return caixas_conta;
        }
    }
}
