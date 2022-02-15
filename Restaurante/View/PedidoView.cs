using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Restaurante.Controller;
using Restaurante.DAO;
using Restaurante.Model;

namespace RestauranteApp.View
{
    public partial class PedidoView : Form
    {
        public PedidoView()
        {
            InitializeComponent();

            // populando o grid
            PedidoDAO pedidoDAO = new PedidoDAO();
            dataGridView1.DataSource = pedidoDAO.BuscarTodos();

            // populando o combobox
            MesaDAO mesaDAO = new MesaDAO();
            cb_mesa.DataSource = mesaDAO.BuscarTodosSomenteID();
        }

        private void btn_novo_Click(object sender, System.EventArgs e)
        {
            btn_editar.Enabled = false;
            btn_remover.Enabled = false;
            btn_novo.Enabled = false;
            btn_salvar.Enabled = true;
            btn_cancelar.Enabled = true;

            cb_mesa.Enabled = true;

            cb_mesa.Text = string.Empty;
            txt_data.Text = string.Empty;
        }

        private void btn_cancelar_Click(object sender, System.EventArgs e)
        {
            btn_editar.Enabled = true;
            btn_remover.Enabled = true;
            btn_novo.Enabled = true;
            btn_salvar.Enabled = false;
            btn_cancelar.Enabled = false;

            cb_mesa.Enabled = false;

            txt_cd_pedido.Text = string.Empty;
            cb_mesa.Text = string.Empty;
            txt_data.Text = string.Empty;
        }

