using Restaurante.DAO;
using Restaurante.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Restaurante.Controller
{
    public class RefeicaoController
    {
        public void Gravar(Refeicao refeicao)
        {
            RefeicaoDAO refeicaoDAO = new RefeicaoDAO();

            // validando regras de negócio
            if (refeicao.Preco <= 0)
                throw new Exception("O Preço precisa estar preenchido e ser maior que 0");

            if (string.IsNullOrEmpty(refeicao.Descricao))
                throw new Exception("A Descrição precisa estar preenchida");

            // se o registro já existir irá atualizar, se não existir irá inserir
            if (refeicao.Cd_Refeicao != 0)
            {
                refeicaoDAO.Update(refeicao);
            }
            else
            {
                refeicaoDAO.Insert(refeicao);
            }
        }
        public void Remover(int Cd_Refeicao)
        {
            RefeicaoDAO refeicaoDAO = new RefeicaoDAO();

            if (Cd_Refeicao != 0)
            {
                if (MessageBox.Show($"Tem certeza que desja excluir o registro {Cd_Refeicao}?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    refeicaoDAO.Delete(Cd_Refeicao);
                }
            }
        }
    }
}
