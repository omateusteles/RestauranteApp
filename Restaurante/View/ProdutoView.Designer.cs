
namespace RestauranteApp.View
{
    partial class ProdutoView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_cd_produto = new System.Windows.Forms.Label();
            this.lbl_descricao = new System.Windows.Forms.Label();
            this.txt_descricao = new System.Windows.Forms.TextBox();
            this.lbl_estoque_atual = new System.Windows.Forms.Label();
            this.txt_preco_custo = new System.Windows.Forms.TextBox();
            this.lbl_preco_custo = new System.Windows.Forms.Label();
            this.txt_estoque_atual = new System.Windows.Forms.TextBox();
            this.lbl_estoque_minimo = new System.Windows.Forms.Label();
            this.txt_estoque_minimo = new System.Windows.Forms.TextBox();
            this.btn_novo = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.txt_cd_produto = new System.Windows.Forms.TextBox();
            this.entityConnection1 = new System.Data.Entity.Core.EntityClient.EntityConnection();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CD_PRODUTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRICAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTOQUE_MINIMO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTOQUE_ATUAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECO_CUSTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_cd_produto
            // 
            this.lbl_cd_produto.AutoSize = true;
            this.lbl_cd_produto.Location = new System.Drawing.Point(107, 48);
            this.lbl_cd_produto.Name = "lbl_cd_produto";
            this.lbl_cd_produto.Size = new System.Drawing.Size(59, 16);
            this.lbl_cd_produto.TabIndex = 4;
            this.lbl_cd_produto.Text = "Código*:";
            // 
            // lbl_descricao
            // 
            this.lbl_descricao.AutoSize = true;
            this.lbl_descricao.Location = new System.Drawing.Point(86, 79);
            this.lbl_descricao.Name = "lbl_descricao";
            this.lbl_descricao.Size = new System.Drawing.Size(77, 16);
            this.lbl_descricao.TabIndex = 6;
            this.lbl_descricao.Text = "Descrição*:";
            // 
            // txt_descricao
            // 
            this.txt_descricao.Location = new System.Drawing.Point(181, 76);
            this.txt_descricao.Name = "txt_descricao";
            this.txt_descricao.ReadOnly = true;
            this.txt_descricao.Size = new System.Drawing.Size(114, 22);
            this.txt_descricao.TabIndex = 2;
            // 
            // lbl_estoque_atual
            // 
            this.lbl_estoque_atual.AutoSize = true;
            this.lbl_estoque_atual.Location = new System.Drawing.Point(349, 79);
            this.lbl_estoque_atual.Name = "lbl_estoque_atual";
            this.lbl_estoque_atual.Size = new System.Drawing.Size(98, 16);
            this.lbl_estoque_atual.TabIndex = 8;
            this.lbl_estoque_atual.Text = "Estoque Atual*:";
            // 
            // txt_preco_custo
            // 
            this.txt_preco_custo.Location = new System.Drawing.Point(181, 106);
            this.txt_preco_custo.Name = "txt_preco_custo";
            this.txt_preco_custo.ReadOnly = true;
            this.txt_preco_custo.Size = new System.Drawing.Size(114, 22);
            this.txt_preco_custo.TabIndex = 3;
            // 
            // lbl_preco_custo
            // 
            this.lbl_preco_custo.AutoSize = true;
            this.lbl_preco_custo.Location = new System.Drawing.Point(56, 109);
            this.lbl_preco_custo.Name = "lbl_preco_custo";
            this.lbl_preco_custo.Size = new System.Drawing.Size(107, 16);
            this.lbl_preco_custo.TabIndex = 10;
            this.lbl_preco_custo.Text = "Preço de Custo*:";
            // 
            // txt_estoque_atual
            // 
            this.txt_estoque_atual.Location = new System.Drawing.Point(466, 76);
            this.txt_estoque_atual.Name = "txt_estoque_atual";
            this.txt_estoque_atual.ReadOnly = true;
            this.txt_estoque_atual.Size = new System.Drawing.Size(114, 22);
            this.txt_estoque_atual.TabIndex = 5;
            // 
            // lbl_estoque_minimo
            // 
            this.lbl_estoque_minimo.AutoSize = true;
            this.lbl_estoque_minimo.Location = new System.Drawing.Point(341, 45);
            this.lbl_estoque_minimo.Name = "lbl_estoque_minimo";
            this.lbl_estoque_minimo.Size = new System.Drawing.Size(106, 16);
            this.lbl_estoque_minimo.TabIndex = 12;
            this.lbl_estoque_minimo.Text = "Estoque Mínimo:";
            // 
            // txt_estoque_minimo
            // 
            this.txt_estoque_minimo.Location = new System.Drawing.Point(465, 43);
            this.txt_estoque_minimo.Name = "txt_estoque_minimo";
            this.txt_estoque_minimo.ReadOnly = true;
            this.txt_estoque_minimo.Size = new System.Drawing.Size(114, 22);
            this.txt_estoque_minimo.TabIndex = 4;
            // 
            // btn_novo
            // 
            this.btn_novo.Location = new System.Drawing.Point(59, 400);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(86, 32);
            this.btn_novo.TabIndex = 13;
            this.btn_novo.Text = "Novo";
            this.btn_novo.UseVisualStyleBackColor = true;
            this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.Enabled = false;
            this.btn_salvar.Location = new System.Drawing.Point(378, 400);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(86, 32);
            this.btn_salvar.TabIndex = 14;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Enabled = false;
            this.btn_cancelar.Location = new System.Drawing.Point(725, 400);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(86, 32);
            this.btn_cancelar.TabIndex = 15;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // txt_cd_produto
            // 
            this.txt_cd_produto.Location = new System.Drawing.Point(181, 45);
            this.txt_cd_produto.Name = "txt_cd_produto";
            this.txt_cd_produto.ReadOnly = true;
            this.txt_cd_produto.Size = new System.Drawing.Size(114, 22);
            this.txt_cd_produto.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CD_PRODUTO,
            this.DESCRICAO,
            this.ESTOQUE_MINIMO,
            this.ESTOQUE_ATUAL,
            this.PRECO_CUSTO});
            this.dataGridView1.Location = new System.Drawing.Point(59, 163);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(752, 214);
            this.dataGridView1.TabIndex = 17;
            // 
            // CD_PRODUTO
            // 
            this.CD_PRODUTO.DataPropertyName = "CD_PRODUTO";
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.CD_PRODUTO.DefaultCellStyle = dataGridViewCellStyle25;
            this.CD_PRODUTO.HeaderText = "Código";
            this.CD_PRODUTO.MinimumWidth = 6;
            this.CD_PRODUTO.Name = "CD_PRODUTO";
            this.CD_PRODUTO.ReadOnly = true;
            this.CD_PRODUTO.Width = 80;
            // 
            // DESCRICAO
            // 
            this.DESCRICAO.DataPropertyName = "DESCRICAO";
            this.DESCRICAO.HeaderText = "Descrição";
            this.DESCRICAO.MinimumWidth = 6;
            this.DESCRICAO.Name = "DESCRICAO";
            this.DESCRICAO.ReadOnly = true;
            this.DESCRICAO.Width = 125;
            // 
            // ESTOQUE_MINIMO
            // 
            this.ESTOQUE_MINIMO.DataPropertyName = "ESTOQUE_MINIMO";
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle26.Format = "N2";
            this.ESTOQUE_MINIMO.DefaultCellStyle = dataGridViewCellStyle26;
            this.ESTOQUE_MINIMO.HeaderText = "Estoque Mínimo";
            this.ESTOQUE_MINIMO.MinimumWidth = 6;
            this.ESTOQUE_MINIMO.Name = "ESTOQUE_MINIMO";
            this.ESTOQUE_MINIMO.ReadOnly = true;
            this.ESTOQUE_MINIMO.Width = 150;
            // 
            // ESTOQUE_ATUAL
            // 
            this.ESTOQUE_ATUAL.DataPropertyName = "ESTOQUE_ATUAL";
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle27.Format = "N2";
            this.ESTOQUE_ATUAL.DefaultCellStyle = dataGridViewCellStyle27;
            this.ESTOQUE_ATUAL.HeaderText = "Estoque Atual";
            this.ESTOQUE_ATUAL.MinimumWidth = 6;
            this.ESTOQUE_ATUAL.Name = "ESTOQUE_ATUAL";
            this.ESTOQUE_ATUAL.ReadOnly = true;
            this.ESTOQUE_ATUAL.Width = 125;
            // 
            // PRECO_CUSTO
            // 
            this.PRECO_CUSTO.DataPropertyName = "PRECO_CUSTO";
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle28.Format = "N2";
            this.PRECO_CUSTO.DefaultCellStyle = dataGridViewCellStyle28;
            this.PRECO_CUSTO.HeaderText = "Preço de Custo";
            this.PRECO_CUSTO.MinimumWidth = 6;
            this.PRECO_CUSTO.Name = "PRECO_CUSTO";
            this.PRECO_CUSTO.ReadOnly = true;
            this.PRECO_CUSTO.Width = 150;
            // 
            // ProdutoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(875, 444);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_cd_produto);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.btn_novo);
            this.Controls.Add(this.lbl_estoque_minimo);
            this.Controls.Add(this.txt_estoque_minimo);
            this.Controls.Add(this.lbl_preco_custo);
            this.Controls.Add(this.txt_estoque_atual);
            this.Controls.Add(this.lbl_estoque_atual);
            this.Controls.Add(this.txt_preco_custo);
            this.Controls.Add(this.lbl_descricao);
            this.Controls.Add(this.txt_descricao);
            this.Controls.Add(this.lbl_cd_produto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "ProdutoView";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Produto";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_cd_produto;
        private System.Windows.Forms.Label lbl_descricao;
        private System.Windows.Forms.TextBox txt_descricao;
        private System.Windows.Forms.Label lbl_estoque_atual;
        private System.Windows.Forms.TextBox txt_preco_custo;
        private System.Windows.Forms.Label lbl_preco_custo;
        private System.Windows.Forms.TextBox txt_estoque_atual;
        private System.Windows.Forms.Label lbl_estoque_minimo;
        private System.Windows.Forms.TextBox txt_estoque_minimo;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.TextBox txt_cd_produto;
        private System.Data.Entity.Core.EntityClient.EntityConnection entityConnection1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDPRODUTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRICAODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRECOCUSTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eSTOQUEMINIMODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eSTOQUEATUALDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CD_PRODUTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRICAO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTOQUE_MINIMO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTOQUE_ATUAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECO_CUSTO;
    }
}