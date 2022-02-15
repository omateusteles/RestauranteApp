using Restaurante.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Restaurante.DAO
{
    public class Pedido_RefeicaoDAO
    {
        public void Insert(Pedido_Refeicao pedido_refeicao)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "INSERT INTO PEDIDO_REFEICAO(CD_PEDIDO,CD_REFEICAO,QUANTIDADE,PRECO) VALUES(@CD_PEDIDO,@CD_REFEICAO,@QUANTIDADE,@PRECO)";
            comando.Parameters.AddWithValue("@CD_PEDIDO", pedido_refeicao.Fk_Cd_Pedido);
            comando.Parameters.AddWithValue("@CD_REFEICAO", pedido_refeicao.Fk_Cd_Refeicao);
            comando.Parameters.AddWithValue("@QUANTIDADE", pedido_refeicao.Quantidade);
            comando.Parameters.AddWithValue("@PRECO", pedido_refeicao.Preco);

            Conexao_Banco.CRUD(comando);
        }

        public void Delete(int Cd_Pedido_Refeicao)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "DELETE FROM PEDIDO_REFEICAO WHERE CD_PEDIDO_REFEICAO=@CD_PEDIDO_REFEICAO";
            comando.Parameters.AddWithValue("@CD_PEDIDO_REFEICAO", Cd_Pedido_Refeicao);

            Conexao_Banco.CRUD(comando);
        }

        public void Update(Pedido_Refeicao pedido_refeicao)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "UPDATE PEDIDO_REFEICAO SET QUANTIDADE=@QUANTIDADE,PRECO=@PRECO WHERE CD_PEDIDO_REFEICAO=@CD_PEDIDO_REFEICAO";
            comando.Parameters.AddWithValue("@QUANTIDADE", pedido_refeicao.Quantidade);
            comando.Parameters.AddWithValue("@PRECO", pedido_refeicao.Preco);
            comando.Parameters.AddWithValue("@CD_PEDIDO_REFEICAO", pedido_refeicao.Cd_Pedido_Refeicao);

            Conexao_Banco.CRUD(comando);
        }

        public Pedido_Refeicao BuscarPorId(int Cd_Pedido_Refeicao)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM PEDIDO_REFEICAO WHERE CD_PEDIDO_REFEICAO=@CD_PEDIDO_REFEICAO";
            comando.Parameters.AddWithValue("@CD_PEDIDO_REFEICAO", Cd_Pedido_Refeicao);

            SqlDataReader dr = Conexao_Banco.Selecionar(comando);

            Pedido_Refeicao pedido_refeicao = new Pedido_Refeicao();
            if (dr.HasRows)
            {
                dr.Read();
                pedido_refeicao.Cd_Pedido_Refeicao = (int)dr["CD_PEDIDO_REFEICAO"];
                pedido_refeicao.Fk_Cd_Pedido = (int)dr["CD_PEDIDO"];
                pedido_refeicao.Fk_Cd_Refeicao = (int)dr["CD_REFEICAO"];
                pedido_refeicao.Quantidade = (int)dr["QUANTIDADE"];
                pedido_refeicao.Preco = (decimal)dr["PRECO"];
            }
            else
            {
                pedido_refeicao = null;
            }
            return pedido_refeicao;
        }

        public IList<Pedido_Refeicao> BuscarTodos()
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM MESA";

            SqlDataReader dr = Conexao_Banco.Selecionar(comando);

            IList<Pedido_Refeicao> pedidos_refeicao = new List<Pedido_Refeicao>();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Pedido_Refeicao pedido_refeicao = new Pedido_Refeicao();

                    pedido_refeicao.Cd_Pedido_Refeicao = (int)dr["CD_PEDIDO_REFEICAO"];
                    pedido_refeicao.Fk_Cd_Pedido = (int)dr["CD_PEDIDO"];
                    pedido_refeicao.Fk_Cd_Refeicao = (int)dr["CD_REFEICAO"];
                    pedido_refeicao.Quantidade = (int)dr["QUANTIDADE"];
                    pedido_refeicao.Preco = (decimal)dr["PRECO"];

                    pedidos_refeicao.Add(pedido_refeicao);
                }
            }
            else
            {
                pedidos_refeicao = null;
            }
            return pedidos_refeicao;
        }
    }
}
