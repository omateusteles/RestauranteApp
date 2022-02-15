using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Restaurante.Controller;
using Restaurante.DAO;
using Restaurante.Model;

namespace RestauranteApp.View
{
    public partial class MesaView : Form
    {
        public MesaView()
        {
            InitializeComponent();

            MesaDAO mesaDAO = new MesaDAO();
            dataGridView1.DataSource = mesaDAO.BuscarTodos();
        }

        private void btn_novo_Click(object sender, System.EventArgs e)
        {
            btn_editar.Enabled = false;
            btn_remover.Enabled = false;
            btn_novo.Enabled = false;
            btn_salvar.Enabled = true;
            btn_cancelar.Enabled = true;

            txt_localizacao.ReadOnly = false;

            txt_localizacao.Text = string.Empty;
        }

        private void btn_cancelar_Click(object sender, System.EventArgs e)
        {
            btn_editar.Enabled = true;
            btn_remover.Enabled = true;
            btn_novo.Enabled = true;
            btn_salvar.Enabled = false;
            btn_cancelar.Enabled = false;

            txt_localizacao.ReadOnly = true;

            txt_cd_mesa.Text = string.Empty;
            txt_localizacao.Text = string.Empty;
        }

        private void btn_salvar_Click(object sender, System.EventArgs e)
        {
            try
            {
                Mesa mesa = new Mesa();
                MesaController mesaController = new MesaController();
                MesaDAO mesaDAO = new MesaDAO();

                mesa.Cd_Mesa = !string.IsNullOrEmpty(txt_cd_mesa.Text) ? Convert.ToInt32(txt_cd_mesa.Text) : 0;
                mesa.Localizacao = txt_localizacao.Text;

                mesaController.Gravar(mesa);

                // atualizando o Grid com as alterações
                dataGridView1.DataSource = mesaDAO.BuscarTodos();

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

            txt_localizacao.ReadOnly = false;

            txt_cd_mesa.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_localizacao.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void btn_remover_Click(object sender, EventArgs e)
        {
            int Cd_Mesa;
            MesaController mesaController = new MesaController();
            MesaDAO mesaDAO = new MesaDAO();
           
            Cd_Mesa = !string.IsNullOrEmpty(dataGridView1.CurrentRow.Cells[0].Value.ToString()) ? Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()) : 0;
            
            try
            {
                mesaController.Remover(Cd_Mesa);

                // atualizando o Grid com as alterações
                dataGridView1.DataSource = mesaDAO.BuscarTodos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