        private void btn_salvar_Click(object sender, System.EventArgs e)
        {
            try
            {
                Pedido pedido = new Pedido();
                PedidoController pedidoController = new PedidoController();
                PedidoDAO pedidoDAO = new PedidoDAO();

                pedido.Cd_Pedido = !string.IsNullOrEmpty(txt_cd_pedido.Text) ? Convert.ToInt32(txt_cd_pedido.Text) : 0;
                pedido.Fk_Cd_Mesa = !string.IsNullOrEmpty(cb_mesa.Text) ? Convert.ToInt32(cb_mesa.Text) : 0;

                if (!string.IsNullOrEmpty(txt_data.Text))
                {
                    pedido.Data_Hora = Convert.ToDateTime(txt_data.Text);
                }

                pedidoController.Gravar(pedido);

                // atualizando o Grid com as alterações
                dataGridView1.DataSource = pedidoDAO.BuscarTodos();

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

            cb_mesa.Enabled = true;

            txt_cd_pedido.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            cb_mesa.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_data.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void btn_remover_Click(object sender, EventArgs e)
        {
            int Cd_Pedido;
            PedidoController pedidoController = new PedidoController();
            PedidoDAO pedidoDAO = new PedidoDAO();

            Cd_Pedido = !string.IsNullOrEmpty(dataGridView1.CurrentRow.Cells[0].Value.ToString()) ? Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()) : 0;

            try
            {
                pedidoController.Remover(Cd_Pedido);

                // atualizando o Grid com as alterações
                dataGridView1.DataSource = pedidoDAO.BuscarTodos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                Pedido_RefeicaoDAO pedido_refeicaoDAO = new Pedido_RefeicaoDAO();
                int Cd_Pedido = !string.IsNullOrEmpty(dataGridView1.CurrentRow.Cells[0].Value.ToString()) ? Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()) : 0;

                if (Cd_Pedido != 0)
                {
                    dataGridView2.DataSource = pedido_refeicaoDAO.BuscarTodosPai(Cd_Pedido);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_novo_pedido_refeicao_Click(object sender, EventArgs e)
        {
            btn_editar_pedido_refeicao.Enabled = false;
            btn_remover_pedido_refeicao.Enabled = false;
            btn_novo_pedido_refeicao.Enabled = false;
            btn_salvar_pedido_refeicao.Enabled = true;
            btn_cancelar_pedido_refeicao.Enabled = true;

            txt_cd_refeicao.ReadOnly = false;
            txt_quantidade.ReadOnly = false;
            txt_preco.ReadOnly = false;

            txt_cd_refeicao.Text = string.Empty;
            txt_quantidade.Text = string.Empty;
            txt_preco.Text = string.Empty;
        }

        private void btn_editar_pedido_refeicao_Click(object sender, EventArgs e)
        {
            btn_editar_pedido_refeicao.Enabled = false;
            btn_remover_pedido_refeicao.Enabled = false;
            btn_novo_pedido_refeicao.Enabled = false;
            btn_salvar_pedido_refeicao.Enabled = true;
            btn_cancelar_pedido_refeicao.Enabled = true;

            txt_cd_refeicao.ReadOnly = false;
            txt_quantidade.ReadOnly = false;
            txt_preco.ReadOnly = false;

            txt_pedido_refeicao.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            txt_cd_refeicao.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            txt_quantidade.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            txt_preco.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
        }

        private void btn_cancelar_pedido_refeicao_Click(object sender, EventArgs e)
        {
            btn_editar_pedido_refeicao.Enabled = true;
            btn_remover_pedido_refeicao.Enabled = true;
            btn_novo_pedido_refeicao.Enabled = true;
            btn_salvar_pedido_refeicao.Enabled = false;
            btn_cancelar_pedido_refeicao.Enabled = false;

            txt_cd_refeicao.ReadOnly = true;
            txt_quantidade.ReadOnly = true;
            txt_preco.ReadOnly = true;

            txt_pedido_refeicao.Text = string.Empty;
            txt_cd_refeicao.Text = string.Empty;
            txt_quantidade.Text = string.Empty;
            txt_preco.Text = string.Empty;
        }

        private void btn_remover_pedido_refeicao_Click(object sender, EventArgs e)
        {
            int Cd_pedido_refeicao, Cd_pedido;
            Pedido_RefeicaoController pedido_refeicaoController = new Pedido_RefeicaoController();
            Pedido_RefeicaoDAO pedido_refeicaoDAO = new Pedido_RefeicaoDAO();

            Cd_pedido_refeicao = !string.IsNullOrEmpty(dataGridView2.CurrentRow.Cells[0].Value.ToString()) ? Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value.ToString()) : 0;
            Cd_pedido = !string.IsNullOrEmpty(dataGridView1.CurrentRow.Cells[0].Value.ToString()) ? Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()) : 0;
            try
            {
                pedido_refeicaoController.Remover(Cd_pedido_refeicao);

                // atualizando o Grid com as alterações
                dataGridView2.DataSource = pedido_refeicaoDAO.BuscarTodosPai(Cd_pedido);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_salvar_pedido_refeicao_Click(object sender, EventArgs e)
        {
            try
            {
                Pedido_Refeicao pedido_refeicao = new Pedido_Refeicao();
                Pedido_RefeicaoController pedido_refeicaoController = new Pedido_RefeicaoController();
                Pedido_RefeicaoDAO pedido_refeicaoDAO = new Pedido_RefeicaoDAO();

                pedido_refeicao.Cd_Pedido_Refeicao = !string.IsNullOrEmpty(txt_pedido_refeicao.Text) ? Convert.ToInt32(txt_pedido_refeicao.Text) : 0;
                pedido_refeicao.Fk_Cd_Pedido = !string.IsNullOrEmpty(dataGridView1.CurrentRow.Cells[0].Value.ToString()) ? Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()) : 0;
                pedido_refeicao.Fk_Cd_Refeicao = !string.IsNullOrEmpty(txt_cd_refeicao.Text) ? Convert.ToInt32(txt_cd_refeicao.Text) : 0;
                pedido_refeicao.Quantidade = !string.IsNullOrEmpty(txt_quantidade.Text) ? Convert.ToInt32(txt_quantidade.Text) : 0;
                pedido_refeicao.Preco = !string.IsNullOrEmpty(txt_preco.Text) ? Convert.ToDecimal(txt_preco.Text) : 0;


                pedido_refeicaoController.Gravar(pedido_refeicao);

                // atualizando o Grid com as alterações
                dataGridView2.DataSource = pedido_refeicaoDAO.BuscarTodosPai(pedido_refeicao.Fk_Cd_Pedido);

                // voltando os formularios para o estado inicial
                btn_cancelar_pedido_refeicao_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
