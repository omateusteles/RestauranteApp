
namespace RestauranteApp.View
{
    partial class MesaView
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
            this.lbl_cd_mesa = new System.Windows.Forms.Label();
            this.lbl_localizacao = new System.Windows.Forms.Label();
            this.txt_localizacao = new System.Windows.Forms.TextBox();
            this.btn_novo = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.txt_cd_mesa = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CD_MESA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LOCALIZACAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_remover = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_cd_mesa
            // 
            this.lbl_cd_mesa.AutoSize = true;
            this.lbl_cd_mesa.Location = new System.Drawing.Point(107, 48);
            this.lbl_cd_mesa.Name = "lbl_cd_mesa";
            this.lbl_cd_mesa.Size = new System.Drawing.Size(59, 16);
            this.lbl_cd_mesa.TabIndex = 4;
            this.lbl_cd_mesa.Text = "Código*:";
            // 
            // lbl_localizacao
            // 
            this.lbl_localizacao.AutoSize = true;
            this.lbl_localizacao.Location = new System.Drawing.Point(78, 79);
            this.lbl_localizacao.Name = "lbl_localizacao";
            this.lbl_localizacao.Size = new System.Drawing.Size(88, 16);
            this.lbl_localizacao.TabIndex = 6;
            this.lbl_localizacao.Text = "Localização*:";
            // 
            // txt_localizacao
            // 
            this.txt_localizacao.Location = new System.Drawing.Point(181, 76);
            this.txt_localizacao.Name = "txt_localizacao";
            this.txt_localizacao.ReadOnly = true;
            this.txt_localizacao.Size = new System.Drawing.Size(114, 22);
            this.txt_localizacao.TabIndex = 2;
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
            // txt_cd_mesa
            // 
            this.txt_cd_mesa.Location = new System.Drawing.Point(181, 45);
            this.txt_cd_mesa.Name = "txt_cd_mesa";
            this.txt_cd_mesa.ReadOnly = true;
            this.txt_cd_mesa.Size = new System.Drawing.Size(114, 22);
            this.txt_cd_mesa.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CD_MESA,
            this.LOCALIZACAO});
            this.dataGridView1.Location = new System.Drawing.Point(59, 163);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(752, 214);
            this.dataGridView1.TabIndex = 17;
            // 
            // CD_MESA
            // 
            this.CD_MESA.DataPropertyName = "CD_MESA";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.CD_MESA.DefaultCellStyle = dataGridViewCellStyle1;
            this.CD_MESA.HeaderText = "Código";
            this.CD_MESA.MinimumWidth = 6;
            this.CD_MESA.Name = "CD_MESA";
            this.CD_MESA.ReadOnly = true;
            this.CD_MESA.Width = 70;
            // 
            // LOCALIZACAO
            // 
            this.LOCALIZACAO.DataPropertyName = "LOCALIZACAO";
            this.LOCALIZACAO.HeaderText = "Localização";
            this.LOCALIZACAO.MinimumWidth = 6;
            this.LOCALIZACAO.Name = "LOCALIZACAO";
            this.LOCALIZACAO.ReadOnly = true;
            this.LOCALIZACAO.Width = 125;
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
            // MesaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(875, 444);
            this.Controls.Add(this.btn_remover);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_cd_mesa);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.btn_novo);
            this.Controls.Add(this.lbl_localizacao);
            this.Controls.Add(this.txt_localizacao);
            this.Controls.Add(this.lbl_cd_mesa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MesaView";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Mesa";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_cd_mesa;
        private System.Windows.Forms.Label lbl_localizacao;
        private System.Windows.Forms.TextBox txt_localizacao;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.TextBox txt_cd_mesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDPRODUTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRICAODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRECOCUSTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eSTOQUEMINIMODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eSTOQUEATUALDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_remover;
        private System.Windows.Forms.DataGridViewTextBoxColumn CD_MESA;
        private System.Windows.Forms.DataGridViewTextBoxColumn LOCALIZACAO;
    }
}