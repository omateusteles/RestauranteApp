
namespace RestauranteApp.View
{
    partial class RefeicaoView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gb_refeicao = new System.Windows.Forms.GroupBox();
            this.btn_remover = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_cd_refeicao = new System.Windows.Forms.TextBox();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_novo = new System.Windows.Forms.Button();
            this.lbl_preco = new System.Windows.Forms.Label();
            this.txt_preco = new System.Windows.Forms.TextBox();
            this.lbl_descricao = new System.Windows.Forms.Label();
            this.txt_descricao = new System.Windows.Forms.TextBox();
            this.lbl_cd_refeicao = new System.Windows.Forms.Label();
            this.gb_produto_refeicao = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.txt_codigo_produto = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.lbl_quantidade = new System.Windows.Forms.Label();
            this.txt_quantidade = new System.Windows.Forms.TextBox();
            this.lbl_codigo_produto = new System.Windows.Forms.Label();
            this.CD_PRODUTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUANTIDADE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CD_REFEICAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRICAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gb_refeicao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gb_produto_refeicao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_refeicao
            // 
            this.gb_refeicao.Controls.Add(this.btn_remover);
            this.gb_refeicao.Controls.Add(this.btn_editar);
            this.gb_refeicao.Controls.Add(this.dataGridView1);
            this.gb_refeicao.Controls.Add(this.txt_cd_refeicao);
            this.gb_refeicao.Controls.Add(this.btn_cancelar);
            this.gb_refeicao.Controls.Add(this.btn_salvar);
            this.gb_refeicao.Controls.Add(this.btn_novo);
            this.gb_refeicao.Controls.Add(this.lbl_preco);
            this.gb_refeicao.Controls.Add(this.txt_preco);
            this.gb_refeicao.Controls.Add(this.lbl_descricao);
            this.gb_refeicao.Controls.Add(this.txt_descricao);
            this.gb_refeicao.Controls.Add(this.lbl_cd_refeicao);
            this.gb_refeicao.Location = new System.Drawing.Point(12, 12);
            this.gb_refeicao.Name = "gb_refeicao";
            this.gb_refeicao.Size = new System.Drawing.Size(468, 494);
            this.gb_refeicao.TabIndex = 0;
            this.gb_refeicao.TabStop = false;
            this.gb_refeicao.Text = "Refeição";
            // 
            // btn_remover
            // 
            this.btn_remover.Location = new System.Drawing.Point(332, 373);
            this.btn_remover.Name = "btn_remover";
            this.btn_remover.Size = new System.Drawing.Size(86, 32);
            this.btn_remover.TabIndex = 35;
            this.btn_remover.Text = "Remover";
            this.btn_remover.UseVisualStyleBackColor = true;
            this.btn_remover.Click += new System.EventHandler(this.btn_remover_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(189, 373);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(86, 32);
            this.btn_editar.TabIndex = 34;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CD_REFEICAO,
            this.DESCRICAO,
            this.PRECO});
            this.dataGridView1.Location = new System.Drawing.Point(51, 136);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(367, 214);
            this.dataGridView1.TabIndex = 33;
            // 
            // txt_cd_refeicao
            // 
            this.txt_cd_refeicao.Location = new System.Drawing.Point(173, 18);
            this.txt_cd_refeicao.Name = "txt_cd_refeicao";
            this.txt_cd_refeicao.ReadOnly = true;
            this.txt_cd_refeicao.Size = new System.Drawing.Size(114, 22);
            this.txt_cd_refeicao.TabIndex = 20;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Enabled = false;
            this.btn_cancelar.Location = new System.Drawing.Point(332, 429);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(86, 32);
            this.btn_cancelar.TabIndex = 32;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.Enabled = false;
            this.btn_salvar.Location = new System.Drawing.Point(51, 438);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(86, 32);
            this.btn_salvar.TabIndex = 31;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // btn_novo
            // 
            this.btn_novo.Location = new System.Drawing.Point(51, 373);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(86, 32);
            this.btn_novo.TabIndex = 30;
            this.btn_novo.Text = "Novo";
            this.btn_novo.UseVisualStyleBackColor = true;
            this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
            // 
            // lbl_preco
            // 
            this.lbl_preco.AutoSize = true;
            this.lbl_preco.Location = new System.Drawing.Point(99, 85);
            this.lbl_preco.Name = "lbl_preco";
            this.lbl_preco.Size = new System.Drawing.Size(51, 16);
            this.lbl_preco.TabIndex = 28;
            this.lbl_preco.Text = "Preço*:";
            // 
            // txt_preco
            // 
            this.txt_preco.Location = new System.Drawing.Point(173, 79);
            this.txt_preco.Name = "txt_preco";
            this.txt_preco.ReadOnly = true;
            this.txt_preco.Size = new System.Drawing.Size(114, 22);
            this.txt_preco.TabIndex = 22;
            // 
            // lbl_descricao
            // 
            this.lbl_descricao.AutoSize = true;
            this.lbl_descricao.Location = new System.Drawing.Point(78, 52);
            this.lbl_descricao.Name = "lbl_descricao";
            this.lbl_descricao.Size = new System.Drawing.Size(77, 16);
            this.lbl_descricao.TabIndex = 26;
            this.lbl_descricao.Text = "Descrição*:";
            // 
            // txt_descricao
            // 
            this.txt_descricao.Location = new System.Drawing.Point(173, 49);
            this.txt_descricao.Name = "txt_descricao";
            this.txt_descricao.ReadOnly = true;
            this.txt_descricao.Size = new System.Drawing.Size(114, 22);
            this.txt_descricao.TabIndex = 21;
            // 
            // lbl_cd_refeicao
            // 
            this.lbl_cd_refeicao.AutoSize = true;
            this.lbl_cd_refeicao.Location = new System.Drawing.Point(99, 21);
            this.lbl_cd_refeicao.Name = "lbl_cd_refeicao";
            this.lbl_cd_refeicao.Size = new System.Drawing.Size(59, 16);
            this.lbl_cd_refeicao.TabIndex = 24;
            this.lbl_cd_refeicao.Text = "Código*:";
            // 
            // gb_produto_refeicao
            // 
            this.gb_produto_refeicao.Controls.Add(this.button1);
            this.gb_produto_refeicao.Controls.Add(this.button2);
            this.gb_produto_refeicao.Controls.Add(this.dataGridView2);
            this.gb_produto_refeicao.Controls.Add(this.txt_codigo_produto);
            this.gb_produto_refeicao.Controls.Add(this.button3);
            this.gb_produto_refeicao.Controls.Add(this.button4);
            this.gb_produto_refeicao.Controls.Add(this.button5);
            this.gb_produto_refeicao.Controls.Add(this.lbl_quantidade);
            this.gb_produto_refeicao.Controls.Add(this.txt_quantidade);
            this.gb_produto_refeicao.Controls.Add(this.lbl_codigo_produto);
            this.gb_produto_refeicao.Location = new System.Drawing.Point(517, 12);
            this.gb_produto_refeicao.Name = "gb_produto_refeicao";
            this.gb_produto_refeicao.Size = new System.Drawing.Size(468, 494);
            this.gb_produto_refeicao.TabIndex = 36;
            this.gb_produto_refeicao.TabStop = false;
            this.gb_produto_refeicao.Text = "Produtos da Refeição";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(332, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 32);
            this.button1.TabIndex = 35;
            this.button1.Text = "Remover";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(189, 373);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 32);
            this.button2.TabIndex = 34;
            this.button2.Text = "Editar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CD_PRODUTO,
            this.QUANTIDADE});
            this.dataGridView2.Location = new System.Drawing.Point(51, 136);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(367, 214);
            this.dataGridView2.TabIndex = 33;
            // 
            // txt_codigo_produto
            // 
            this.txt_codigo_produto.Location = new System.Drawing.Point(173, 18);
            this.txt_codigo_produto.Name = "txt_codigo_produto";
            this.txt_codigo_produto.ReadOnly = true;
            this.txt_codigo_produto.Size = new System.Drawing.Size(114, 22);
            this.txt_codigo_produto.TabIndex = 20;
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(332, 429);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 32);
            this.button3.TabIndex = 32;
            this.button3.Text = "Cancelar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(51, 438);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(86, 32);
            this.button4.TabIndex = 31;
            this.button4.Text = "Salvar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(51, 373);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(86, 32);
            this.button5.TabIndex = 30;
            this.button5.Text = "Novo";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // lbl_quantidade
            // 
            this.lbl_quantidade.AutoSize = true;
            this.lbl_quantidade.Location = new System.Drawing.Point(73, 58);
            this.lbl_quantidade.Name = "lbl_quantidade";
            this.lbl_quantidade.Size = new System.Drawing.Size(85, 16);
            this.lbl_quantidade.TabIndex = 28;
            this.lbl_quantidade.Text = "Quantidade*:";
            // 
            // txt_quantidade
            // 
            this.txt_quantidade.Location = new System.Drawing.Point(173, 52);
            this.txt_quantidade.Name = "txt_quantidade";
            this.txt_quantidade.ReadOnly = true;
            this.txt_quantidade.Size = new System.Drawing.Size(114, 22);
            this.txt_quantidade.TabIndex = 22;
            // 
            // lbl_codigo_produto
            // 
            this.lbl_codigo_produto.AutoSize = true;
            this.lbl_codigo_produto.Location = new System.Drawing.Point(99, 21);
            this.lbl_codigo_produto.Name = "lbl_codigo_produto";
            this.lbl_codigo_produto.Size = new System.Drawing.Size(59, 16);
            this.lbl_codigo_produto.TabIndex = 24;
            this.lbl_codigo_produto.Text = "Código*:";
            // 
            // CD_PRODUTO
            // 
            this.CD_PRODUTO.DataPropertyName = "CD_PRODUTO";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.CD_PRODUTO.DefaultCellStyle = dataGridViewCellStyle3;
            this.CD_PRODUTO.HeaderText = "Código";
            this.CD_PRODUTO.MinimumWidth = 6;
            this.CD_PRODUTO.Name = "CD_PRODUTO";
            this.CD_PRODUTO.ReadOnly = true;
            this.CD_PRODUTO.Width = 90;
            // 
            // QUANTIDADE
            // 
            this.QUANTIDADE.DataPropertyName = "QUANTIDADE";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.QUANTIDADE.DefaultCellStyle = dataGridViewCellStyle4;
            this.QUANTIDADE.HeaderText = "Quantidade";
            this.QUANTIDADE.MinimumWidth = 6;
            this.QUANTIDADE.Name = "QUANTIDADE";
            this.QUANTIDADE.ReadOnly = true;
            this.QUANTIDADE.Width = 90;
            // 
            // CD_REFEICAO
            // 
            this.CD_REFEICAO.DataPropertyName = "CD_REFEICAO";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.CD_REFEICAO.DefaultCellStyle = dataGridViewCellStyle1;
            this.CD_REFEICAO.HeaderText = "Código";
            this.CD_REFEICAO.MinimumWidth = 6;
            this.CD_REFEICAO.Name = "CD_REFEICAO";
            this.CD_REFEICAO.ReadOnly = true;
            this.CD_REFEICAO.Width = 70;
            // 
            // DESCRICAO
            // 
            this.DESCRICAO.DataPropertyName = "DESCRICAO";
            this.DESCRICAO.HeaderText = "Descrição";
            this.DESCRICAO.MinimumWidth = 6;
            this.DESCRICAO.Name = "DESCRICAO";
            this.DESCRICAO.ReadOnly = true;
            // 
            // PRECO
            // 
            this.PRECO.DataPropertyName = "PRECO";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            this.PRECO.DefaultCellStyle = dataGridViewCellStyle2;
            this.PRECO.HeaderText = "Preço";
            this.PRECO.MinimumWidth = 6;
            this.PRECO.Name = "PRECO";
            this.PRECO.ReadOnly = true;
            this.PRECO.Width = 70;
            // 
            // RefeicaoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1005, 518);
            this.Controls.Add(this.gb_produto_refeicao);
            this.Controls.Add(this.gb_refeicao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "RefeicaoView";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Refeição";
            this.gb_refeicao.ResumeLayout(false);
            this.gb_refeicao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gb_produto_refeicao.ResumeLayout(false);
            this.gb_produto_refeicao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn cDPRODUTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRICAODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRECOCUSTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eSTOQUEMINIMODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eSTOQUEATUALDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox gb_refeicao;
        private System.Windows.Forms.Button btn_remover;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_cd_refeicao;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.Label lbl_preco;
        private System.Windows.Forms.TextBox txt_preco;
        private System.Windows.Forms.Label lbl_descricao;
        private System.Windows.Forms.TextBox txt_descricao;
        private System.Windows.Forms.Label lbl_cd_refeicao;
        private System.Windows.Forms.GroupBox gb_produto_refeicao;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CD_PRODUTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn QUANTIDADE;
        private System.Windows.Forms.TextBox txt_codigo_produto;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label lbl_quantidade;
        private System.Windows.Forms.TextBox txt_quantidade;
        private System.Windows.Forms.Label lbl_codigo_produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CD_REFEICAO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRICAO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECO;
    }
}