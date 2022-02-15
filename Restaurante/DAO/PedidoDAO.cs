using Restaurante.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Restaurante.DAO
{
    public class PedidoDAO
    {
        public void Insert(Pedido pedido)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "INSERT INTO PEDIDO(CD_MESA) VALUES(@CD_MESA)";
            comando.Parameters.AddWithValue("@CD_MESA", pedido.Fk_Cd_Mesa);

            Conexao_Banco.CRUD(comando);
        }

        public void Delete(int Cd_Pedido)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "DELETE FROM PEDIDO WHERE CD_PEDIDO=@CD_PEDIDO";
            comando.Parameters.AddWithValue("@CD_PEDIDO", Cd_Pedido);

            Conexao_Banco.CRUD(comando);
        }

        public void Update(Pedido pedido)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "UPDATE PEDIDO SET CD_MESA=@CD_MESA WHERE CD_PEDIDO=@CD_PEDIDO";
            comando.Parameters.AddWithValue("@CD_MESA", pedido.Fk_Cd_Mesa);
            comando.Parameters.AddWithValue("@CD_PEDIDO", pedido.Cd_Pedido);

            Conexao_Banco.CRUD(comando);
        }

        public Pedido BuscarPorId(int Cd_Pedido)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM PEDIDO WHERE CD_PEDIDO=@CD_PEDIDO";
            comando.Parameters.AddWithValue("@CD_PEDIDO", Cd_Pedido);

            SqlDataReader dr = Conexao_Banco.Selecionar(comando);

            Pedido pedido = new Pedido();
            if (dr.HasRows)
            {
                dr.Read();
                pedido.Cd_Pedido = (int)dr["CD_PEDIDO"];
                pedido.Fk_Cd_Mesa = (int)dr["CD_MESA"];
                pedido.Data_Hora = (DateTime)dr["DATA_HORA"];
            }
            else
            {
                pedido = null;
            }
            return pedido;
        }

        public IList<Pedido> BuscarTodos()
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM PEDIDO";

            SqlDataReader dr = Conexao_Banco.Selecionar(comando);

            IList<Pedido> pedidos = new List<Pedido>();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Pedido pedido = new Pedido();

                    pedido.Cd_Pedido = (int)dr["CD_PEDIDO"];
                    pedido.Fk_Cd_Mesa = (int)dr["CD_MESA"];
                    pedido.Data_Hora = (DateTime)dr["DATA_HORA"];

                    pedidos.Add(pedido);
                }
            }
            else
            {
                pedidos = null;
            }
            return pedidos;
        }

        //SELECT * FROM VERIFICA_CONTA_ABERTA WHERE CD_MESA = 1
        public int BuscarPorPedidoAberto(int Cd_Mesa)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT TOP 1 CD_MESA FROM VERIFICA_CONTA_ABERTA WHERE CD_MESA=@CD_MESA";
            comando.Parameters.AddWithValue("@CD_MESA", Cd_Mesa);

            SqlDataReader dr = Conexao_Banco.Selecionar(comando);

            int mesa;
            if (dr.HasRows)
            {
                dr.Read();
                mesa  = (int)dr["CD_MESA"];
            }
            else
            {
                mesa = 0;
            }
            return mesa;
        }
    }
}
