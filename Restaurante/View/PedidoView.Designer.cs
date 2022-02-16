
namespace RestauranteApp.View
{
    partial class PedidoView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gb_pedido = new System.Windows.Forms.GroupBox();
            this.cb_mesa = new System.Windows.Forms.ComboBox();
            this.btn_remover = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CD_PEDIDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FK_CD_MESA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATA_HORA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_cd_pedido = new System.Windows.Forms.TextBox();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_novo = new System.Windows.Forms.Button();
            this.lbl_data = new System.Windows.Forms.Label();
            this.txt_data = new System.Windows.Forms.TextBox();
            this.lbl_mesa = new System.Windows.Forms.Label();
            this.lbl_cd_pedido = new System.Windows.Forms.Label();
            this.gb_pedido_refeicao = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.cd_pedido_refeicao1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FK_CD_REFEICAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUANTIDADE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FK_CD_PEDIDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_preco = new System.Windows.Forms.TextBox();
            this.lbl_preco = new System.Windows.Forms.Label();
            this.lbl_quantidade = new System.Windows.Forms.Label();
            this.txt_quantidade = new System.Windows.Forms.TextBox();
            this.btn_remover_pedido_refeicao = new System.Windows.Forms.Button();
            this.btn_editar_pedido_refeicao = new System.Windows.Forms.Button();
            this.txt_pedido_refeicao = new System.Windows.Forms.TextBox();
            this.btn_cancelar_pedido_refeicao = new System.Windows.Forms.Button();
            this.btn_salvar_pedido_refeicao = new System.Windows.Forms.Button();
            this.btn_novo_pedido_refeicao = new System.Windows.Forms.Button();
            this.lbl_cd_refeicao = new System.Windows.Forms.Label();
            this.txt_cd_refeicao = new System.Windows.Forms.TextBox();
            this.lbl_cd_pedido_refeicao = new System.Windows.Forms.Label();
            this.gb_pedido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gb_pedido_refeicao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_pedido
            // 
            this.gb_pedido.Controls.Add(this.cb_mesa);
            this.gb_pedido.Controls.Add(this.btn_remover);
            this.gb_pedido.Controls.Add(this.btn_editar);
            this.gb_pedido.Controls.Add(this.dataGridView1);
            this.gb_pedido.Controls.Add(this.txt_cd_pedido);
            this.gb_pedido.Controls.Add(this.btn_cancelar);
            this.gb_pedido.Controls.Add(this.btn_salvar);
            this.gb_pedido.Controls.Add(this.btn_novo);
            this.gb_pedido.Controls.Add(this.lbl_data);
            this.gb_pedido.Controls.Add(this.txt_data);
            this.gb_pedido.Controls.Add(this.lbl_mesa);
            this.gb_pedido.Controls.Add(this.lbl_cd_pedido);
            this.gb_pedido.Location = new System.Drawing.Point(12, 12);
            this.gb_pedido.Name = "gb_pedido";
            this.gb_pedido.Size = new System.Drawing.Size(468, 494);
            this.gb_pedido.TabIndex = 0;
            this.gb_pedido.TabStop = false;
            this.gb_pedido.Text = "Pedido";
            // 
            // cb_mesa
            // 
            this.cb_mesa.Enabled = false;
            this.cb_mesa.FormattingEnabled = true;
            this.cb_mesa.Location = new System.Drawing.Point(167, 47);
            this.cb_mesa.Name = "cb_mesa";
            this.cb_mesa.Size = new System.Drawing.Size(120, 24);
            this.cb_mesa.TabIndex = 2;
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
            this.CD_PEDIDO,
            this.FK_CD_MESA,
            this.DATA_HORA});
            this.dataGridView1.Location = new System.Drawing.Point(51, 159);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(367, 191);
            this.dataGridView1.TabIndex = 33;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // CD_PEDIDO
            // 
            this.CD_PEDIDO.DataPropertyName = "CD_PEDIDO";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.CD_PEDIDO.DefaultCellStyle = dataGridViewCellStyle1;
            this.CD_PEDIDO.HeaderText = "Código";
            this.CD_PEDIDO.MinimumWidth = 6;
            this.CD_PEDIDO.Name = "CD_PEDIDO";
            this.CD_PEDIDO.ReadOnly = true;
            this.CD_PEDIDO.Width = 50;
            // 
            // FK_CD_MESA
            // 
            this.FK_CD_MESA.DataPropertyName = "FK_CD_MESA";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.FK_CD_MESA.DefaultCellStyle = dataGridViewCellStyle2;
            this.FK_CD_MESA.HeaderText = "Mesa";
            this.FK_CD_MESA.MinimumWidth = 6;
            this.FK_CD_MESA.Name = "FK_CD_MESA";
            this.FK_CD_MESA.ReadOnly = true;
            this.FK_CD_MESA.Width = 50;
            // 
            // DATA_HORA
            // 
            this.DATA_HORA.DataPropertyName = "DATA_HORA";
            dataGridViewCellStyle3.Format = "G";
            dataGridViewCellStyle3.NullValue = null;
            this.DATA_HORA.DefaultCellStyle = dataGridViewCellStyle3;
            this.DATA_HORA.HeaderText = "Data";
            this.DATA_HORA.MinimumWidth = 6;
            this.DATA_HORA.Name = "DATA_HORA";
            this.DATA_HORA.ReadOnly = true;
            this.DATA_HORA.Width = 120;
            // 
            // txt_cd_pedido
            // 
            this.txt_cd_pedido.Location = new System.Drawing.Point(167, 18);
            this.txt_cd_pedido.Name = "txt_cd_pedido";
            this.txt_cd_pedido.ReadOnly = true;
            this.txt_cd_pedido.Size = new System.Drawing.Size(120, 22);
            this.txt_cd_pedido.TabIndex = 1;
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
            // lbl_data
            // 
            this.lbl_data.AutoSize = true;
            this.lbl_data.Location = new System.Drawing.Point(109, 85);
            this.lbl_data.Name = "lbl_data";
            this.lbl_data.Size = new System.Drawing.Size(44, 16);
            this.lbl_data.TabIndex = 28;
            this.lbl_data.Text = "Data*:";
            // 
            // txt_data
            // 
            this.txt_data.Location = new System.Drawing.Point(167, 79);
            this.txt_data.Name = "txt_data";
            this.txt_data.ReadOnly = true;
            this.txt_data.Size = new System.Drawing.Size(120, 22);
            this.txt_data.TabIndex = 3;
            // 
            // lbl_mesa
            // 
            this.lbl_mesa.AutoSize = true;
            this.lbl_mesa.Location = new System.Drawing.Point(109, 52);
            this.lbl_mesa.Name = "lbl_mesa";
            this.lbl_mesa.Size = new System.Drawing.Size(49, 16);
            this.lbl_mesa.TabIndex = 26;
            this.lbl_mesa.Text = "Mesa*:";
            // 
            // lbl_cd_pedido
            // 
            this.lbl_cd_pedido.AutoSize = true;
            this.lbl_cd_pedido.Location = new System.Drawing.Point(99, 21);
            this.lbl_cd_pedido.Name = "lbl_cd_pedido";
            this.lbl_cd_pedido.Size = new System.Drawing.Size(59, 16);
            this.lbl_cd_pedido.TabIndex = 24;
            this.lbl_cd_pedido.Text = "Código*:";
            // 
            // gb_pedido_refeicao
            // 
            this.gb_pedido_refeicao.Controls.Add(this.dataGridView2);
            this.gb_pedido_refeicao.Controls.Add(this.txt_preco);
            this.gb_pedido_refeicao.Controls.Add(this.lbl_preco);
            this.gb_pedido_refeicao.Controls.Add(this.lbl_quantidade);
            this.gb_pedido_refeicao.Controls.Add(this.txt_quantidade);
            this.gb_pedido_refeicao.Controls.Add(this.btn_remover_pedido_refeicao);
            this.gb_pedido_refeicao.Controls.Add(this.btn_editar_pedido_refeicao);
            this.gb_pedido_refeicao.Controls.Add(this.txt_pedido_refeicao);
            this.gb_pedido_refeicao.Controls.Add(this.btn_cancelar_pedido_refeicao);
            this.gb_pedido_refeicao.Controls.Add(this.btn_salvar_pedido_refeicao);
            this.gb_pedido_refeicao.Controls.Add(this.btn_novo_pedido_refeicao);
            this.gb_pedido_refeicao.Controls.Add(this.lbl_cd_refeicao);
            this.gb_pedido_refeicao.Controls.Add(this.txt_cd_refeicao);
            this.gb_pedido_refeicao.Controls.Add(this.lbl_cd_pedido_refeicao);
            this.gb_pedido_refeicao.Location = new System.Drawing.Point(517, 12);
            this.gb_pedido_refeicao.Name = "gb_pedido_refeicao";
            this.gb_pedido_refeicao.Size = new System.Drawing.Size(468, 494);
            this.gb_pedido_refeicao.TabIndex = 36;
            this.gb_pedido_refeicao.TabStop = false;
            this.gb_pedido_refeicao.Text = "Refeições do Pedido";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cd_pedido_refeicao1,
            this.FK_CD_REFEICAO,
            this.QUANTIDADE,
            this.PRECO,
            this.FK_CD_PEDIDO});
            this.dataGridView2.Location = new System.Drawing.Point(51, 159);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(367, 195);
            this.dataGridView2.TabIndex = 40;
            // 
            // cd_pedido_refeicao1
            // 
            this.cd_pedido_refeicao1.DataPropertyName = "cd_pedido_refeicao";
            this.cd_pedido_refeicao1.HeaderText = "Código";
            this.cd_pedido_refeicao1.MinimumWidth = 6;
            this.cd_pedido_refeicao1.Name = "cd_pedido_refeicao1";
            this.cd_pedido_refeicao1.ReadOnly = true;
            this.cd_pedido_refeicao1.Width = 60;
            // 
            // FK_CD_REFEICAO
            // 
            this.FK_CD_REFEICAO.DataPropertyName = "FK_CD_REFEICAO";
            this.FK_CD_REFEICAO.HeaderText = "Refeição";
            this.FK_CD_REFEICAO.MinimumWidth = 6;
            this.FK_CD_REFEICAO.Name = "FK_CD_REFEICAO";
            this.FK_CD_REFEICAO.ReadOnly = true;
            this.FK_CD_REFEICAO.Width = 60;
            // 
            // QUANTIDADE
            // 
            this.QUANTIDADE.DataPropertyName = "QUANTIDADE";
            this.QUANTIDADE.HeaderText = "Quantidade";
            this.QUANTIDADE.MinimumWidth = 6;
            this.QUANTIDADE.Name = "QUANTIDADE";
            this.QUANTIDADE.ReadOnly = true;
            this.QUANTIDADE.Width = 70;
            // 
            // PRECO
            // 
            this.PRECO.DataPropertyName = "PRECO";
            this.PRECO.HeaderText = "Preço";
            this.PRECO.MinimumWidth = 6;
            this.PRECO.Name = "PRECO";
            this.PRECO.ReadOnly = true;
            this.PRECO.Width = 60;
            // 
            // FK_CD_PEDIDO
            // 
            this.FK_CD_PEDIDO.DataPropertyName = "FK_CD_PEDIDO";
            this.FK_CD_PEDIDO.HeaderText = "FK_CD_PEDIDO";
            this.FK_CD_PEDIDO.MinimumWidth = 6;
            this.FK_CD_PEDIDO.Name = "FK_CD_PEDIDO";
            this.FK_CD_PEDIDO.ReadOnly = true;
            this.FK_CD_PEDIDO.Visible = false;
            this.FK_CD_PEDIDO.Width = 125;
            // 
            // txt_preco
            // 
            this.txt_preco.Location = new System.Drawing.Point(152, 115);
            this.txt_preco.Name = "txt_preco";
            this.txt_preco.ReadOnly = true;
            this.txt_preco.Size = new System.Drawing.Size(114, 22);
            this.txt_preco.TabIndex = 38;
            // 
            // lbl_preco
            // 
            this.lbl_preco.AutoSize = true;
            this.lbl_preco.Location = new System.Drawing.Point(86, 118);
            this.lbl_preco.Name = "lbl_preco";
            this.lbl_preco.Size = new System.Drawing.Size(51, 16);
            this.lbl_preco.TabIndex = 39;
            this.lbl_preco.Text = "Preço*:";
            // 
            // lbl_quantidade
            // 
            this.lbl_quantidade.AutoSize = true;
            this.lbl_quantidade.Location = new System.Drawing.Point(52, 85);
            this.lbl_quantidade.Name = "lbl_quantidade";
            this.lbl_quantidade.Size = new System.Drawing.Size(85, 16);
            this.lbl_quantidade.TabIndex = 37;
            this.lbl_quantidade.Text = "Quantidade*:";
            // 
            // txt_quantidade
            // 
            this.txt_quantidade.Location = new System.Drawing.Point(152, 82);
            this.txt_quantidade.Name = "txt_quantidade";
            this.txt_quantidade.ReadOnly = true;
            this.txt_quantidade.Size = new System.Drawing.Size(114, 22);
            this.txt_quantidade.TabIndex = 36;
            // 
            // btn_remover_pedido_refeicao
            // 
            this.btn_remover_pedido_refeicao.Location = new System.Drawing.Point(332, 373);
            this.btn_remover_pedido_refeicao.Name = "btn_remover_pedido_refeicao";
            this.btn_remover_pedido_refeicao.Size = new System.Drawing.Size(86, 32);
            this.btn_remover_pedido_refeicao.TabIndex = 35;
            this.btn_remover_pedido_refeicao.Text = "Remover";
            this.btn_remover_pedido_refeicao.UseVisualStyleBackColor = true;
            this.btn_remover_pedido_refeicao.Click += new System.EventHandler(this.btn_remover_pedido_refeicao_Click);
            // 
            // btn_editar_pedido_refeicao
            // 
            this.btn_editar_pedido_refeicao.Location = new System.Drawing.Point(189, 373);
            this.btn_editar_pedido_refeicao.Name = "btn_editar_pedido_refeicao";
            this.btn_editar_pedido_refeicao.Size = new System.Drawing.Size(86, 32);
            this.btn_editar_pedido_refeicao.TabIndex = 34;
            this.btn_editar_pedido_refeicao.Text = "Editar";
            this.btn_editar_pedido_refeicao.UseVisualStyleBackColor = true;
            this.btn_editar_pedido_refeicao.Click += new System.EventHandler(this.btn_editar_pedido_refeicao_Click);
            // 
            // txt_pedido_refeicao
            // 
            this.txt_pedido_refeicao.Location = new System.Drawing.Point(152, 18);
            this.txt_pedido_refeicao.Name = "txt_pedido_refeicao";
            this.txt_pedido_refeicao.ReadOnly = true;
            this.txt_pedido_refeicao.Size = new System.Drawing.Size(114, 22);
            this.txt_pedido_refeicao.TabIndex = 20;
            // 
            // btn_cancelar_pedido_refeicao
            // 
            this.btn_cancelar_pedido_refeicao.Enabled = false;
            this.btn_cancelar_pedido_refeicao.Location = new System.Drawing.Point(332, 429);
            this.btn_cancelar_pedido_refeicao.Name = "btn_cancelar_pedido_refeicao";
            this.btn_cancelar_pedido_refeicao.Size = new System.Drawing.Size(86, 32);
            this.btn_cancelar_pedido_refeicao.TabIndex = 32;
            this.btn_cancelar_pedido_refeicao.Text = "Cancelar";
            this.btn_cancelar_pedido_refeicao.UseVisualStyleBackColor = true;
            this.btn_cancelar_pedido_refeicao.Click += new System.EventHandler(this.btn_cancelar_pedido_refeicao_Click);
            // 
            // btn_salvar_pedido_refeicao
            // 
            this.btn_salvar_pedido_refeicao.Enabled = false;
            this.btn_salvar_pedido_refeicao.Location = new System.Drawing.Point(51, 438);
            this.btn_salvar_pedido_refeicao.Name = "btn_salvar_pedido_refeicao";
            this.btn_salvar_pedido_refeicao.Size = new System.Drawing.Size(86, 32);
            this.btn_salvar_pedido_refeicao.TabIndex = 31;
            this.btn_salvar_pedido_refeicao.Text = "Salvar";
            this.btn_salvar_pedido_refeicao.UseVisualStyleBackColor = true;
            this.btn_salvar_pedido_refeicao.Click += new System.EventHandler(this.btn_salvar_pedido_refeicao_Click);
            // 
            // btn_novo_pedido_refeicao
            // 
            this.btn_novo_pedido_refeicao.Location = new System.Drawing.Point(51, 373);
            this.btn_novo_pedido_refeicao.Name = "btn_novo_pedido_refeicao";
            this.btn_novo_pedido_refeicao.Size = new System.Drawing.Size(86, 32);
            this.btn_novo_pedido_refeicao.TabIndex = 30;
            this.btn_novo_pedido_refeicao.Text = "Novo";
            this.btn_novo_pedido_refeicao.UseVisualStyleBackColor = true;
            this.btn_novo_pedido_refeicao.Click += new System.EventHandler(this.btn_novo_pedido_refeicao_Click);
            // 
            // lbl_cd_refeicao
            // 
            this.lbl_cd_refeicao.AutoSize = true;
            this.lbl_cd_refeicao.Location = new System.Drawing.Point(67, 52);
            this.lbl_cd_refeicao.Name = "lbl_cd_refeicao";
            this.lbl_cd_refeicao.Size = new System.Drawing.Size(70, 16);
            this.lbl_cd_refeicao.TabIndex = 28;
            this.lbl_cd_refeicao.Text = "Refeição*:";
            // 
            // txt_cd_refeicao
            // 
            this.txt_cd_refeicao.Location = new System.Drawing.Point(152, 49);
            this.txt_cd_refeicao.Name = "txt_cd_refeicao";
            this.txt_cd_refeicao.ReadOnly = true;
            this.txt_cd_refeicao.Size = new System.Drawing.Size(114, 22);
            this.txt_cd_refeicao.TabIndex = 22;
            // 
            // lbl_cd_pedido_refeicao
            // 
            this.lbl_cd_pedido_refeicao.AutoSize = true;
            this.lbl_cd_pedido_refeicao.Location = new System.Drawing.Point(78, 21);
            this.lbl_cd_pedido_refeicao.Name = "lbl_cd_pedido_refeicao";
            this.lbl_cd_pedido_refeicao.Size = new System.Drawing.Size(59, 16);
            this.lbl_cd_pedido_refeicao.TabIndex = 24;
            this.lbl_cd_pedido_refeicao.Text = "Código*:";
            // 
            // PedidoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1005, 518);
            this.Controls.Add(this.gb_pedido_refeicao);
            this.Controls.Add(this.gb_pedido);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "PedidoView";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pedido";
            this.gb_pedido.ResumeLayout(false);
            this.gb_pedido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gb_pedido_refeicao.ResumeLayout(false);
            this.gb_pedido_refeicao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn cDPRODUTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRICAODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRECOCUSTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eSTOQUEMINIMODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eSTOQUEATUALDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox gb_pedido;
        private System.Windows.Forms.Button btn_remover;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_cd_pedido;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.Label lbl_data;
        private System.Windows.Forms.TextBox txt_data;
        private System.Windows.Forms.Label lbl_mesa;
        private System.Windows.Forms.Label lbl_cd_pedido;
        private System.Windows.Forms.GroupBox gb_pedido_refeicao;
        private System.Windows.Forms.Button btn_remover_pedido_refeicao;
        private System.Windows.Forms.Button btn_editar_pedido_refeicao;
        private System.Windows.Forms.TextBox txt_pedido_refeicao;
        private System.Windows.Forms.Button btn_cancelar_pedido_refeicao;
        private System.Windows.Forms.Button btn_salvar_pedido_refeicao;
        private System.Windows.Forms.Button btn_novo_pedido_refeicao;
        private System.Windows.Forms.Label lbl_cd_refeicao;
        private System.Windows.Forms.TextBox txt_cd_refeicao;
        private System.Windows.Forms.Label lbl_cd_pedido_refeicao;
        private System.Windows.Forms.Label lbl_quantidade;
        private System.Windows.Forms.TextBox txt_quantidade;
        private System.Windows.Forms.ComboBox cb_mesa;
        private System.Windows.Forms.TextBox txt_preco;
        private System.Windows.Forms.Label lbl_preco;
        private System.Windows.Forms.DataGridViewTextBoxColumn CD_pedido_refeicao;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cd_pedido_refeicao1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FK_CD_REFEICAO;
        private System.Windows.Forms.DataGridViewTextBoxColumn QUANTIDADE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FK_CD_PEDIDO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CD_PEDIDO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FK_CD_MESA;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATA_HORA;
    }
}