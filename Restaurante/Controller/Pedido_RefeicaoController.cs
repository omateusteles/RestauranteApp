using Restaurante.DAO;
using Restaurante.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Restaurante.Controller
{
    public class Pedido_RefeicaoController
    {
        public void Gravar(Pedido_Refeicao pedido_refeicao)
        {
            Pedido_RefeicaoDAO pedido_refeicaoDAO = new Pedido_RefeicaoDAO();
            RefeicaoDAO refeicaoDAO = new RefeicaoDAO();

            int Cd_Refeicao = (refeicaoDAO.BuscarPorId(pedido_refeicao.Fk_Cd_Refeicao).Cd_Refeicao != 0) ? refeicaoDAO.BuscarPorId(pedido_refeicao.Fk_Cd_Refeicao).Cd_Refeicao : 0;

            // validando regras de negócio
            if (pedido_refeicao.Fk_Cd_Pedido <= 0)
                throw new Exception("O Pedido precisa estar selecionado");

            if (pedido_refeicao.Fk_Cd_Refeicao <= 0)
                throw new Exception("A Refeição precisa estar preenchida");

            if (Cd_Refeicao == 0)
                throw new Exception("A Refeição informada não existe");

            if (pedido_refeicao.Quantidade <= 0)
                throw new Exception("A Quantidade precisa estar preenchida");
            
            if (pedido_refeicao.Preco <= 0)
                throw new Exception("O Preço precisa estar preenchido");

            // se o registro já existir irá atualizar, se não existir irá inserir
            if (pedido_refeicao.Cd_Pedido_Refeicao != 0)
            {
                pedido_refeicaoDAO.Update(pedido_refeicao);
            }
            else
            {
                pedido_refeicaoDAO.Insert(pedido_refeicao);
            }
        }

        public void Remover(int Cd_Pedido_Refeicao)
        {
            Pedido_RefeicaoDAO pedido_refeicaoDAO = new Pedido_RefeicaoDAO();

            if (Cd_Pedido_Refeicao != 0)
            {
                if (MessageBox.Show($"Tem certeza que desja excluir o registro {Cd_Pedido_Refeicao}?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    pedido_refeicaoDAO.Delete(Cd_Pedido_Refeicao);
                }
            }
        }
    }
}
