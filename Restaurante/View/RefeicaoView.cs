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
            RefeicaoDAO refeicaoDAO = new RefeicaoDAO();
            InitializeComponent();
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
            txt_preco.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
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
    }
}
