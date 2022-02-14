using Restaurante.Model;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Restaurante.DAO
{
    public class Refeicao_ProdutoDAO
    {
        public void Insert(Refeicao_Produto refeicao_produto)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "INSERT INTO REFEICAO_PRODUTO(CD_REFEICAO,CD_PRODUTO,QUANTIDADE_PRODUTO) VALUES(@CD_REFEICAO,@CD_PRODUTO,@QUANTIDADE_PRODUTO)";
            comando.Parameters.AddWithValue("@CD_REFEICAO", refeicao_produto.Cd_Refeicao);
            comando.Parameters.AddWithValue("@CD_PRODUTO", refeicao_produto.Cd_Produto);
            comando.Parameters.AddWithValue("@QUANTIDADE_PRODUTO", refeicao_produto.Quantidade_Produto);

            Conexao_Banco.CRUD(comando);
        }

        public void Delete(int Cd_Refeicao_Produto)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "DELETE FROM REFEICAO_PRODUTO WHERE CD_REFEICAO_PRODUTO=@CD_REFEICAO_PRODUTO";
            comando.Parameters.AddWithValue("@CD_REFEICAO_PRODUTO", Cd_Refeicao_Produto);

            Conexao_Banco.CRUD(comando);
        }

        public void Update(Refeicao_Produto refeicao_produto)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "UPDATE REFEICAO_PRODUTO SET CD_REFEICAO=@CD_REFEICAO, CD_PRODUTO=@CD_PRODUTO, QUANTIDADE_PRODUTO=@QUANTIDADE_PRODUTO WHERE CD_REFEICAO_PRODUTO=@CD_REFEICAO_PRODUTO";
            comando.Parameters.AddWithValue("@CD_REFEICAO", refeicao_produto.Cd_Refeicao);
            comando.Parameters.AddWithValue("@CD_PRODUTO", refeicao_produto.Cd_Produto);
            comando.Parameters.AddWithValue("@QUANTIDADE_PRODUTO", refeicao_produto.Quantidade_Produto);
            comando.Parameters.AddWithValue("@CD_REFEICAO_PRODUTO", refeicao_produto.Cd_Refeicao_Produto);

            Conexao_Banco.CRUD(comando);
        }

        public Refeicao_Produto BuscarPorId(int Cd_Refeicao_Produto)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM REFEICAO_PRODUTO WHERE CD_REFEICAO_PRODUTO=@CD_REFEICAO_PRODUTO";
            comando.Parameters.AddWithValue("@CD_REFEICAO_PRODUTO", Cd_Refeicao_Produto);

            SqlDataReader dr = Conexao_Banco.Selecionar(comando);

            Refeicao_Produto refeicao_produto = new Refeicao_Produto();
            if (dr.HasRows)
            {
                dr.Read();
                refeicao_produto.Cd_Produto = (int)dr["CD_PRODUTO"];
                refeicao_produto.Cd_Refeicao = (int)dr["CD_REFEICAO"];
                refeicao_produto.Cd_Refeicao_Produto = (int)dr["CD_REFEICAO_PRODUTO"];
                refeicao_produto.Quantidade_Produto = (int)dr["QUANTIDADE_PRODUTO"];
            }
            else
            {
                refeicao_produto = null;
            }
            return refeicao_produto;
        }
        public IList<Refeicao_Produto> BuscarTodos()
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM REFEICAO_PRODUTO";

            SqlDataReader dr = Conexao_Banco.Selecionar(comando);

            IList<Refeicao_Produto> refeicao_produtos = new List<Refeicao_Produto>();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Refeicao_Produto refeicao_produto = new Refeicao_Produto();

                    refeicao_produto.Cd_Produto = (int)dr["CD_PRODUTO"];
                    refeicao_produto.Cd_Refeicao = (int)dr["CD_REFEICAO"];
                    refeicao_produto.Cd_Refeicao_Produto = (int)dr["CD_REFEICAO_PRODUTO"];
                    refeicao_produto.Quantidade_Produto = (int)dr["QUANTIDADE_PRODUTO"];

                    refeicao_produtos.Add(refeicao_produto);
                }
            }
            else
            {
                refeicao_produtos = null;
            }
            return refeicao_produtos;
        }
    }
}
