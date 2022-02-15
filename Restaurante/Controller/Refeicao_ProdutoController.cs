using Restaurante.DAO;
using Restaurante.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Restaurante.Controller
{
    public class Refeicao_ProdutoController
    {
        public void Gravar(Refeicao_Produto refeicao_produto)
        {
            Refeicao_ProdutoDAO refeicao_produtoDAO = new Refeicao_ProdutoDAO();
            ProdutoDAO produtoDAO = new ProdutoDAO();

            int Cd_Produto = (produtoDAO.BuscarPorId(refeicao_produto.Fk_Cd_Produto).Cd_Produto != 0) ? produtoDAO.BuscarPorId(refeicao_produto.Fk_Cd_Produto).Cd_Produto : 0;

            // validando regras de negócio
            if (refeicao_produto.Fk_Cd_Refeicao <= 0)
                throw new Exception("A Refeição precisa estar selecionada");

            if (refeicao_produto.Fk_Cd_Produto <= 0)
                throw new Exception("O Produto precisa estar preenchido");

            if (Cd_Produto == 0)
                throw new Exception("O Produto informado não existe");

            if (refeicao_produto.Quantidade_Produto <= 0)
                throw new Exception("A Quantidade precisa estar preenchida");

            // se o registro já existir irá atualizar, se não existir irá inserir
            if (refeicao_produto.Cd_Refeicao_Produto != 0)
            {
                refeicao_produtoDAO.Update(refeicao_produto);
            }
            else
            {
                refeicao_produtoDAO.Insert(refeicao_produto);
            }
        }
        public void Remover(int Cd_Refeicao_Produto)
        {
            Refeicao_ProdutoDAO refeicao_produtoDAO = new Refeicao_ProdutoDAO();

            if (Cd_Refeicao_Produto != 0)
            {
                if (MessageBox.Show($"Tem certeza que desja excluir o registro {Cd_Refeicao_Produto}?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    refeicao_produtoDAO.Delete(Cd_Refeicao_Produto);
                }
            }
        }
    }
}
