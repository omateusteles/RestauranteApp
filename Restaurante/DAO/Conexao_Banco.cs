using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Restaurante.DAO
{
    public class Conexao_Banco
    {
        public static SqlConnection Conectar()
        {
            try
            {
                SqlConnection conexao = new SqlConnection(Properties.Resources.stringConexao);
                conexao.Open();

                return conexao;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public static void CRUD(SqlCommand comando)
        {
            try
            {
                SqlConnection con = Conectar();
                comando.Connection = con;
                comando.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public static SqlDataReader Selecionar(SqlCommand comando)
        {
            try
            {
                SqlConnection con = Conectar();
                comando.Connection = con;
                SqlDataReader dr = comando.ExecuteReader(CommandBehavior.CloseConnection);
                return dr;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
