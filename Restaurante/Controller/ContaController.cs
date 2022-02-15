using Restaurante.DAO;
using Restaurante.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Restaurante.Controller
{
    public class ContaController
    {
        public void Gravar(Conta conta)
        {
            ContaDAO contaDAO = new ContaDAO();
            PedidoDAO pedidoDAO = new PedidoDAO();

            // validando regras de negócio
            if (conta.Fk_Cd_Mesa == 0)
                throw new Exception("A Mesa precisa estar preenchida");

            if (pedidoDAO.BuscarPorPedidoAberto(conta.Fk_Cd_Mesa) != 0)
                throw new Exception("Já existe uma conta em aberto para essa mesa");

            if (conta.Data_Hora_Fechamento != null)
                throw new Exception("N´~ao é possível excluir uma conta já paga");

            // se o registro já existir irá atualizar, se não existir irá inserir
            if (conta.Cd_Conta != 0)
            {
                contaDAO.Update(conta);
            }
            else
            {
                contaDAO.Insert(conta);
            }
        }
        public void Remover(int Cd_Conta)
        {
            ContaDAO contaDAO = new ContaDAO();

            // verificando se existe registro a ser removido
            if (Cd_Conta != 0)
            {
                if (MessageBox.Show($"Tem certeza que desja excluir o registro {Cd_Conta}? Excluindo a conta também será excluído o pedido junto com seus itens.", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    contaDAO.Delete(Cd_Conta);
                }
            }
        }
    }
}
