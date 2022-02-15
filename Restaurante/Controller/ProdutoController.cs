using Restaurante.DAO;
using Restaurante.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Restaurante.Controller
{
    public class ProdutoController
    {
        public void Gravar(Produto produto)
        {
            ProdutoDAO produtoDAO = new ProdutoDAO();

            // validando regras de negócio
            if (produto.Estoque_Atual <= 0)
                throw new Exception("O Estoque Atual precisa estar preenchido e ser maior que 0");

            if (produto.Preco_Custo <= 0)
                throw new Exception("O Preço de Custo precisa estar preenchido e ser maior que 0");

            if (string.IsNullOrEmpty(produto.Descricao))
                throw new Exception("A Descrição precisa estar preenchida");

            // se o registro já existir irá atualizar, se não existir irá inserir
            if (produto.Cd_Produto != 0)
            {
                produtoDAO.Update(produto);
            }
            else
            {
                produtoDAO.Insert(produto);
            }
        }
        public void Remover(int Cd_Produto)
        {
            ProdutoDAO produtoDAO = new ProdutoDAO();
            
            // verificando se existe registro a ser removido
            if (Cd_Produto != 0)
            {
                if (MessageBox.Show($"Tem certeza que desja excluir o registro {Cd_Produto}?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    produtoDAO.Delete(Cd_Produto);
                }
            }
        }
    }
}
