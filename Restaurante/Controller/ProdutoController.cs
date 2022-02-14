using Restaurante.DAO;
using Restaurante.Model;
using System;
using System.Collections.Generic;

namespace Restaurante.Controller
{
    public class ProdutoController
    {
        public void Gravar(Produto produto)
        {
            ProdutoDAO produtoDAO = new ProdutoDAO();

            if (produto.Cd_Produto != 0)
            {
                produtoDAO.Update(produto);
            }
            else
            {
                produtoDAO.Insert(produto);
            }
        }
    }
}
