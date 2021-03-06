using RestauranteApp.View;
using System;
using System.Windows.Forms;

namespace RestauranteApp
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();

            // aumentando tamanho do Panel para ocupar a tela inteira
            panel.Height = Screen.PrimaryScreen.Bounds.Height;
            panel.Width = Screen.PrimaryScreen.Bounds.Width;
        }

        private void produtoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                ProdutoView frmProduto = new ProdutoView();

                // adicionando form ao panel
                frmProduto.TopLevel = false;
                panel.Controls.Add(frmProduto);
                frmProduto.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cadastroRefeicaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                RefeicaoView frmRefeicao = new RefeicaoView();

                // adicionando form ao panel
                frmRefeicao.TopLevel = false;
                panel.Controls.Add(frmRefeicao);
                frmRefeicao.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cadastroDeMesaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                MesaView frmMesa = new MesaView();

                // adicionando form ao panel
                frmMesa.TopLevel = false;
                panel.Controls.Add(frmMesa);
                frmMesa.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cadastrosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                PedidoView frmPedido = new PedidoView();

                // adicionando form ao panel
                frmPedido.TopLevel = false;
                panel.Controls.Add(frmPedido);
                frmPedido.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void contasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ContaView frmConta = new ContaView();

                // adicionando form ao panel
                frmConta.TopLevel = false;
                panel.Controls.Add(frmConta);
                frmConta.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void caixaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                CaixaView frmCaixa = new CaixaView();

                // adicionando form ao panel
                frmCaixa.TopLevel = false;
                panel.Controls.Add(frmCaixa);
                frmCaixa.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
