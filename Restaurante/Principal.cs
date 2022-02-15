﻿using RestauranteApp.View;
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
    }
}