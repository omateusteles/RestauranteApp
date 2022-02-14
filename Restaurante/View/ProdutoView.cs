using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Restaurante.Controller;
using Restaurante.DAO;
using Restaurante.Model;

namespace RestauranteApp.View
{
    public partial class ProdutoView : Form
    {
        public ProdutoView()
        {
            ProdutoDAO produtoDAO = new ProdutoDAO();
            InitializeComponent();
            dataGridView1.DataSource = produtoDAO.BuscarTodos();
        }

        private void btn_novo_Click(object sender, System.EventArgs e)
        {
            btn_novo.Enabled = false;
            btn_salvar.Enabled = true;
            btn_cancelar.Enabled = true;

            txt_descricao.ReadOnly = false;
            txt_preco_custo.ReadOnly = false;
            txt_estoque_minimo.ReadOnly = false;
            txt_estoque_atual.ReadOnly = false;

            //txt_cd_produto.Text = "-1";
            txt_descricao.Text = string.Empty;
            txt_preco_custo.Text = string.Empty;
            txt_estoque_minimo.Text = string.Empty;
            txt_estoque_atual.Text = string.Empty;
        }

        private void btn_cancelar_Click(object sender, System.EventArgs e)
        {
            btn_novo.Enabled = true;
            btn_salvar.Enabled = false;
            btn_cancelar.Enabled = false;

            txt_descricao.ReadOnly = true;
            txt_preco_custo.ReadOnly = true;
            txt_estoque_minimo.ReadOnly = true;
            txt_estoque_atual.ReadOnly = true;

            txt_cd_produto.Text = string.Empty;
            txt_descricao.Text = string.Empty;
            txt_preco_custo.Text = string.Empty;
            txt_estoque_minimo.Text = string.Empty;
            txt_estoque_atual.Text = string.Empty;
        }

        private void btn_salvar_Click(object sender, System.EventArgs e)
        {
            Produto produto = new Produto();
            ProdutoController produtoController = new ProdutoController();
            ProdutoDAO produtoDAO = new ProdutoDAO();

            produto.Cd_Produto = !string.IsNullOrEmpty(txt_cd_produto.Text) ? Convert.ToInt32(txt_cd_produto.Text) : 0;
            produto.Descricao = txt_descricao.Text;
            produto.Preco_Custo = Convert.ToDecimal(txt_preco_custo.Text);
            produto.Estoque_Minimo = Convert.ToInt32(txt_estoque_minimo.Text);
            produto.Estoque_Atual = Convert.ToInt32(txt_estoque_atual.Text);

            produtoController.Gravar(produto);

            // atualizando o Grid com o que foi inserido
            dataGridView1.DataSource = produtoDAO.BuscarTodos();
        }
    }

}
