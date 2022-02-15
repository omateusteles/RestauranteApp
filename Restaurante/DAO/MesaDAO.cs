using Restaurante.Model;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Restaurante.DAO
{
    public class MesaDAO
    {
        public void Insert(Mesa mesa)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "INSERT INTO MESA(LOCALIZACAO) VALUES(@LOCALIZACAO)";
            comando.Parameters.AddWithValue("@LOCALIZACAO", mesa.Localizacao);

            Conexao_Banco.CRUD(comando);
        }

        public void Delete(int Cd_Mesa)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "DELETE FROM MESA WHERE CD_MESA=@CD_MESA";
            comando.Parameters.AddWithValue("@CD_MESA", Cd_Mesa);

            Conexao_Banco.CRUD(comando);
        }

        public void Update(Mesa mesa)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "UPDATE MESA SET LOCALIZACAO=@LOCALIZACAO WHERE CD_MESA=@CD_MESA";
            comando.Parameters.AddWithValue("@LOCALIZACAO", mesa.Localizacao);
            comando.Parameters.AddWithValue("@CD_MESA", mesa.Cd_Mesa);

            Conexao_Banco.CRUD(comando);
        }
        public Mesa BuscarPorId(int Cd_Mesa)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM MESA WHERE CD_MESA=@CD_MESA";
            comando.Parameters.AddWithValue("@CD_MESA", Cd_Mesa);

            SqlDataReader dr = Conexao_Banco.Selecionar(comando);

            Mesa mesa = new Mesa();
            if (dr.HasRows)
            {
                dr.Read();
                mesa.Cd_Mesa = (int)dr["CD_MESA"];
                mesa.Localizacao = (string)dr["LOCALIZACAO"];
            }
            else
            {
                mesa = null;
            }
            return mesa;
        }

        public IList<Mesa> BuscarTodos()
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM MESA";

            SqlDataReader dr = Conexao_Banco.Selecionar(comando);

            IList<Mesa> mesas = new List<Mesa>();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Mesa mesa = new Mesa();

                    mesa.Cd_Mesa = (int)dr["CD_MESA"];
                    mesa.Localizacao = (string)dr["LOCALIZACAO"];

                    mesas.Add(mesa);
                }
            }
            else
            {
                mesas = null;
            }
            return mesas;
        }

        public IList<int> BuscarTodosSomenteID()
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT CD_MESA FROM MESA";

            SqlDataReader dr = Conexao_Banco.Selecionar(comando);

            IList<int> mesas = new List<int>();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    mesas.Add((int)dr["CD_MESA"]);
                }
            }
            else
            {
                mesas = null;
            }
            return mesas;
        }
    }
}