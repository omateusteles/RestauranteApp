using Restaurante.Model;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Restaurante.DAO
{
    public class CaixaDAO
    {
        public void Insert(Caixa caixa)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "INSERT INTO CAIXA(VALOR_ATUAL) VALUES(@VALOR_ATUAL)";
            comando.Parameters.AddWithValue("@VALOR_ATUAL", caixa.Valor_Atual);

            Conexao_Banco.CRUD(comando);
        }

        public void Delete(int Cd_Caixa)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "DELETE FROM CAIXA WHERE CD_CAIXA=@CD_CAIXA";
            comando.Parameters.AddWithValue("@CD_CAIXA", Cd_Caixa);

            Conexao_Banco.CRUD(comando);
        }

        public void Update(Caixa caixa)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "UPDATE CAIXA SET VALOR_ATUAL=@VALOR_ATUAL WHERE CD_CAIXA=@CD_CAIXA";
            comando.Parameters.AddWithValue("@VALOR_ATUAL", caixa.Valor_Atual);
            comando.Parameters.AddWithValue("@CD_CAIXA", caixa.Cd_Caixa);

            Conexao_Banco.CRUD(comando);
        }
        public Caixa BuscarPorId(int Cd_Caixa)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM CAIXA WHERE CD_CAIXA=@CD_CAIXA";
            comando.Parameters.AddWithValue("@CD_CAIXA", Cd_Caixa);

            SqlDataReader dr = Conexao_Banco.Selecionar(comando);

            Caixa caixa = new Caixa ();
            if (dr.HasRows)
            {
                dr.Read();
                caixa.Cd_Caixa = (int)dr["CD_CAIXA"];
                caixa.Valor_Atual = (decimal)dr["VALOR_ATUAL"];
            }
            else
            {
                caixa = null;
            }
            return caixa;
        }

        public Caixa BuscarPorIdDiferente(int Cd_Caixa)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM CAIXA WHERE CD_CAIXA<>@CD_CAIXA";
            comando.Parameters.AddWithValue("@CD_CAIXA", Cd_Caixa);

            SqlDataReader dr = Conexao_Banco.Selecionar(comando);

            Caixa caixa = new Caixa();
            if (dr.HasRows)
            {
                dr.Read();
                caixa.Cd_Caixa = (int)dr["CD_CAIXA"];
                caixa.Valor_Atual = (decimal)dr["VALOR_ATUAL"];
            }
            else
            {
                caixa = null;
            }
            return caixa;
        }

        public IList<Caixa> BuscarTodos()
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM CAIXA";

            SqlDataReader dr = Conexao_Banco.Selecionar(comando);

            IList<Caixa> caixas = new List<Caixa>();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Caixa caixa = new Caixa ();

                    caixa.Cd_Caixa = (int)dr["CD_CAIXA"];
                    caixa.Valor_Atual = (decimal)dr["VALOR_ATUAL"];

                    caixas.Add(caixa);
                }
            }
            else
            {
                caixas = null;
            }
            return caixas;
        }
    }
}
