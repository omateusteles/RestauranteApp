using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Restaurante.Controller;
using Restaurante.DAO;
using Restaurante.Model;

namespace RestauranteApp.View
{
    public partial class CaixaView : Form
    {
        string cd_caixa, valor_atual;

        public CaixaView()
        {
            InitializeComponent();

            // populando o grid
            Caixa_ContaDAO caixa_contaDAO = new Caixa_ContaDAO();

            PopulaCaixa();
            dataGridView2.DataSource = caixa_contaDAO.BuscarTodos();

        }

        private void PopulaCaixa()
        {
            CaixaDAO caixaDAO = new CaixaDAO();
            Caixa caixa = caixaDAO.BuscarPorId(1);

            if (caixa != null)
            {
                txt_cd_caixa.Text = Convert.ToString(caixa.Cd_Caixa);
                txt_valor_atual.Text = Convert.ToString(caixa.Valor_Atual);
                cd_caixa = Convert.ToString(caixa.Cd_Caixa);
                valor_atual = Convert.ToString(caixa.Valor_Atual);
            }
        }

        private void btn_novo_Click(object sender, System.EventArgs e)
        {
            btn_editar.Enabled = false;
            btn_novo.Enabled = false;
            btn_salvar.Enabled = true;
            btn_cancelar.Enabled = true;

            txt_valor_atual.ReadOnly = false;

            txt_cd_caixa.Text = string.Empty;
            txt_valor_atual.Text = "0";
        }

        private void btn_cancelar_Click(object sender, System.EventArgs e)
        {
            btn_editar.Enabled = true;
            btn_novo.Enabled = true;
            btn_salvar.Enabled = false;
            btn_cancelar.Enabled = false;

            txt_valor_atual.ReadOnly = true;

            txt_cd_caixa.Text = cd_caixa;
            txt_valor_atual.Text = valor_atual;
        }

        private void btn_salvar_Click(object sender, System.EventArgs e)
        {
            try
            {
                Caixa caixa = new Caixa();
                CaixaController caixaController = new CaixaController();
                CaixaDAO caixaDAO = new CaixaDAO();

                caixa.Cd_Caixa = !string.IsNullOrEmpty(txt_cd_caixa.Text) ? Convert.ToInt32(txt_cd_caixa.Text) : 0;
                caixa.Valor_Atual = !string.IsNullOrEmpty(txt_valor_atual.Text) ? Convert.ToDecimal(txt_valor_atual.Text) : 0;

                caixaController.Gravar(caixa);

                // atualizando com as alterações
                PopulaCaixa();
            }
            catch (Exception ex)
            {
                txt_cd_caixa.Text = Convert.ToString(cd_caixa);
                txt_valor_atual.Text = Convert.ToString(valor_atual);
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            btn_editar.Enabled = false;
            btn_novo.Enabled = false;
            btn_salvar.Enabled = true;
            btn_cancelar.Enabled = true;

            txt_valor_atual.ReadOnly = false;
        }

        private void btn_novo_caixa_conta_Click(object sender, EventArgs e)
        {
            btn_editar_caixa_conta.Enabled = false;
            btn_remover_caixa_conta.Enabled = false;
            btn_novo_caixa_conta.Enabled = false;
            btn_salvar_caixa_conta.Enabled = true;
            btn_cancelar_caixa_conta.Enabled = true;

            txt_cd_conta.ReadOnly = false;
            txt_valor_pagamento.ReadOnly = false;
            cb_descricao_pagamento.Enabled = true;

            txt_cd_conta.Text = string.Empty;
            txt_valor_pagamento.Text = string.Empty;
            cb_descricao_pagamento.Text = string.Empty;
            txt_cd_caixa_conta.Text = string.Empty;
            txt_data_pagamento.Text = string.Empty;
        }

        private void btn_editar_caixa_conta_Click(object sender, EventArgs e)
        {
            btn_editar_caixa_conta.Enabled = false;
            btn_remover_caixa_conta.Enabled = false;
            btn_novo_caixa_conta.Enabled = false;
            btn_salvar_caixa_conta.Enabled = true;
            btn_cancelar_caixa_conta.Enabled = true;

            //txt_cd_conta.ReadOnly = false; 
            txt_valor_pagamento.ReadOnly = false;
            cb_descricao_pagamento.Enabled = true;

            txt_data_pagamento.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            txt_cd_conta.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            cb_descricao_pagamento.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            txt_valor_pagamento.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            txt_data_pagamento.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
        }

        private void btn_cancelar_caixa_conta_Click(object sender, EventArgs e)
        {
            btn_editar_caixa_conta.Enabled = true;
            btn_remover_caixa_conta.Enabled = true;
            btn_novo_caixa_conta.Enabled = true;
            btn_salvar_caixa_conta.Enabled = false;
            btn_cancelar_caixa_conta.Enabled = false;

            txt_cd_conta.ReadOnly = true;
            txt_valor_pagamento.ReadOnly = true;
            cb_descricao_pagamento.Enabled = false;

            txt_cd_conta.Text = string.Empty;
            txt_valor_pagamento.Text = string.Empty;
            cb_descricao_pagamento.Text = string.Empty;
            txt_cd_caixa_conta.Text = string.Empty;
            txt_data_pagamento.Text = string.Empty;
        }

        private void btn_remover_caixa_conta_Click(object sender, EventArgs e)
        {
            int Cd_caixa_conta;
            Caixa_ContaController caixa_contaController = new Caixa_ContaController();
            Caixa_ContaDAO caixa_contaDAO = new Caixa_ContaDAO();

            Cd_caixa_conta = !string.IsNullOrEmpty(dataGridView2.CurrentRow.Cells[0].Value.ToString()) ? Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value.ToString()) : 0;
            
            try
            {
                caixa_contaController.Remover(Cd_caixa_conta);

                // atualizando o Grid com as alterações
                PopulaCaixa();
                dataGridView2.DataSource = caixa_contaDAO.BuscarTodos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_salvar_caixa_conta_Click(object sender, EventArgs e)
        {
            try
            {
                Caixa_Conta caixa_conta = new Caixa_Conta();
                Caixa_ContaController caixa_contaController = new Caixa_ContaController();
                Caixa_ContaDAO caixa_contaDAO = new Caixa_ContaDAO();

                caixa_conta.Cd_Caixa_Conta = !string.IsNullOrEmpty(txt_cd_caixa_conta.Text) ? Convert.ToInt32(txt_cd_caixa_conta.Text) : 0;
                caixa_conta.Fk_Cd_Caixa = !string.IsNullOrEmpty(txt_cd_caixa.Text) ? Convert.ToInt32(txt_cd_caixa.Text) : 0;
                caixa_conta.Fk_Cd_Conta = !string.IsNullOrEmpty(txt_cd_conta.Text) ? Convert.ToInt32(txt_cd_conta.Text) : 0;
                caixa_conta.Descricao_Pagamento = cb_descricao_pagamento.Text;
                caixa_conta.Valor_Pagamento = !string.IsNullOrEmpty(txt_valor_pagamento.Text) ? Convert.ToDecimal(txt_valor_pagamento.Text) : 0;

                if (!string.IsNullOrEmpty(txt_data_pagamento.Text))
                    caixa_conta.Data_Hora_Pagamento = Convert.ToDateTime(txt_data_pagamento.Text);


                caixa_contaController.Gravar(caixa_conta);

                // atualizando o Grid com as alterações
                PopulaCaixa();
                dataGridView2.DataSource = caixa_contaDAO.BuscarTodos();

                // voltando os formularios para o estado inicial
                btn_cancelar_caixa_conta_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
