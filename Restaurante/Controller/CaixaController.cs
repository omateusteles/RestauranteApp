using Restaurante.DAO;
using Restaurante.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Restaurante.Controller
{
    public class CaixaController
    {
        public void Gravar(Caixa caixa)
        {
            CaixaDAO caixaDAO = new CaixaDAO();

            // validando regras de negócio
            //if (caixa.Valor_Atual == 0)
            //    throw new Exception("A Mesa precisa estar preenchida");

            // se o registro já existir irá atualizar, se não existir irá inserir
            if (caixa.Cd_Caixa != 0)
            {
                caixaDAO.Update(caixa);
            }
            else
            {
                if (caixaDAO.BuscarPorIdDiferente(caixa.Cd_Caixa) == null)
                {
                    caixaDAO.Insert(caixa);
                }
                else
                {
                    throw new Exception("Só é possível existir um caixa");
                }
            }
        }
        public void Remover(int Cd_Caixa)
        {
            CaixaDAO caixaDAO = new CaixaDAO();

            // verificando se existe registro a ser removido
            if (Cd_Caixa != 0)
            {
                if (MessageBox.Show($"Tem certeza que desja excluir o registro {Cd_Caixa}? Excluindo a conta também será excluído o pedido junto com seus itens.", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    caixaDAO.Delete(Cd_Caixa);
                }
            }
        }
    }
}
