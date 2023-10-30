namespace PrjClassesAbstratas.Fomulários
{
    partial class FrmCadastro
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.grpProf = new System.Windows.Forms.GroupBox();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.txtCate = new System.Windows.Forms.TextBox();
            this.txtLicen = new System.Windows.Forms.TextBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.GrpAluno = new System.Windows.Forms.GroupBox();
            this.txtCpfAluno = new System.Windows.Forms.TextBox();
            this.txtNomeAluno = new System.Windows.Forms.TextBox();
            this.txtEndAluno = new System.Windows.Forms.TextBox();
            this.txtTurma = new System.Windows.Forms.TextBox();
            this.txtCurso = new System.Windows.Forms.TextBox();
            this.btnExcluirAluno = new System.Windows.Forms.Button();
            this.btnIncluirAluno = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.d = new System.Windows.Forms.Label();
            this.lbkl2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.grpProf.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.GrpAluno.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 14);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 492);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.tabPage1.Controls.Add(this.grpProf);
            this.tabPage1.Controls.Add(this.btnExcluir);
            this.tabPage1.Controls.Add(this.btnIncluir);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 466);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Professores";
            // 
            // grpProf
            // 
            this.grpProf.BackColor = System.Drawing.Color.PaleGreen;
            this.grpProf.Controls.Add(this.txtCpf);
            this.grpProf.Controls.Add(this.txtName);
            this.grpProf.Controls.Add(this.txtEnd);
            this.grpProf.Controls.Add(this.txtCate);
            this.grpProf.Controls.Add(this.txtLicen);
            this.grpProf.Location = new System.Drawing.Point(298, 6);
            this.grpProf.Name = "grpProf";
            this.grpProf.Size = new System.Drawing.Size(280, 311);
            this.grpProf.TabIndex = 12;
            this.grpProf.TabStop = false;
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(9, 48);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(253, 29);
            this.txtCpf.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(9, 93);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(253, 29);
            this.txtName.TabIndex = 1;
            // 
            // txtEnd
            // 
            this.txtEnd.Location = new System.Drawing.Point(9, 141);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(253, 29);
            this.txtEnd.TabIndex = 2;
            // 
            // txtCate
            // 
            this.txtCate.Location = new System.Drawing.Point(9, 188);
            this.txtCate.Name = "txtCate";
            this.txtCate.Size = new System.Drawing.Size(253, 29);
            this.txtCate.TabIndex = 4;
            // 
            // txtLicen
            // 
            this.txtLicen.Location = new System.Drawing.Point(9, 240);
            this.txtLicen.Name = "txtLicen";
            this.txtLicen.Size = new System.Drawing.Size(253, 29);
            this.txtLicen.TabIndex = 3;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Location = new System.Drawing.Point(404, 340);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(100, 39);
            this.btnExcluir.TabIndex = 11;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnIncluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncluir.Location = new System.Drawing.Point(233, 340);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(102, 39);
            this.btnIncluir.TabIndex = 10;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = false;
            this.btnIncluir.Click += new System.EventHandler(this.BtnIncluir_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(137, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Categoria";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(137, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Licenciatura";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(137, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Endereço";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "CPF";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.tabPage2.Controls.Add(this.GrpAluno);
            this.tabPage2.Controls.Add(this.btnExcluirAluno);
            this.tabPage2.Controls.Add(this.btnIncluirAluno);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.d);
            this.tabPage2.Controls.Add(this.lbkl2);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.lbl7);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 466);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Alunos";
            // 
            // GrpAluno
            // 
            this.GrpAluno.BackColor = System.Drawing.Color.PaleGreen;
            this.GrpAluno.Controls.Add(this.txtCpfAluno);
            this.GrpAluno.Controls.Add(this.txtNomeAluno);
            this.GrpAluno.Controls.Add(this.txtEndAluno);
            this.GrpAluno.Controls.Add(this.txtTurma);
            this.GrpAluno.Controls.Add(this.txtCurso);
            this.GrpAluno.Location = new System.Drawing.Point(250, 32);
            this.GrpAluno.Name = "GrpAluno";
            this.GrpAluno.Size = new System.Drawing.Size(304, 271);
            this.GrpAluno.TabIndex = 12;
            this.GrpAluno.TabStop = false;
            // 
            // txtCpfAluno
            // 
            this.txtCpfAluno.Location = new System.Drawing.Point(15, 18);
            this.txtCpfAluno.Name = "txtCpfAluno";
            this.txtCpfAluno.Size = new System.Drawing.Size(268, 29);
            this.txtCpfAluno.TabIndex = 9;
            // 
            // txtNomeAluno
            // 
            this.txtNomeAluno.Location = new System.Drawing.Point(15, 66);
            this.txtNomeAluno.Name = "txtNomeAluno";
            this.txtNomeAluno.Size = new System.Drawing.Size(268, 29);
            this.txtNomeAluno.TabIndex = 8;
            // 
            // txtEndAluno
            // 
            this.txtEndAluno.Location = new System.Drawing.Point(15, 114);
            this.txtEndAluno.Name = "txtEndAluno";
            this.txtEndAluno.Size = new System.Drawing.Size(268, 29);
            this.txtEndAluno.TabIndex = 7;
            // 
            // txtTurma
            // 
            this.txtTurma.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTurma.Location = new System.Drawing.Point(15, 214);
            this.txtTurma.Name = "txtTurma";
            this.txtTurma.Size = new System.Drawing.Size(268, 29);
            this.txtTurma.TabIndex = 5;
            // 
            // txtCurso
            // 
            this.txtCurso.Location = new System.Drawing.Point(15, 170);
            this.txtCurso.Name = "txtCurso";
            this.txtCurso.Size = new System.Drawing.Size(268, 29);
            this.txtCurso.TabIndex = 6;
            // 
            // btnExcluirAluno
            // 
            this.btnExcluirAluno.BackColor = System.Drawing.Color.Silver;
            this.btnExcluirAluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirAluno.Location = new System.Drawing.Point(414, 338);
            this.btnExcluirAluno.Name = "btnExcluirAluno";
            this.btnExcluirAluno.Size = new System.Drawing.Size(119, 44);
            this.btnExcluirAluno.TabIndex = 11;
            this.btnExcluirAluno.Text = "Excluir";
            this.btnExcluirAluno.UseVisualStyleBackColor = false;
            this.btnExcluirAluno.Click += new System.EventHandler(this.BtnExcluirAluno_Click);
            // 
            // btnIncluirAluno
            // 
            this.btnIncluirAluno.BackColor = System.Drawing.Color.Silver;
            this.btnIncluirAluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncluirAluno.Location = new System.Drawing.Point(232, 338);
            this.btnIncluirAluno.Name = "btnIncluirAluno";
            this.btnIncluirAluno.Size = new System.Drawing.Size(108, 44);
            this.btnIncluirAluno.TabIndex = 10;
            this.btnIncluirAluno.Text = "Incluir";
            this.btnIncluirAluno.UseVisualStyleBackColor = false;
            this.btnIncluirAluno.Click += new System.EventHandler(this.BtnIncluirAluno_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(148, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 24);
            this.label11.TabIndex = 4;
            this.label11.Text = "CPF";
            // 
            // d
            // 
            this.d.AutoSize = true;
            this.d.Location = new System.Drawing.Point(147, 146);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(94, 24);
            this.d.TabIndex = 3;
            this.d.Text = "Endereço";
            // 
            // lbkl2
            // 
            this.lbkl2.AutoSize = true;
            this.lbkl2.Location = new System.Drawing.Point(148, 98);
            this.lbkl2.Name = "lbkl2";
            this.lbkl2.Size = new System.Drawing.Size(62, 24);
            this.lbkl2.TabIndex = 2;
            this.lbkl2.Text = "Nome";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(147, 202);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 24);
            this.label8.TabIndex = 1;
            this.label8.Text = "Curso";
            // 
            // lbl7
            // 
            this.lbl7.AutoSize = true;
            this.lbl7.Location = new System.Drawing.Point(148, 246);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(65, 24);
            this.lbl7.TabIndex = 0;
            this.lbl7.Text = "Turma";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblStatus);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(78, 512);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(567, 185);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Status";
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblStatus.Location = new System.Drawing.Point(25, 35);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(514, 127);
            this.lblStatus.TabIndex = 0;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Silver;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(213, 704);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(116, 34);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Limpar";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Silver;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(382, 703);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(116, 34);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Fechar";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // FrmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 762);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "FrmCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.grpProf.ResumeLayout(false);
            this.grpProf.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.GrpAluno.ResumeLayout(false);
            this.GrpAluno.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCate;
        private System.Windows.Forms.TextBox txtLicen;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtCpfAluno;
        private System.Windows.Forms.TextBox txtNomeAluno;
        private System.Windows.Forms.TextBox txtEndAluno;
        private System.Windows.Forms.TextBox txtCurso;
        private System.Windows.Forms.TextBox txtTurma;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label d;
        private System.Windows.Forms.Label lbkl2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnExcluirAluno;
        private System.Windows.Forms.Button btnIncluirAluno;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox grpProf;
        private System.Windows.Forms.GroupBox GrpAluno;
    }
}