using Restaurante.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Restaurante.DAO
{
    public class ContaDAO
    {
        public void Insert(Conta conta)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            //comando.CommandText = "INSERT INTO CONTA(CD_MESA,DATA_HORA_ABERTURA,DATA_HORA_FECHAMETO) VALUES(@CD_MESA,@DATA_HORA_ABERTURA,DATA_HORA_FECHAMETO)";
            comando.CommandText = "INSERT INTO CONTA(CD_MESA) VALUES(@CD_MESA)";
            comando.Parameters.AddWithValue("@CD_MESA", conta.Cd_Mesa);
            //comando.Parameters.AddWithValue("@DATA_HORA_ABERTURA", conta.Data_Hora_Abertura);
            //comando.Parameters.AddWithValue("@DATA_HORA_FECHAMETO", conta.Data_Hora_Fechamento);
            Conexao_Banco.CRUD(comando);
        }

        public void Delete(int Cd_Conta)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "DELETE FROM CONTA WHERE CD_CONTA=@CD_CONTA";
            comando.Parameters.AddWithValue("@CD_CONTA", Cd_Conta);

            Conexao_Banco.CRUD(comando);
        }

        public void Update(Conta conta)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "UPDATE CONTA SET CD_MESA=@CD_MESA,DATA_HORA_FECHAMETO=DATA_HORA_FECHAMETO WHERE CD_CONTA=@CD_CONTA";
            comando.Parameters.AddWithValue("@CD_MESA", conta.Cd_Mesa);
            comando.Parameters.AddWithValue("@DATA_HORA_FECHAMETO", conta.Data_Hora_Fechamento);
            comando.Parameters.AddWithValue("@CD_CONTA", conta.Cd_Conta);

            Conexao_Banco.CRUD(comando);
        }

        public Conta BuscarPorId(int Cd_Conta)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM CONTA WHERE CD_CONTA=@CD_CONTA";
            comando.Parameters.AddWithValue("@CD_CONTA", Cd_Conta);

            SqlDataReader dr = Conexao_Banco.Selecionar(comando);

            Conta conta = new Conta();
            if (dr.HasRows)
            {
                dr.Read();
                conta.Cd_Mesa = (int)dr["CD_MESA"];
                conta.Cd_Conta = (int)dr["CD_CONTA"];
                conta.Data_Hora_Fechamento = (DateTime)dr["DATA_HORA_FECHAMETO"];
                conta.Data_Hora_Abertura = (DateTime)dr["DATA_HORA_ABERTURA"];
            }
            else
            {
                conta = null;
            }
            return conta;
        }

        public IList<Conta> BuscarTodos()
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM CONTA";

            SqlDataReader dr = Conexao_Banco.Selecionar(comando);

            IList<Conta> contas = new List<Conta>();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Conta conta = new Conta();

                    conta.Cd_Mesa = (int)dr["CD_MESA"];
                    conta.Cd_Conta = (int)dr["CD_CONTA"];
                    conta.Data_Hora_Fechamento = (DateTime)dr["DATA_HORA_FECHAMETO"];
                    conta.Data_Hora_Abertura = (DateTime)dr["DATA_HORA_ABERTURA"];

                    contas.Add(conta);
                }
            }
            else
            {
                contas = null;
            }
            return contas;
        }
    }
}
