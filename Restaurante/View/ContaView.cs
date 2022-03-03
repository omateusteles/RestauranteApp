using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Restaurante.Controller;
using Restaurante.DAO;
using Restaurante.Model;

namespace RestauranteApp.View
{
    public partial class ContaView : Form
    {
        public ContaView()
        {
            InitializeComponent();

            // populando o grid
            ContaDAO contaDAO = new ContaDAO();
            dataGridView1.DataSource = contaDAO.BuscarTodos();

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
            txt_cd_conta.Text = string.Empty;   
            txt_data_abertura.Text = string.Empty;
            txt_data_fechamento.Text = string.Empty;    
        }

        private void btn_cancelar_Click(object sender, System.EventArgs e)
        {
            btn_editar.Enabled = true;
            btn_remover.Enabled = true;
            btn_novo.Enabled = true;
            btn_salvar.Enabled = false;
            btn_cancelar.Enabled = false;

            cb_mesa.Enabled = false;
            txt_data_fechamento.ReadOnly = true;

            cb_mesa.Text = string.Empty;
            txt_cd_conta.Text = string.Empty;
            txt_data_abertura.Text = string.Empty;
            txt_data_fechamento.Text = string.Empty;
        }

        private void btn_salvar_Click(object sender, System.EventArgs e)
        {
            try
            {
                Conta conta = new Conta();
                ContaController contaController = new ContaController();
                ContaDAO contaDAO = new ContaDAO();

                conta.Cd_Conta = !string.IsNullOrEmpty(txt_cd_conta.Text) ? Convert.ToInt32(txt_cd_conta.Text) : 0;
                conta.Fk_Cd_Mesa = !string.IsNullOrEmpty(cb_mesa.Text) ? Convert.ToInt32(cb_mesa.Text) : 0;

                if (!string.IsNullOrEmpty(txt_data_abertura.Text))
                    conta.Data_Hora_Abertura = Convert.ToDateTime(txt_data_abertura.Text);
                
                if (!string.IsNullOrEmpty(txt_data_fechamento.Text))
                    conta.Data_Hora_Fechamento = Convert.ToDateTime(txt_data_fechamento.Text);


                contaController.Gravar(conta);

                // atualizando o Grid com as alterações
                dataGridView1.DataSource = contaDAO.BuscarTodos();

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
            txt_data_fechamento.ReadOnly = false;

            txt_cd_conta.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            cb_mesa.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_data_abertura.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            try
            {
                txt_data_fechamento.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            }
            catch (Exception ex)
            {
                txt_data_fechamento.Text = "";
            }
        }

        private void btn_remover_Click(object sender, EventArgs e)
        {
            int Cd_Conta;
            ContaController contaController = new ContaController();
            ContaDAO contaDAO = new ContaDAO();

            Cd_Conta = !string.IsNullOrEmpty(dataGridView1.CurrentRow.Cells[0].Value.ToString()) ? Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()) : 0;
            
            try
            {
                contaController.Remover(Cd_Conta);

                // atualizando o Grid com as alterações
                dataGridView1.DataSource = contaDAO.BuscarTodos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
