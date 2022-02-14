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
            comando.CommandText = "INSERT INTO PEDIDO(LOCALIZACAO,CD_MESA) VALUES(@LOCALIZACAO,@CD_MESA)";
            comando.Parameters.AddWithValue("@LOCALIZACAO", pedido.Data_Hora);
            comando.Parameters.AddWithValue("@CD_MESA", pedido.Cd_Mesa);

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
            comando.CommandText = "UPDATE PEDIDO SET DATA_HORA=@DATA_HORA WHERE CD_PEDIDO=@CD_PEDIDO";
            comando.Parameters.AddWithValue("@DATA_HORA", pedido.Data_Hora);
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
                pedido.Cd_Mesa = (int)dr["CD_MESA"];
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
            comando.CommandText = "SELECT * FROM MESA";

            SqlDataReader dr = Conexao_Banco.Selecionar(comando);

            IList<Pedido> pedidos = new List<Pedido>();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Pedido pedido = new Pedido();

                    pedido.Cd_Pedido = (int)dr["CD_PEDIDO"];
                    pedido.Cd_Mesa = (int)dr["CD_MESA"];
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
    }
}
