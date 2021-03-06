
namespace RestauranteApp
{
    partial class Principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroProdutoToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroRefeicaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeMesaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caixaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.AutoSize = true;
            this.panel.Location = new System.Drawing.Point(14, 29);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1151, 537);
            this.panel.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.vendasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1178, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroProdutoToolStripMenuItem2,
            this.cadastroRefeicaoToolStripMenuItem,
            this.cadastroDeMesaToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // cadastroProdutoToolStripMenuItem2
            // 
            this.cadastroProdutoToolStripMenuItem2.Name = "cadastroProdutoToolStripMenuItem2";
            this.cadastroProdutoToolStripMenuItem2.Size = new System.Drawing.Size(234, 26);
            this.cadastroProdutoToolStripMenuItem2.Text = "Cadastro de Produto";
            this.cadastroProdutoToolStripMenuItem2.Click += new System.EventHandler(this.produtoToolStripMenuItem1_Click);
            // 
            // cadastroRefeicaoToolStripMenuItem
            // 
            this.cadastroRefeicaoToolStripMenuItem.Name = "cadastroRefeicaoToolStripMenuItem";
            this.cadastroRefeicaoToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.cadastroRefeicaoToolStripMenuItem.Text = "Cadastro de Refeição";
            this.cadastroRefeicaoToolStripMenuItem.Click += new System.EventHandler(this.cadastroRefeicaoToolStripMenuItem_Click);
            // 
            // cadastroDeMesaToolStripMenuItem
            // 
            this.cadastroDeMesaToolStripMenuItem.Name = "cadastroDeMesaToolStripMenuItem";
            this.cadastroDeMesaToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.cadastroDeMesaToolStripMenuItem.Text = "Cadastro de Mesa";
            this.cadastroDeMesaToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeMesaToolStripMenuItem_Click);
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem1,
            this.contasToolStripMenuItem,
            this.caixaToolStripMenuItem});
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.vendasToolStripMenuItem.Text = "Vendas";
            // 
            // cadastrosToolStripMenuItem1
            // 
            this.cadastrosToolStripMenuItem1.Name = "cadastrosToolStripMenuItem1";
            this.cadastrosToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.cadastrosToolStripMenuItem1.Text = "Pedidos";
            this.cadastrosToolStripMenuItem1.Click += new System.EventHandler(this.cadastrosToolStripMenuItem1_Click);
            // 
            // contasToolStripMenuItem
            // 
            this.contasToolStripMenuItem.Name = "contasToolStripMenuItem";
            this.contasToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.contasToolStripMenuItem.Text = "Contas";
            this.contasToolStripMenuItem.Click += new System.EventHandler(this.contasToolStripMenuItem_Click);
            // 
            // caixaToolStripMenuItem
            // 
            this.caixaToolStripMenuItem.Name = "caixaToolStripMenuItem";
            this.caixaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.caixaToolStripMenuItem.Text = "Caixa";
            this.caixaToolStripMenuItem.Click += new System.EventHandler(this.caixaToolStripMenuItem_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1178, 578);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Principal";
            this.ShowIcon = false;
            this.Text = "Restaurante";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroProdutoToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cadastroRefeicaoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeMesaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caixaToolStripMenuItem;
    }
}

