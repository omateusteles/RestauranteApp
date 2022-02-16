using Restaurante.DAO;
using Restaurante.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Restaurante.Controller
{
    public class Caixa_ContaController
    {
        public void Gravar(Caixa_Conta caixa_conta)
        {
            Caixa_ContaDAO caixa_contaDAO = new Caixa_ContaDAO();
            ContaDAO contaDAO = new ContaDAO();

            int Cd_Conta = (contaDAO.BuscarPorId(caixa_conta.Fk_Cd_Conta) != null) ? contaDAO.BuscarPorId(caixa_conta.Fk_Cd_Conta).Cd_Conta : 0;

            // validando regras de negócio
            if (caixa_conta.Fk_Cd_Caixa == 0)
                throw new Exception("O Caixa precisa estar criado");

            if (caixa_conta.Fk_Cd_Conta == 0)
                throw new Exception("A Conta precisa estar preenchida");

            if (Cd_Conta == 0)
                throw new Exception("A Conta informada não existe");

            if (caixa_conta.Valor_Pagamento <= 0)
                throw new Exception("O Valor de Pagamento precisa estar preenchido");
            
            if (string.IsNullOrEmpty(caixa_conta.Descricao_Pagamento))
                throw new Exception("A Forma de Pagamento precisa estar preenchida");

            // se o registro já existir irá atualizar, se não existir irá inserir
            if (caixa_conta.Cd_Caixa_Conta != 0)
            {
                caixa_contaDAO.Update(caixa_conta);
            }
            else
            {
                caixa_contaDAO.Insert(caixa_conta);
            }
        }

        public void Remover(int Cd_Caixa_Conta)
        {
            Caixa_ContaDAO caixa_contaDAO = new Caixa_ContaDAO();

            if (Cd_Caixa_Conta != 0)
            {
                if (MessageBox.Show($"Tem certeza que desja excluir o registro {Cd_Caixa_Conta}? O Valor Atual do Caixa será atualizado", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    caixa_contaDAO.Delete(Cd_Caixa_Conta);
                }
            }
        }
    }
}
