using Restaurante.DAO;
using Restaurante.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Restaurante.Controller
{
    public class PedidoController
    {
        public void Gravar(Pedido pedido)
        {
            PedidoDAO pedidoDAO = new PedidoDAO();

            // validando regras de negócio
            if (pedido.Fk_Cd_Mesa == 0)
                throw new Exception("A Mesa precisa estar preenchida");

            if (pedidoDAO.BuscarPorPedidoAberto(pedido.Fk_Cd_Mesa) != 0)
                throw new Exception("Já existe uma conta em aberto para essa mesa");

            // se o registro já existir irá atualizar, se não existir irá inserir
            if (pedido.Cd_Pedido != 0)
            {
                pedidoDAO.Update(pedido);
            }
            else
            {
                pedidoDAO.Insert(pedido);
            }
        }

        public void Remover(int Cd_Pedido)
        {
            PedidoDAO pedidoDAO = new PedidoDAO();

            if (Cd_Pedido != 0)
            {
                if (MessageBox.Show($"Tem certeza que desja excluir o registro {Cd_Pedido}?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    pedidoDAO.Delete(Cd_Pedido);
                }
            }
        }
    }
}
