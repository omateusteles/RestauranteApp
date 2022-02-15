using Restaurante.Model;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Restaurante.DAO
{
    public class ProdutoDAO
    {
        public void Insert(Produto produto)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "INSERT INTO PRODUTO(DESCRICAO,ESTOQUE_MINIMO,ESTOQUE_ATUAL,PRECO_CUSTO) VALUES(@DESCRICAO,@ESTOQUE_MINIMO,@ESTOQUE_ATUAL,@PRECO_CUSTO)";
            comando.Parameters.AddWithValue("@DESCRICAO", produto.Descricao);
            comando.Parameters.AddWithValue("@ESTOQUE_MINIMO", produto.Estoque_Minimo);
            comando.Parameters.AddWithValue("@ESTOQUE_ATUAL", produto.Estoque_Atual);
            comando.Parameters.AddWithValue("@PRECO_CUSTO", produto.Preco_Custo);

            Conexao_Banco.CRUD(comando);
        }

        public void Delete(int Cd_Produto)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "DELETE FROM PRODUTO WHERE CD_PRODUTO=@CD_PRODUTO";
            comando.Parameters.AddWithValue("@CD_PRODUTO", Cd_Produto);

            Conexao_Banco.CRUD(comando);
        }

        public void Update(Produto produto)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "UPDATE PRODUTO SET DESCRICAO=@DESCRICAO, ESTOQUE_MINIMO=@ESTOQUE_MINIMO, ESTOQUE_ATUAL=@ESTOQUE_ATUAL,PRECO_CUSTO=@PRECO_CUSTO WHERE CD_PRODUTO=@CD_PRODUTO";
            comando.Parameters.AddWithValue("@DESCRICAO", produto.Descricao);
            comando.Parameters.AddWithValue("@ESTOQUE_MINIMO", produto.Estoque_Minimo);
            comando.Parameters.AddWithValue("@ESTOQUE_ATUAL", produto.Estoque_Atual);
            comando.Parameters.AddWithValue("@PRECO_CUSTO", produto.Preco_Custo);
            comando.Parameters.AddWithValue("@CD_PRODUTO", produto.Cd_Produto);

            Conexao_Banco.CRUD(comando);
        }

        public Produto BuscarPorId(int Cd_Produto)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM PRODUTO WHERE CD_PRODUTO=@CD_PRODUTO";
            comando.Parameters.AddWithValue("@CD_PRODUTO", Cd_Produto);

            SqlDataReader dr = Conexao_Banco.Selecionar(comando);

            Produto produto = new Produto();    
            if (dr.HasRows)
            {
                dr.Read();
                produto.Cd_Produto = (int)dr["CD_PRODUTO"];
                produto.Descricao = (string)dr["DESCRICAO"];
                produto.Estoque_Minimo = (int)dr["ESTOQUE_MINIMO"];
                produto.Estoque_Atual = (int)dr["ESTOQUE_ATUAL"];
                produto.Preco_Custo = (decimal)dr["PRECO_CUSTO"];
            }
            else
            {
                produto = null;
            }
            return produto;
        }

        public IList<Produto> BuscarTodos()
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM PRODUTO";

            SqlDataReader dr = Conexao_Banco.Selecionar(comando);

            IList<Produto> produtos = new List<Produto>();
            
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Produto produto = new Produto();

                    produto.Cd_Produto = (int)dr["CD_PRODUTO"];
                    produto.Descricao = (string)dr["DESCRICAO"];
                    produto.Estoque_Minimo = (int)dr["ESTOQUE_MINIMO"];
                    produto.Estoque_Atual = (int)dr["ESTOQUE_ATUAL"];
                    produto.Preco_Custo = (decimal)dr["PRECO_CUSTO"];

                    produtos.Add(produto);
                }
            }
            else
            {
                produtos = null;
            }
            return produtos;
        }

    }
}
