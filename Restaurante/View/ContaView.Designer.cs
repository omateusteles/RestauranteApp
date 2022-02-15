
namespace RestauranteApp.View
{
    partial class ContaView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_cd_conta = new System.Windows.Forms.Label();
            this.btn_novo = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.txt_cd_conta = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_remover = new System.Windows.Forms.Button();
            this.cb_mesa = new System.Windows.Forms.ComboBox();
            this.lbl_mesa = new System.Windows.Forms.Label();
            this.lbl_data_abertura = new System.Windows.Forms.Label();
            this.txt_data_abertura = new System.Windows.Forms.TextBox();
            this.lbl_data_fechamento = new System.Windows.Forms.Label();
            this.txt_data_fechamento = new System.Windows.Forms.TextBox();
            this.CD_CONTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FK_CD_MESA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATA_HORA_ABERTURA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATA_HORA_FECHAMENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_cd_conta
            // 
            this.lbl_cd_conta.AutoSize = true;
            this.lbl_cd_conta.Location = new System.Drawing.Point(107, 48);
            this.lbl_cd_conta.Name = "lbl_cd_conta";
            this.lbl_cd_conta.Size = new System.Drawing.Size(59, 16);
            this.lbl_cd_conta.TabIndex = 4;
            this.lbl_cd_conta.Text = "Código*:";
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
            // txt_cd_conta
            // 
            this.txt_cd_conta.Location = new System.Drawing.Point(175, 45);
            this.txt_cd_conta.Name = "txt_cd_conta";
            this.txt_cd_conta.ReadOnly = true;
            this.txt_cd_conta.Size = new System.Drawing.Size(120, 22);
            this.txt_cd_conta.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CD_CONTA,
            this.FK_CD_MESA,
            this.DATA_HORA_ABERTURA,
            this.DATA_HORA_FECHAMENTO});
            this.dataGridView1.Location = new System.Drawing.Point(59, 163);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(752, 214);
            this.dataGridView1.TabIndex = 17;
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(209, 400);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(86, 32);
            this.btn_editar.TabIndex = 18;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_remover
            // 
            this.btn_remover.Location = new System.Drawing.Point(553, 400);
            this.btn_remover.Name = "btn_remover";
            this.btn_remover.Size = new System.Drawing.Size(86, 32);
            this.btn_remover.TabIndex = 19;
            this.btn_remover.Text = "Remover";
            this.btn_remover.UseVisualStyleBackColor = true;
            this.btn_remover.Click += new System.EventHandler(this.btn_remover_Click);
            // 
            // cb_mesa
            // 
            this.cb_mesa.Enabled = false;
            this.cb_mesa.FormattingEnabled = true;
            this.cb_mesa.Location = new System.Drawing.Point(175, 76);
            this.cb_mesa.Name = "cb_mesa";
            this.cb_mesa.Size = new System.Drawing.Size(120, 24);
            this.cb_mesa.TabIndex = 27;
            // 
            // lbl_mesa
            // 
            this.lbl_mesa.AutoSize = true;
            this.lbl_mesa.Location = new System.Drawing.Point(117, 81);
            this.lbl_mesa.Name = "lbl_mesa";
            this.lbl_mesa.Size = new System.Drawing.Size(49, 16);
            this.lbl_mesa.TabIndex = 28;
            this.lbl_mesa.Text = "Mesa*:";
            // 
            // lbl_data_abertura
            // 
            this.lbl_data_abertura.AutoSize = true;
            this.lbl_data_abertura.Location = new System.Drawing.Point(361, 51);
            this.lbl_data_abertura.Name = "lbl_data_abertura";
            this.lbl_data_abertura.Size = new System.Drawing.Size(117, 16);
            this.lbl_data_abertura.TabIndex = 30;
            this.lbl_data_abertura.Text = "Data de Abertura*:";
            // 
            // txt_data_abertura
            // 
            this.txt_data_abertura.Location = new System.Drawing.Point(487, 45);
            this.txt_data_abertura.Name = "txt_data_abertura";
            this.txt_data_abertura.ReadOnly = true;
            this.txt_data_abertura.Size = new System.Drawing.Size(120, 22);
            this.txt_data_abertura.TabIndex = 29;
            // 
            // lbl_data_fechamento
            // 
            this.lbl_data_fechamento.AutoSize = true;
            this.lbl_data_fechamento.Location = new System.Drawing.Point(342, 79);
            this.lbl_data_fechamento.Name = "lbl_data_fechamento";
            this.lbl_data_fechamento.Size = new System.Drawing.Size(136, 16);
            this.lbl_data_fechamento.TabIndex = 32;
            this.lbl_data_fechamento.Text = "Data de Fechamento:";
            // 
            // txt_data_fechamento
            // 
            this.txt_data_fechamento.Location = new System.Drawing.Point(487, 76);
            this.txt_data_fechamento.Name = "txt_data_fechamento";
            this.txt_data_fechamento.ReadOnly = true;
            this.txt_data_fechamento.Size = new System.Drawing.Size(120, 22);
            this.txt_data_fechamento.TabIndex = 31;
            // 
            // CD_CONTA
            // 
            this.CD_CONTA.DataPropertyName = "CD_CONTA";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.CD_CONTA.DefaultCellStyle = dataGridViewCellStyle1;
            this.CD_CONTA.HeaderText = "Código";
            this.CD_CONTA.MinimumWidth = 6;
            this.CD_CONTA.Name = "CD_CONTA";
            this.CD_CONTA.ReadOnly = true;
            this.CD_CONTA.Width = 60;
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
            this.FK_CD_MESA.Width = 60;
            // 
            // DATA_HORA_ABERTURA
            // 
            this.DATA_HORA_ABERTURA.DataPropertyName = "DATA_HORA_ABERTURA";
            dataGridViewCellStyle3.Format = "G";
            dataGridViewCellStyle3.NullValue = null;
            this.DATA_HORA_ABERTURA.DefaultCellStyle = dataGridViewCellStyle3;
            this.DATA_HORA_ABERTURA.HeaderText = "Data Abertura";
            this.DATA_HORA_ABERTURA.MinimumWidth = 6;
            this.DATA_HORA_ABERTURA.Name = "DATA_HORA_ABERTURA";
            this.DATA_HORA_ABERTURA.ReadOnly = true;
            this.DATA_HORA_ABERTURA.Width = 125;
            // 
            // DATA_HORA_FECHAMENTO
            // 
            this.DATA_HORA_FECHAMENTO.DataPropertyName = "DATA_HORA_FECHAMENTO";
            dataGridViewCellStyle4.Format = "G";
            dataGridViewCellStyle4.NullValue = null;
            this.DATA_HORA_FECHAMENTO.DefaultCellStyle = dataGridViewCellStyle4;
            this.DATA_HORA_FECHAMENTO.HeaderText = "Data Fechamento";
            this.DATA_HORA_FECHAMENTO.MinimumWidth = 6;
            this.DATA_HORA_FECHAMENTO.Name = "DATA_HORA_FECHAMENTO";
            this.DATA_HORA_FECHAMENTO.ReadOnly = true;
            this.DATA_HORA_FECHAMENTO.Width = 150;
            // 
            // ContaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(875, 444);
            this.Controls.Add(this.lbl_data_fechamento);
            this.Controls.Add(this.txt_data_fechamento);
            this.Controls.Add(this.lbl_data_abertura);
            this.Controls.Add(this.txt_data_abertura);
            this.Controls.Add(this.cb_mesa);
            this.Controls.Add(this.lbl_mesa);
            this.Controls.Add(this.btn_remover);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_cd_conta);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.btn_novo);
            this.Controls.Add(this.lbl_cd_conta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "ContaView";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Mesa";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_cd_conta;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.TextBox txt_cd_conta;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDPRODUTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRICAODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRECOCUSTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eSTOQUEMINIMODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eSTOQUEATUALDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_remover;
        private System.Windows.Forms.ComboBox cb_mesa;
        private System.Windows.Forms.Label lbl_mesa;
        private System.Windows.Forms.Label lbl_data_abertura;
        private System.Windows.Forms.TextBox txt_data_abertura;
        private System.Windows.Forms.Label lbl_data_fechamento;
        private System.Windows.Forms.TextBox txt_data_fechamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn CD_CONTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn FK_CD_MESA;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATA_HORA_ABERTURA;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATA_HORA_FECHAMENTO;
    }
}