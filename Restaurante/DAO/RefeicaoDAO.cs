using Restaurante.Model;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Restaurante.DAO
{
    public class RefeicaoDAO
    {
        public void Insert(Refeicao refeicao)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "INSERT INTO REFEICAO(DESCRICAO,PRECO) VALUES(@DESCRICAO,@PRECO)";
            comando.Parameters.AddWithValue("@DESCRICAO", refeicao.Descricao);
            comando.Parameters.AddWithValue("@PRECO", refeicao.Preco);

            Conexao_Banco.CRUD(comando);
        }

        public void Delete(int Cd_Refeicao)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "DELETE FROM REFEICAO WHERE CD_REFEICAO=@CD_REFEICAO";
            comando.Parameters.AddWithValue("@CD_REFEICAO", Cd_Refeicao);

            Conexao_Banco.CRUD(comando);
        }
        public void Update(Refeicao refeicao)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "UPDATE REFEICAO SET DESCRICAO=@DESCRICAO,PRECO=@PRECO WHERE CD_REFEICAO=@CD_REFEICAO";
            comando.Parameters.AddWithValue("@DESCRICAO", refeicao.Descricao);
            comando.Parameters.AddWithValue("@PRECO", refeicao.Preco);
            comando.Parameters.AddWithValue("@CD_REFEICAO", refeicao.Cd_Refeicao);

            Conexao_Banco.CRUD(comando);
        }
        public Refeicao BuscarPorId(int Cd_Refeicao)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM REFEICAO WHERE CD_REFEICAO=@CD_REFEICAO";
            comando.Parameters.AddWithValue("@CD_REFEICAO", Cd_Refeicao);

            SqlDataReader dr = Conexao_Banco.Selecionar(comando);

            Refeicao refeicao = new Refeicao();
            if (dr.HasRows)
            {
                dr.Read();
                refeicao.Cd_Refeicao = (int)dr["CD_REFEICAO"];
                refeicao.Descricao = (string)dr["DESCRICAO"];
                refeicao.Preco = (decimal)dr["PRECO"];
            }
            else
            {
                refeicao = null;
            }
            return refeicao;
        }
        public IList<Refeicao> BuscarTodos()
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM REFEICAO";

            SqlDataReader dr = Conexao_Banco.Selecionar(comando);

            IList<Refeicao> refeicoes = new List<Refeicao>();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Refeicao refeicao = new Refeicao();

                    refeicao.Cd_Refeicao = (int)dr["CD_REFEICAO"];
                    refeicao.Descricao = (string)dr["DESCRICAO"];
                    refeicao.Preco = (decimal)dr["PRECO"];

                    refeicoes.Add(refeicao);
                }
            }
            else
            {
                refeicoes = null;
            }
            return refeicoes;
        }
    }
}
