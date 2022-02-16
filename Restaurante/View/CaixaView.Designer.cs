
namespace RestauranteApp.View
{
    partial class CaixaView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Cd_Caixa_Conta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fk_Cd_Conta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao_Pagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor_Pagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_Hora_Pagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fk_Cd_Caixa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_remover_caixa_conta = new System.Windows.Forms.Button();
            this.btn_editar_caixa_conta = new System.Windows.Forms.Button();
            this.btn_cancelar_caixa_conta = new System.Windows.Forms.Button();
            this.btn_salvar_caixa_conta = new System.Windows.Forms.Button();
            this.btn_novo_caixa_conta = new System.Windows.Forms.Button();
            this.gb_caixa = new System.Windows.Forms.GroupBox();
            this.lbl_valor_atual = new System.Windows.Forms.Label();
            this.txt_valor_atual = new System.Windows.Forms.TextBox();
            this.btn_editar = new System.Windows.Forms.Button();
            this.txt_cd_caixa = new System.Windows.Forms.TextBox();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_novo = new System.Windows.Forms.Button();
            this.lbl_cd_caixa = new System.Windows.Forms.Label();
            this.gb_caixa_conta = new System.Windows.Forms.GroupBox();
            this.txt_cd_caixa_conta = new System.Windows.Forms.TextBox();
            this.cb_descricao_pagamento = new System.Windows.Forms.ComboBox();
            this.lbl_cd_caixa_conta = new System.Windows.Forms.Label();
            this.lbl_descricao_pagamento = new System.Windows.Forms.Label();
            this.txt_data_pagamento = new System.Windows.Forms.TextBox();
            this.lbl_data_pagamento = new System.Windows.Forms.Label();
            this.txt_valor_pagamento = new System.Windows.Forms.TextBox();
            this.lbl_valor_pagamento = new System.Windows.Forms.Label();
            this.txt_cd_conta = new System.Windows.Forms.TextBox();
            this.lbl_cd_conta = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.gb_caixa.SuspendLayout();
            this.gb_caixa_conta.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cd_Caixa_Conta,
            this.Fk_Cd_Conta,
            this.Descricao_Pagamento,
            this.Valor_Pagamento,
            this.Data_Hora_Pagamento,
            this.Fk_Cd_Caixa});
            this.dataGridView2.Location = new System.Drawing.Point(18, 103);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(885, 195);
            this.dataGridView2.TabIndex = 46;
            // 
            // Cd_Caixa_Conta
            // 
            this.Cd_Caixa_Conta.DataPropertyName = "Cd_Caixa_Conta";
            this.Cd_Caixa_Conta.HeaderText = "Código";
            this.Cd_Caixa_Conta.MinimumWidth = 6;
            this.Cd_Caixa_Conta.Name = "Cd_Caixa_Conta";
            this.Cd_Caixa_Conta.ReadOnly = true;
            this.Cd_Caixa_Conta.Width = 60;
            // 
            // Fk_Cd_Conta
            // 
            this.Fk_Cd_Conta.DataPropertyName = "Fk_Cd_Conta";
            this.Fk_Cd_Conta.HeaderText = "Conta";
            this.Fk_Cd_Conta.MinimumWidth = 6;
            this.Fk_Cd_Conta.Name = "Fk_Cd_Conta";
            this.Fk_Cd_Conta.ReadOnly = true;
            this.Fk_Cd_Conta.Width = 60;
            // 
            // Descricao_Pagamento
            // 
            this.Descricao_Pagamento.DataPropertyName = "Descricao_Pagamento";
            this.Descricao_Pagamento.HeaderText = "Forma de Pagamento";
            this.Descricao_Pagamento.MinimumWidth = 6;
            this.Descricao_Pagamento.Name = "Descricao_Pagamento";
            this.Descricao_Pagamento.ReadOnly = true;
            this.Descricao_Pagamento.Width = 150;
            // 
            // Valor_Pagamento
            // 
            this.Valor_Pagamento.DataPropertyName = "Valor_Pagamento";
            this.Valor_Pagamento.HeaderText = "Valor de Pagamento";
            this.Valor_Pagamento.MinimumWidth = 6;
            this.Valor_Pagamento.Name = "Valor_Pagamento";
            this.Valor_Pagamento.ReadOnly = true;
            this.Valor_Pagamento.Width = 150;
            // 
            // Data_Hora_Pagamento
            // 
            this.Data_Hora_Pagamento.DataPropertyName = "Data_Hora_Pagamento";
            dataGridViewCellStyle2.Format = "G";
            dataGridViewCellStyle2.NullValue = null;
            this.Data_Hora_Pagamento.DefaultCellStyle = dataGridViewCellStyle2;
            this.Data_Hora_Pagamento.HeaderText = "Data de Pagamento";
            this.Data_Hora_Pagamento.MinimumWidth = 6;
            this.Data_Hora_Pagamento.Name = "Data_Hora_Pagamento";
            this.Data_Hora_Pagamento.ReadOnly = true;
            this.Data_Hora_Pagamento.Width = 150;
            // 
            // Fk_Cd_Caixa
            // 
            this.Fk_Cd_Caixa.DataPropertyName = "Fk_Cd_Caixa";
            this.Fk_Cd_Caixa.HeaderText = "Fk_Cd_Caixa";
            this.Fk_Cd_Caixa.MinimumWidth = 6;
            this.Fk_Cd_Caixa.Name = "Fk_Cd_Caixa";
            this.Fk_Cd_Caixa.ReadOnly = true;
            this.Fk_Cd_Caixa.Visible = false;
            this.Fk_Cd_Caixa.Width = 125;
            // 
            // btn_remover_caixa_conta
            // 
            this.btn_remover_caixa_conta.Location = new System.Drawing.Point(614, 304);
            this.btn_remover_caixa_conta.Name = "btn_remover_caixa_conta";
            this.btn_remover_caixa_conta.Size = new System.Drawing.Size(86, 32);
            this.btn_remover_caixa_conta.TabIndex = 45;
            this.btn_remover_caixa_conta.Text = "Remover";
            this.btn_remover_caixa_conta.UseVisualStyleBackColor = true;
            this.btn_remover_caixa_conta.Click += new System.EventHandler(this.btn_remover_caixa_conta_Click);
            // 
            // btn_editar_caixa_conta
            // 
            this.btn_editar_caixa_conta.Location = new System.Drawing.Point(216, 304);
            this.btn_editar_caixa_conta.Name = "btn_editar_caixa_conta";
            this.btn_editar_caixa_conta.Size = new System.Drawing.Size(86, 32);
            this.btn_editar_caixa_conta.TabIndex = 44;
            this.btn_editar_caixa_conta.Text = "Editar";
            this.btn_editar_caixa_conta.UseVisualStyleBackColor = true;
            this.btn_editar_caixa_conta.Click += new System.EventHandler(this.btn_editar_caixa_conta_Click);
            // 
            // btn_cancelar_caixa_conta
            // 
            this.btn_cancelar_caixa_conta.Enabled = false;
            this.btn_cancelar_caixa_conta.Location = new System.Drawing.Point(817, 304);
            this.btn_cancelar_caixa_conta.Name = "btn_cancelar_caixa_conta";
            this.btn_cancelar_caixa_conta.Size = new System.Drawing.Size(86, 32);
            this.btn_cancelar_caixa_conta.TabIndex = 43;
            this.btn_cancelar_caixa_conta.Text = "Cancelar";
            this.btn_cancelar_caixa_conta.UseVisualStyleBackColor = true;
            this.btn_cancelar_caixa_conta.Click += new System.EventHandler(this.btn_cancelar_caixa_conta_Click);
            // 
            // btn_salvar_caixa_conta
            // 
            this.btn_salvar_caixa_conta.Enabled = false;
            this.btn_salvar_caixa_conta.Location = new System.Drawing.Point(405, 304);
            this.btn_salvar_caixa_conta.Name = "btn_salvar_caixa_conta";
            this.btn_salvar_caixa_conta.Size = new System.Drawing.Size(86, 32);
            this.btn_salvar_caixa_conta.TabIndex = 42;
            this.btn_salvar_caixa_conta.Text = "Salvar";
            this.btn_salvar_caixa_conta.UseVisualStyleBackColor = true;
            this.btn_salvar_caixa_conta.Click += new System.EventHandler(this.btn_salvar_caixa_conta_Click);
            // 
            // btn_novo_caixa_conta
            // 
            this.btn_novo_caixa_conta.Location = new System.Drawing.Point(18, 304);
            this.btn_novo_caixa_conta.Name = "btn_novo_caixa_conta";
            this.btn_novo_caixa_conta.Size = new System.Drawing.Size(86, 32);
            this.btn_novo_caixa_conta.TabIndex = 41;
            this.btn_novo_caixa_conta.Text = "Novo";
            this.btn_novo_caixa_conta.UseVisualStyleBackColor = true;
            this.btn_novo_caixa_conta.Click += new System.EventHandler(this.btn_novo_caixa_conta_Click);
            // 
            // gb_caixa
            // 
            this.gb_caixa.Controls.Add(this.lbl_valor_atual);
            this.gb_caixa.Controls.Add(this.txt_valor_atual);
            this.gb_caixa.Controls.Add(this.btn_editar);
            this.gb_caixa.Controls.Add(this.txt_cd_caixa);
            this.gb_caixa.Controls.Add(this.btn_cancelar);
            this.gb_caixa.Controls.Add(this.btn_salvar);
            this.gb_caixa.Controls.Add(this.btn_novo);
            this.gb_caixa.Controls.Add(this.lbl_cd_caixa);
            this.gb_caixa.Location = new System.Drawing.Point(42, 27);
            this.gb_caixa.Name = "gb_caixa";
            this.gb_caixa.Size = new System.Drawing.Size(924, 116);
            this.gb_caixa.TabIndex = 47;
            this.gb_caixa.TabStop = false;
            this.gb_caixa.Text = "Caixa";
            // 
            // lbl_valor_atual
            // 
            this.lbl_valor_atual.AutoSize = true;
            this.lbl_valor_atual.Location = new System.Drawing.Point(350, 32);
            this.lbl_valor_atual.Name = "lbl_valor_atual";
            this.lbl_valor_atual.Size = new System.Drawing.Size(80, 16);
            this.lbl_valor_atual.TabIndex = 38;
            this.lbl_valor_atual.Text = "Valor Atual*:";
            // 
            // txt_valor_atual
            // 
            this.txt_valor_atual.Location = new System.Drawing.Point(436, 29);
            this.txt_valor_atual.Name = "txt_valor_atual";
            this.txt_valor_atual.ReadOnly = true;
            this.txt_valor_atual.Size = new System.Drawing.Size(120, 22);
            this.txt_valor_atual.TabIndex = 37;
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(126, 65);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(86, 32);
            this.btn_editar.TabIndex = 36;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = true;
            // 
            // txt_cd_caixa
            // 
            this.txt_cd_caixa.Location = new System.Drawing.Point(92, 32);
            this.txt_cd_caixa.Name = "txt_cd_caixa";
            this.txt_cd_caixa.ReadOnly = true;
            this.txt_cd_caixa.Size = new System.Drawing.Size(120, 22);
            this.txt_cd_caixa.TabIndex = 31;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Enabled = false;
            this.btn_cancelar.Location = new System.Drawing.Point(470, 62);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(86, 32);
            this.btn_cancelar.TabIndex = 35;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // btn_salvar
            // 
            this.btn_salvar.Enabled = false;
            this.btn_salvar.Location = new System.Drawing.Point(344, 62);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(86, 32);
            this.btn_salvar.TabIndex = 34;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            // 
            // btn_novo
            // 
            this.btn_novo.Location = new System.Drawing.Point(30, 65);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(86, 32);
            this.btn_novo.TabIndex = 33;
            this.btn_novo.Text = "Novo";
            this.btn_novo.UseVisualStyleBackColor = true;
            // 
            // lbl_cd_caixa
            // 
            this.lbl_cd_caixa.AutoSize = true;
            this.lbl_cd_caixa.Location = new System.Drawing.Point(27, 35);
            this.lbl_cd_caixa.Name = "lbl_cd_caixa";
            this.lbl_cd_caixa.Size = new System.Drawing.Size(59, 16);
            this.lbl_cd_caixa.TabIndex = 32;
            this.lbl_cd_caixa.Text = "Código*:";
            // 
            // gb_caixa_conta
            // 
            this.gb_caixa_conta.Controls.Add(this.txt_cd_caixa_conta);
            this.gb_caixa_conta.Controls.Add(this.cb_descricao_pagamento);
            this.gb_caixa_conta.Controls.Add(this.lbl_cd_caixa_conta);
            this.gb_caixa_conta.Controls.Add(this.lbl_descricao_pagamento);
            this.gb_caixa_conta.Controls.Add(this.txt_data_pagamento);
            this.gb_caixa_conta.Controls.Add(this.lbl_data_pagamento);
            this.gb_caixa_conta.Controls.Add(this.txt_valor_pagamento);
            this.gb_caixa_conta.Controls.Add(this.lbl_valor_pagamento);
            this.gb_caixa_conta.Controls.Add(this.txt_cd_conta);
            this.gb_caixa_conta.Controls.Add(this.dataGridView2);
            this.gb_caixa_conta.Controls.Add(this.lbl_cd_conta);
            this.gb_caixa_conta.Controls.Add(this.btn_novo_caixa_conta);
            this.gb_caixa_conta.Controls.Add(this.btn_remover_caixa_conta);
            this.gb_caixa_conta.Controls.Add(this.btn_salvar_caixa_conta);
            this.gb_caixa_conta.Controls.Add(this.btn_editar_caixa_conta);
            this.gb_caixa_conta.Controls.Add(this.btn_cancelar_caixa_conta);
            this.gb_caixa_conta.Location = new System.Drawing.Point(42, 149);
            this.gb_caixa_conta.Name = "gb_caixa_conta";
            this.gb_caixa_conta.Size = new System.Drawing.Size(924, 357);
            this.gb_caixa_conta.TabIndex = 48;
            this.gb_caixa_conta.TabStop = false;
            this.gb_caixa_conta.Text = "Pagamento";
            // 
            // txt_cd_caixa_conta
            // 
            this.txt_cd_caixa_conta.Location = new System.Drawing.Point(92, 25);
            this.txt_cd_caixa_conta.Name = "txt_cd_caixa_conta";
            this.txt_cd_caixa_conta.ReadOnly = true;
            this.txt_cd_caixa_conta.Size = new System.Drawing.Size(120, 22);
            this.txt_cd_caixa_conta.TabIndex = 39;
            // 
            // cb_descricao_pagamento
            // 
            this.cb_descricao_pagamento.Enabled = false;
            this.cb_descricao_pagamento.FormattingEnabled = true;
            this.cb_descricao_pagamento.Items.AddRange(new object[] {
            "Dinheiro",
            "Cartão",
            "Cheque",
            "Vale",
            "Aplicativo",
            "Pix"});
            this.cb_descricao_pagamento.Location = new System.Drawing.Point(436, 56);
            this.cb_descricao_pagamento.Name = "cb_descricao_pagamento";
            this.cb_descricao_pagamento.Size = new System.Drawing.Size(120, 24);
            this.cb_descricao_pagamento.TabIndex = 53;
            // 
            // lbl_cd_caixa_conta
            // 
            this.lbl_cd_caixa_conta.AutoSize = true;
            this.lbl_cd_caixa_conta.Location = new System.Drawing.Point(27, 28);
            this.lbl_cd_caixa_conta.Name = "lbl_cd_caixa_conta";
            this.lbl_cd_caixa_conta.Size = new System.Drawing.Size(59, 16);
            this.lbl_cd_caixa_conta.TabIndex = 40;
            this.lbl_cd_caixa_conta.Text = "Código*:";
            // 
            // lbl_descricao_pagamento
            // 
            this.lbl_descricao_pagamento.AutoSize = true;
            this.lbl_descricao_pagamento.Location = new System.Drawing.Point(284, 59);
            this.lbl_descricao_pagamento.Name = "lbl_descricao_pagamento";
            this.lbl_descricao_pagamento.Size = new System.Drawing.Size(146, 16);
            this.lbl_descricao_pagamento.TabIndex = 52;
            this.lbl_descricao_pagamento.Text = "Forma de Pagamento*:";
            // 
            // txt_data_pagamento
            // 
            this.txt_data_pagamento.Location = new System.Drawing.Point(436, 25);
            this.txt_data_pagamento.Name = "txt_data_pagamento";
            this.txt_data_pagamento.ReadOnly = true;
            this.txt_data_pagamento.Size = new System.Drawing.Size(120, 22);
            this.txt_data_pagamento.TabIndex = 49;
            // 
            // lbl_data_pagamento
            // 
            this.lbl_data_pagamento.AutoSize = true;
            this.lbl_data_pagamento.Location = new System.Drawing.Point(299, 28);
            this.lbl_data_pagamento.Name = "lbl_data_pagamento";
            this.lbl_data_pagamento.Size = new System.Drawing.Size(131, 16);
            this.lbl_data_pagamento.TabIndex = 50;
            this.lbl_data_pagamento.Text = "Data de Pagamento:";
            // 
            // txt_valor_pagamento
            // 
            this.txt_valor_pagamento.Location = new System.Drawing.Point(650, 25);
            this.txt_valor_pagamento.Name = "txt_valor_pagamento";
            this.txt_valor_pagamento.ReadOnly = true;
            this.txt_valor_pagamento.Size = new System.Drawing.Size(120, 22);
            this.txt_valor_pagamento.TabIndex = 47;
            // 
            // lbl_valor_pagamento
            // 
            this.lbl_valor_pagamento.AutoSize = true;
            this.lbl_valor_pagamento.Location = new System.Drawing.Point(597, 28);
            this.lbl_valor_pagamento.Name = "lbl_valor_pagamento";
            this.lbl_valor_pagamento.Size = new System.Drawing.Size(47, 16);
            this.lbl_valor_pagamento.TabIndex = 48;
            this.lbl_valor_pagamento.Text = "Valor*:";
            // 
            // txt_cd_conta
            // 
            this.txt_cd_conta.Location = new System.Drawing.Point(92, 56);
            this.txt_cd_conta.Name = "txt_cd_conta";
            this.txt_cd_conta.ReadOnly = true;
            this.txt_cd_conta.Size = new System.Drawing.Size(120, 22);
            this.txt_cd_conta.TabIndex = 39;
            // 
            // lbl_cd_conta
            // 
            this.lbl_cd_conta.AutoSize = true;
            this.lbl_cd_conta.Location = new System.Drawing.Point(36, 59);
            this.lbl_cd_conta.Name = "lbl_cd_conta";
            this.lbl_cd_conta.Size = new System.Drawing.Size(50, 16);
            this.lbl_cd_conta.TabIndex = 40;
            this.lbl_cd_conta.Text = "Conta*:";
            // 
            // CaixaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1005, 518);
            this.Controls.Add(this.gb_caixa_conta);
            this.Controls.Add(this.gb_caixa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "CaixaView";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Caixa";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.gb_caixa.ResumeLayout(false);
            this.gb_caixa.PerformLayout();
            this.gb_caixa_conta.ResumeLayout(false);
            this.gb_caixa_conta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn cDPRODUTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRICAODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRECOCUSTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eSTOQUEMINIMODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eSTOQUEATUALDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btn_remover_caixa_conta;
        private System.Windows.Forms.Button btn_editar_caixa_conta;
        private System.Windows.Forms.Button btn_cancelar_caixa_conta;
        private System.Windows.Forms.Button btn_salvar_caixa_conta;
        private System.Windows.Forms.Button btn_novo_caixa_conta;
        private System.Windows.Forms.GroupBox gb_caixa;
        private System.Windows.Forms.Label lbl_valor_atual;
        private System.Windows.Forms.TextBox txt_valor_atual;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.TextBox txt_cd_caixa;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.Label lbl_cd_caixa;
        private System.Windows.Forms.GroupBox gb_caixa_conta;
        private System.Windows.Forms.Label lbl_descricao_pagamento;
        private System.Windows.Forms.TextBox txt_data_pagamento;
        private System.Windows.Forms.Label lbl_data_pagamento;
        private System.Windows.Forms.TextBox txt_valor_pagamento;
        private System.Windows.Forms.Label lbl_valor_pagamento;
        private System.Windows.Forms.TextBox txt_cd_conta;
        private System.Windows.Forms.Label lbl_cd_conta;
        private System.Windows.Forms.ComboBox cb_descricao_pagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cd_Caixa_Conta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fk_Cd_Conta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao_Pagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor_Pagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_Hora_Pagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fk_Cd_Caixa;
        private System.Windows.Forms.TextBox txt_cd_caixa_conta;
        private System.Windows.Forms.Label lbl_cd_caixa_conta;
    }
}