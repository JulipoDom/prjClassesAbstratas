namespace CadUser
{
    partial class FrmConsulta
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RdoListaGeral = new System.Windows.Forms.RadioButton();
            this.RdoConsultaCod = new System.Windows.Forms.RadioButton();
            this.RdoConsultaNome = new System.Windows.Forms.RadioButton();
            this.TxtConsultaCod = new System.Windows.Forms.TextBox();
            this.TxtConsultaNome = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnPesquisar = new System.Windows.Forms.Button();
            this.BtnVoltar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(487, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "LISTAGEM DO CADASTRO DE USUÁRIOS";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnPesquisar);
            this.groupBox1.Controls.Add(this.TxtConsultaNome);
            this.groupBox1.Controls.Add(this.TxtConsultaCod);
            this.groupBox1.Controls.Add(this.RdoConsultaNome);
            this.groupBox1.Controls.Add(this.RdoConsultaCod);
            this.groupBox1.Controls.Add(this.RdoListaGeral);
            this.groupBox1.Location = new System.Drawing.Point(12, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(608, 134);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecione o tipo de consulta:";
            // 
            // RdoListaGeral
            // 
            this.RdoListaGeral.AutoSize = true;
            this.RdoListaGeral.Location = new System.Drawing.Point(26, 29);
            this.RdoListaGeral.Name = "RdoListaGeral";
            this.RdoListaGeral.Size = new System.Drawing.Size(75, 17);
            this.RdoListaGeral.TabIndex = 0;
            this.RdoListaGeral.TabStop = true;
            this.RdoListaGeral.Text = "Lista Geral";
            this.RdoListaGeral.UseVisualStyleBackColor = true;
            // 
            // RdoConsultaCod
            // 
            this.RdoConsultaCod.AutoSize = true;
            this.RdoConsultaCod.Location = new System.Drawing.Point(26, 62);
            this.RdoConsultaCod.Name = "RdoConsultaCod";
            this.RdoConsultaCod.Size = new System.Drawing.Size(120, 17);
            this.RdoConsultaCod.TabIndex = 1;
            this.RdoConsultaCod.TabStop = true;
            this.RdoConsultaCod.Text = "Consulta por Código";
            this.RdoConsultaCod.UseVisualStyleBackColor = true;
            // 
            // RdoConsultaNome
            // 
            this.RdoConsultaNome.AutoSize = true;
            this.RdoConsultaNome.Location = new System.Drawing.Point(26, 96);
            this.RdoConsultaNome.Name = "RdoConsultaNome";
            this.RdoConsultaNome.Size = new System.Drawing.Size(115, 17);
            this.RdoConsultaNome.TabIndex = 2;
            this.RdoConsultaNome.TabStop = true;
            this.RdoConsultaNome.Text = "Consulta por Nome";
            this.RdoConsultaNome.UseVisualStyleBackColor = true;
            // 
            // TxtConsultaCod
            // 
            this.TxtConsultaCod.Location = new System.Drawing.Point(152, 62);
            this.TxtConsultaCod.Name = "TxtConsultaCod";
            this.TxtConsultaCod.Size = new System.Drawing.Size(131, 20);
            this.TxtConsultaCod.TabIndex = 3;
            // 
            // TxtConsultaNome
            // 
            this.TxtConsultaNome.Location = new System.Drawing.Point(152, 93);
            this.TxtConsultaNome.Name = "TxtConsultaNome";
            this.TxtConsultaNome.Size = new System.Drawing.Size(266, 20);
            this.TxtConsultaNome.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 211);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(617, 166);
            this.dataGridView1.TabIndex = 3;
            // 
            // BtnPesquisar
            // 
            this.BtnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPesquisar.Location = new System.Drawing.Point(445, 51);
            this.BtnPesquisar.Name = "BtnPesquisar";
            this.BtnPesquisar.Size = new System.Drawing.Size(148, 33);
            this.BtnPesquisar.TabIndex = 5;
            this.BtnPesquisar.Text = "Pesquisar >>";
            this.BtnPesquisar.UseVisualStyleBackColor = true;
            // 
            // BtnVoltar
            // 
            this.BtnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVoltar.Location = new System.Drawing.Point(259, 400);
            this.BtnVoltar.Name = "BtnVoltar";
            this.BtnVoltar.Size = new System.Drawing.Size(148, 33);
            this.BtnVoltar.TabIndex = 6;
            this.BtnVoltar.Text = "<< Voltar";
            this.BtnVoltar.UseVisualStyleBackColor = true;
            // 
            // FrmConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 450);
            this.Controls.Add(this.BtnVoltar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "FrmConsulta";
            this.Text = "FrmConsulta";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnPesquisar;
        private System.Windows.Forms.TextBox TxtConsultaNome;
        private System.Windows.Forms.TextBox TxtConsultaCod;
        private System.Windows.Forms.RadioButton RdoConsultaNome;
        private System.Windows.Forms.RadioButton RdoConsultaCod;
        private System.Windows.Forms.RadioButton RdoListaGeral;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnVoltar;
    }
}