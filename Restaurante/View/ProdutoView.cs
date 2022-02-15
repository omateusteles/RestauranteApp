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
            btn_editar.Enabled = false;
            btn_remover.Enabled = false;
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
            btn_editar.Enabled = true;
            btn_remover.Enabled = true;
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
            try
            {
                Produto produto = new Produto();
                ProdutoController produtoController = new ProdutoController();
                ProdutoDAO produtoDAO = new ProdutoDAO();

                produto.Cd_Produto = !string.IsNullOrEmpty(txt_cd_produto.Text) ? Convert.ToInt32(txt_cd_produto.Text) : 0;
                produto.Descricao = txt_descricao.Text;
                produto.Preco_Custo = !string.IsNullOrEmpty(txt_preco_custo.Text) ? Convert.ToDecimal(txt_preco_custo.Text) : 0;
                produto.Estoque_Minimo = !string.IsNullOrEmpty(txt_estoque_minimo.Text) ? Convert.ToInt32(txt_estoque_minimo.Text) : 0;
                produto.Estoque_Atual = !string.IsNullOrEmpty(txt_estoque_atual.Text) ? Convert.ToInt32(txt_estoque_atual.Text) : 0;

                produtoController.Gravar(produto);

                // atualizando o Grid com as alterações
                dataGridView1.DataSource = produtoDAO.BuscarTodos();

                // voltando os formularios para o estado inicial
                btn_cancelar_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            btn_editar.Enabled = false;
            btn_remover.Enabled = false;
            btn_novo.Enabled = false;
            btn_salvar.Enabled = true;
            btn_cancelar.Enabled = true;

            txt_descricao.ReadOnly = false;
            txt_preco_custo.ReadOnly = false;
            txt_estoque_minimo.ReadOnly = false;
            txt_estoque_atual.ReadOnly = false;

            txt_cd_produto.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_descricao.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_estoque_minimo.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_estoque_atual.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_preco_custo.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void btn_remover_Click(object sender, EventArgs e)
        {
            int Cd_Produto;
            ProdutoController produtoController = new ProdutoController();
            ProdutoDAO produtoDAO = new ProdutoDAO();
           
            Cd_Produto = !string.IsNullOrEmpty(dataGridView1.CurrentRow.Cells[0].Value.ToString()) ? Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()) : 0;
            
            try
            {                
                produtoController.Remover(Cd_Produto);

                // atualizando o Grid com as alterações
                dataGridView1.DataSource = produtoDAO.BuscarTodos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
