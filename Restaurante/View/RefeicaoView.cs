using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Restaurante.Controller;
using Restaurante.DAO;
using Restaurante.Model;

namespace RestauranteApp.View
{
    public partial class RefeicaoView : Form
    {
        public RefeicaoView()
        {
            InitializeComponent();

            RefeicaoDAO refeicaoDAO = new RefeicaoDAO();
            dataGridView1.DataSource = refeicaoDAO.BuscarTodos();
        }

        private void btn_novo_Click(object sender, System.EventArgs e)
        {
            btn_editar.Enabled = false;
            btn_remover.Enabled = false;
            btn_novo.Enabled = false;
            btn_salvar.Enabled = true;
            btn_cancelar.Enabled = true;

            txt_descricao.ReadOnly = false;
            txt_preco.ReadOnly = false;

            txt_descricao.Text = string.Empty;
            txt_preco.Text = string.Empty;
        }

        private void btn_cancelar_Click(object sender, System.EventArgs e)
        {
            btn_editar.Enabled = true;
            btn_remover.Enabled = true;
            btn_novo.Enabled = true;
            btn_salvar.Enabled = false;
            btn_cancelar.Enabled = false;

            txt_descricao.ReadOnly = true;
            txt_preco.ReadOnly = true;

            txt_cd_refeicao.Text = string.Empty;
            txt_descricao.Text = string.Empty;
            txt_preco.Text = string.Empty;
        }

        private void btn_salvar_Click(object sender, System.EventArgs e)
        {
            try
            {
                Refeicao refeicao = new Refeicao();
                RefeicaoController refeicaoController = new RefeicaoController();
                RefeicaoDAO refeicaoDAO = new RefeicaoDAO();

                refeicao.Cd_Refeicao = !string.IsNullOrEmpty(txt_cd_refeicao.Text) ? Convert.ToInt32(txt_cd_refeicao.Text) : 0;
                refeicao.Descricao = txt_descricao.Text;
                refeicao.Preco = !string.IsNullOrEmpty(txt_preco.Text) ? Convert.ToDecimal(txt_preco.Text) : 0;

                refeicaoController.Gravar(refeicao);

                // atualizando o Grid com as alterações
                dataGridView1.DataSource = refeicaoDAO.BuscarTodos();

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
            txt_preco.ReadOnly = false;

            txt_cd_refeicao.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_descricao.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_preco.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void btn_remover_Click(object sender, EventArgs e)
        {
            int Cd_Refeicao;
            RefeicaoController refeicaoController = new RefeicaoController();
            RefeicaoDAO refeicaoDAO = new RefeicaoDAO();

            Cd_Refeicao = !string.IsNullOrEmpty(dataGridView1.CurrentRow.Cells[0].Value.ToString()) ? Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()) : 0;
            
            try
            {
                refeicaoController.Remover(Cd_Refeicao);

                // atualizando o Grid com as alterações
                dataGridView1.DataSource = refeicaoDAO.BuscarTodos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            Refeicao_ProdutoDAO refeicao_produtoDAO = new Refeicao_ProdutoDAO();
            int Cd_Refeicao = !string.IsNullOrEmpty(dataGridView1.CurrentRow.Cells[0].Value.ToString()) ? Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()) : 0;

            if (Cd_Refeicao != 0)
            {
                dataGridView2.DataSource = refeicao_produtoDAO.BuscarTodosPai(Cd_Refeicao);
            }
        }

        private void btn_novo_refeicao_produto_Click(object sender, EventArgs e)
        {
            btn_editar_refeicao_produto.Enabled = false;
            btn_remover_refeicao_produto.Enabled = false;
            btn_novo_refeicao_produto.Enabled = false;
            btn_salvar_refeicao_produto.Enabled = true;
            btn_cancelar_refeicao_produto.Enabled = true;

            txt_cd_produto.ReadOnly = false;
            txt_quantidade.ReadOnly = false;

            txt_cd_produto.Text = string.Empty;
            txt_quantidade.Text = string.Empty;
        }

        private void btn_editar_refeicao_produto_Click(object sender, EventArgs e)
        {
            btn_editar_refeicao_produto.Enabled = false;
            btn_remover_refeicao_produto.Enabled = false;
            btn_novo_refeicao_produto.Enabled = false;
            btn_salvar_refeicao_produto.Enabled = true;
            btn_cancelar_refeicao_produto.Enabled = true;

            txt_cd_produto.ReadOnly = false;
            txt_quantidade.ReadOnly = false;

            txt_cd_refeicao_produto.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            txt_cd_produto.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            txt_quantidade.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
        }

        private void btn_cancelar_refeicao_produto_Click(object sender, EventArgs e)
        {
            btn_editar_refeicao_produto.Enabled = true;
            btn_remover_refeicao_produto.Enabled = true;
            btn_novo_refeicao_produto.Enabled = true;
            btn_salvar_refeicao_produto.Enabled = false;
            btn_cancelar_refeicao_produto.Enabled = false;

            txt_cd_produto.ReadOnly = true;
            txt_quantidade.ReadOnly = true;

            txt_cd_refeicao_produto.Text = string.Empty;
            txt_cd_produto.Text = string.Empty;
            txt_quantidade.Text = string.Empty;
        }

        private void btn_remover_refeicao_produto_Click(object sender, EventArgs e)
        {
            int Cd_Refeicao_Produto;
            Refeicao_ProdutoController refeicao_produtoController = new Refeicao_ProdutoController();
            Refeicao_ProdutoDAO refeicao_produtoDAO = new Refeicao_ProdutoDAO();

            Cd_Refeicao_Produto = !string.IsNullOrEmpty(dataGridView2.CurrentRow.Cells[0].Value.ToString()) ? Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value.ToString()) : 0;

            try
            {
                refeicao_produtoController.Remover(Cd_Refeicao_Produto);

                // atualizando o Grid com as alterações
                dataGridView2.DataSource = refeicao_produtoDAO.BuscarTodosPai(Cd_Refeicao_Produto);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_salvar_refeicao_produto_Click(object sender, EventArgs e)
        {
            try
            {
                Refeicao_Produto refeicao_produto = new Refeicao_Produto();
                Refeicao_ProdutoController refeicao_produtoController = new Refeicao_ProdutoController();
                Refeicao_ProdutoDAO refeicao_produtoDAO = new Refeicao_ProdutoDAO();

                refeicao_produto.Cd_Refeicao_Produto = !string.IsNullOrEmpty(txt_cd_refeicao_produto.Text) ? Convert.ToInt32(txt_cd_refeicao_produto.Text) : 0;
                refeicao_produto.Fk_Cd_Refeicao = !string.IsNullOrEmpty(dataGridView1.CurrentRow.Cells[0].Value.ToString()) ? Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()) : 0;
                refeicao_produto.Fk_Cd_Produto = !string.IsNullOrEmpty(txt_cd_produto.Text) ? Convert.ToInt32(txt_cd_produto.Text) : 0;
                refeicao_produto.Quantidade_Produto = !string.IsNullOrEmpty(txt_quantidade.Text) ? Convert.ToInt32(txt_quantidade.Text) : 0;

                refeicao_produtoController.Gravar(refeicao_produto);

                // atualizando o Grid com as alterações
                dataGridView2.DataSource = refeicao_produtoDAO.BuscarTodosPai(refeicao_produto.Fk_Cd_Refeicao);

                // voltando os formularios para o estado inicial
                btn_cancelar_refeicao_produto_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
